using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    class ServiceRequestController : RequestServiceContractHandler, ICreate<ServiceRequest>, IDelete<ServiceRequest>, IRead<ServiceRequest>, IUpdate<ServiceRequest>
    {
        //Basic CRUD
        public ServiceRequestController() : base("ServiceRequest", "ServiceRequestID") {}

        public int Create(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.Id = requestController.Create(obj);

            string query = string.Format(
                "INSERT INTO ServiceRequest(ServiceRequestID, description, jobStarted) VALUES ({0}, '{1}', '{2}')",
                obj.Id,
                obj.Description,
                obj.JobStarted.ToString("yyyy-MM-dd HH:mm:ss.fff")
            );

            dh.Insert(query);

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("ServiceRequest", "ServiceRequestID = " + obj.Id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<ServiceRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<ServiceRequest> serviceRequests = new List<ServiceRequest>();


            string query = "SELECT S.ServiceRequestID, S.description, S.jobStarted, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming " + 
                           "FROM dbo.ServiceRequest AS S " + 
	                            "LEFT JOIN dbo.Request AS R ON R.RequestID = S.ServiceRequestID " +
                                "LEFT JOIN dbo.CallLog AS CL ON CL.CallID = R.CallID";


            SqlDataReader read = dh.Select(query);
            ServiceRequest serviceRequest;
            CallLogController callLogController = new CallLogController();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    CallLog callLog = new CallLog(
                        read.GetDateTime(9),
                        read.GetDateTime(10),
                        // 11 is CallLog.AgentID
                        read.GetBoolean(12)
                    );

                    callLog.Id = read.GetInt32(8);

                    serviceRequest = new ServiceRequest(
                        read.GetDateTime(5),
                        read.GetDateTime(6),
                        callLog,
                        read.GetString(1),
                        read.GetDateTime(2)
                    );


                    serviceRequest.Id = read.GetInt32(0);
                    serviceRequest.ContactNum = read.GetString(4);
                    serviceRequest.Status = read.GetString(7);

                    serviceRequests.Add(serviceRequest);
                }
            }
            dh.Dispose();

            return serviceRequests;
        }

        public void Update(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.ServiceRequest SET description='{1}', jobStarted={2} WHERE ServiceRequestID={0}",
                obj.Id,
                obj.Description,
                obj.JobStarted
            ));

            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Update(obj);
        }
    }
}