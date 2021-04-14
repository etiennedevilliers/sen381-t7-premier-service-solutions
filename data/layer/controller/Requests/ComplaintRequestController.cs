using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller 
{
    class ComplaintRequestController : ICreate<ComplaintRequest>, IDelete<ComplaintRequest>, IRead<ComplaintRequest>, IUpdate<ComplaintRequest>
    {
        public int Create(ComplaintRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.id = requestController.Create(obj);

            dh.Insert(string.Format(
                "INSERT INTO ComplaintRequest(ComplaintRequestID, ServiceContractID, description) VALUES ({0}, null, '{1}')",
                obj.id,
                obj.description
            ));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(ComplaintRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("ComplaintRequest", "ComplaintRequestID = " + obj.id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<ComplaintRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<ComplaintRequest> complaintRequests = new List<ComplaintRequest>();

            String query = "SELECT C.ComplaintRequestID, C.description, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming " +
                           "FROM dbo.ComplaintRequest AS C " +
                           "LEFT JOIN dbo.Request AS R ON R.RequestID = C.ComplaintRequestID " +
                           "LEFT JOIN dbo.CallLog AS CL ON CL.CallID = R.CallID";

            SqlDataReader read = dh.Select(query);
            ComplaintRequest complaintRequest;
            CallLogController callLogController = new CallLogController();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    CallLog callLog = new CallLog(
                        read.GetInt32(7),
                        read.GetDateTime(8),
                        read.GetDateTime(9),
                        //read agent ID(10)???
                        read.GetBoolean(11)
                    );

                    complaintRequest = new ComplaintRequest(
                        read.GetDateTime(4),
                        read.GetDateTime(5),
                        callLog,
                        read.GetString(1)
                    );


                    complaintRequest.id = read.GetInt32(0);
                    // newClientRequest.client = ClientController.ReadSpecific(read.GetInt32(1));
                    complaintRequest.contactNum = read.GetString(3);
                    complaintRequest.status = read.GetString(6);

                    complaintRequests.Add(complaintRequest);
                }
            }
            dh.Dispose();
            return complaintRequests;
        }

        public void Update(ComplaintRequest obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(String.Format(
                "UPDATE dbo.ComplaintRequest SET description='{1}' WHERE ComplaintRequestID={0}",
                obj.id,
                obj.description
                //obj.serviceContract.id
            ));

            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Update(obj);
        }
    }
}
