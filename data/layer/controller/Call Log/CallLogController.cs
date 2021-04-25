using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class CallLogController : ICreate<CallLog>, IRead<CallLog>, IUpdate<CallLog>, IDelete<CallLog>, IReadSpecific<CallLog>
    {
        //Basic CRUD
        public int Create(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO CallLog(timeStarted, timeEnded, AgentID, incoming) VALUES ('{0}', '{1}', null, {2})",
                obj.TimeStarted.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.TimeEnded.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.Incoming ? 1 : 0
            );

            Console.WriteLine(query);

            obj.Id = dh.InsertID(query);

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("CallLog", "CallLog = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<CallLog> Read()
        {
            DataHandler dh = new DataHandler();

            List<CallLog> callLogs = new List<CallLog>();
            SqlDataReader read = dh.Select("SELECT CallID, timeStarted, timeEnded, incoming FROM CallLog");
            CallLog callLog;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    callLog = new CallLog(
                        read.GetDateTime(1),
                        read.GetDateTime(2),
                        read.GetBoolean(3)
                    );

                    callLog.Id = read.GetInt32(0);

                    callLogs.Add(callLog);
                }
            }
            dh.Dispose();
            return callLogs;
        }

        public CallLog ReadSpecific(int ID)
        {
            DataHandler dh = new DataHandler();

            SqlDataReader read = dh.Select(string.Format(
                "SELECT C.CallID, C.timeStarted, C.timeEnded, C.incoming FROM CallLog AS C  WHERE C.CallID = {0}",
                ID
            ));
            CallLog callLog = null;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    callLog = new CallLog(
                        read.GetDateTime(1),
                        read.GetDateTime(2),
                        read.GetBoolean(3)
                    );

                    callLog.Id = ID;
                }
            }
            dh.Dispose();

            return callLog;
        }


        public void Update(CallLog obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.CallLog SET timeStarted='{1}', timeEnded='{2}', AgentID=null, incoming={3} WHERE CallID = {0}", 
                obj.Id,
                obj.TimeStarted.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.TimeEnded.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.Incoming ? 1 : 0
            ));

            dh.Dispose();
        }
    }
}
