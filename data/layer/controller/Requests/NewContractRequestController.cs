using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller 
{
    class NewContractRequestController : RequestServiceContractHandler, ICreate<NewContractRequest>, IDelete<NewContractRequest>, IRead<NewContractRequest>, IUpdate<NewContractRequest>
    {
        public NewContractRequestController() : base("NewContractRequest", "NewContractRequestID") {}
        public int Create(NewContractRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.id = requestController.Create(obj);

            dh.Insert(string.Format(
                "INSERT INTO NewContractRequest(NewContractRequestID, ServiceContractID) VALUES ({0}, null)",
                obj.id
            ));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(NewContractRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("NewContractRequest", "NewContractRequestID = " + obj.id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<NewContractRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<NewContractRequest> contractRequests = new List<NewContractRequest>();

            String query = "SELECT N.NewContractRequestID, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming " + 
                            "FROM dbo.NewContractRequest AS N " +
	                            "LEFT JOIN dbo.Request AS R ON R.RequestID = N.NewContractRequestID " +
                                "LEFT JOIN dbo.CallLog AS CL ON CL.CallID = R.CallID";

            SqlDataReader read = dh.Select(query);
            NewContractRequest newContractRequest;
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

                    newContractRequest = new NewContractRequest(
                        read.GetDateTime(3),
                        read.GetDateTime(4),
                        callLog
                    );


                    newContractRequest.id = read.GetInt32(0);
                    // newContractRequest.client = ClientController.ReadSpecific(read.GetInt32(1));
                    newContractRequest.contactNum = read.GetString(2);
                    newContractRequest.status = read.GetString(5);

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
