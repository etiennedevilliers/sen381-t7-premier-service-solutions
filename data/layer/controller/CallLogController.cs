using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class CallLogController : ICreate<CallLog>, IRead<CallLog>, IUpdate<CallLog>, IDelete<CallLog>
    {
        public int Create(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            String query = string.Format(
                "INSERT INTO CallLog(timeStarted, timeEnded, AgentID, incoming) VALUES ('{0}', '{1}', null, {2})",
                obj.timeStarted.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.timeEnded.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.incoming ? 1 : 0
            );

            Console.WriteLine(query);

            int ID = dh.InsertID(query);

            dh.Dispose();

            return ID;
        }

        public void Delete(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("CallLog", "CallLog = " + obj.id.ToString());

            dh.Dispose();
        }

        public List<CallLog> Read()
        {
            DataHandler dh = new DataHandler();

            List<CallLog> callLogs = new List<CallLog>();
            SqlDataReader read = dh.Select("SELECT CallID, timeStarted, timeEnded, incoming FROM CallLog");
            CallLog newCallLog;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newCallLog = new CallLog(
                        read.GetInt32(0),
                        read.GetDateTime(1),
                        read.GetDateTime(2),
                        read.GetBoolean(3)
                    );

                    callLogs.Add(newCallLog);
                }
            }
            dh.Dispose();
            return callLogs;
        }

        public void Update(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.CallLog SET timeStarted='{1}', timeEnded='{2}', AgentID=null, incoming={3} WHERE CallID = {0}", 
                obj.id,
                obj.timeStarted.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.timeEnded.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.incoming ? 1 : 0
            ));

            dh.Dispose();
        }
    }
}
