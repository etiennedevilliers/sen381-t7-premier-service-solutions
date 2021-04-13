using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;


namespace data.layer.controller 
{
    class NewClientRequestController : ICreate<NewClientRequest>, IDelete<NewClientRequest>, IUpdate<NewClientRequest>, IRead<NewClientRequest>
    {
        public int Create(NewClientRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.id = requestController.Create(obj);

            dh.Insert(string.Format(
                "INSERT INTO NewClientRequest(NewClientRequestID) VALUES ({0})",
                obj.id
            ));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(NewClientRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("NewClientRequestID", "NewClientRequestID = " + obj.id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<NewClientRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<NewClientRequest> clientRequests = new List<NewClientRequest>();
            SqlDataReader read = dh.Select("SELECT C.NewClientRequestID, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming FROM dbo.NewClientRequest AS C LEFT JOIN dbo.Request AS R ON R.RequestID = C.NewClientRequestID LEFT JOIN dbo.CallLog AS CL ON CL.CallID = R.CallID");
            NewClientRequest newClientRequest;
            CallLogController callLogController = new CallLogController();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    CallLog callLog = new CallLog(
                        read.GetInt32(6),
                        read.GetDateTime(7),
                        read.GetDateTime(8),
                        //read agent ID(9)???
                        read.GetBoolean(10)
                    );

                    newClientRequest = new NewClientRequest(
                        read.GetDateTime(3),
                        read.GetDateTime(4),
                        callLog
                    );


                    newClientRequest.id = read.GetInt32(0);
                    // newClientRequest.client = ClientController.ReadSpecific(read.GetInt32(1));
                    newClientRequest.contactNum = read.GetString(2);
                    newClientRequest.status = read.GetString(5);

                    clientRequests.Add(newClientRequest);
                }
            }
            dh.Dispose();
            return clientRequests;
        }

        public void Update(NewClientRequest obj)
        {
            RequestController requestController = new RequestController();
            requestController.Update(obj);
        }
    }
}
