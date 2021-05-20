using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    class NewContractRequestController : RequestServiceContractHandler, ICreate<NewContractRequest>, IDelete<NewContractRequest>, IRead<NewContractRequest>, IUpdate<NewContractRequest>
    {
        //Basic CRUD
        public NewContractRequestController() : base("NewContractRequest", "NewContractRequestID") {}

        public int Create(NewContractRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.Id = requestController.Create(obj);

            dh.Insert(string.Format(
                "INSERT INTO NewContractRequest(NewContractRequestID, ServiceContractID) VALUES ({0}, null)",
                obj.Id
            ));

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(NewContractRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("NewContractRequest", "NewContractRequestID = " + obj.Id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<NewContractRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<NewContractRequest> contractRequests = new List<NewContractRequest>();

            string query = "SELECT N.NewContractRequestID, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming " + 
                            "FROM dbo.NewContractRequest AS N " +
	                            "LEFT JOIN dbo.Request AS R ON R.RequestID = N.NewContractRequestID " +
                                "LEFT JOIN dbo.CallLog AS CL ON CL.CallID = R.CallID";

            SqlDataReader read = dh.Select(query);
            NewContractRequest newContractRequest;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    CallLog callLog = new CallLog(
                        read.GetDateTime(7),
                        read.GetDateTime(8),
                        //read agent ID(9)???
                        read.GetBoolean(10)
                    );

                    callLog.Id = read.GetInt32(6);

                    newContractRequest = new NewContractRequest(
                        read.GetDateTime(3),
                        read.IsDBNull(4) ? null : (DateTime?)read.GetDateTime(4),
                        callLog
                    );

                    newContractRequest.Id = read.GetInt32(0);
                    newContractRequest.ContactNum = read.IsDBNull(2) ? null : read.GetString(2);
                    newContractRequest.Status = read.GetString(5);

                    contractRequests.Add(newContractRequest);
                }
            }
            dh.Dispose();
            return contractRequests;
        }

        public void Update(NewContractRequest obj)
        {
            RequestController requestController = new RequestController();
            requestController.Update(obj);
        }
    }
}
