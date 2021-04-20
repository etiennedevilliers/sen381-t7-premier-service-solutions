using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller 
{
    class ServiceRequestController : RequestServiceContractHandler, ICreate<ServiceRequest>, IDelete<ServiceRequest>, IRead<ServiceRequest>, IUpdate<ServiceRequest>
    {
        public ServiceRequestController() : base("ServiceRequest", "ServiceRequestID") {}

        public int Create(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();

            RequestController requestController = new RequestController();
            obj.id = requestController.Create(obj);

            String query = string.Format(
                "INSERT INTO ServiceRequest(ServiceRequestID, description, jobStarted) VALUES ({0}, '{1}', '{2}')",
                obj.id,
                obj.description,
                obj.jobStarted.ToString("yyyy-MM-dd HH:mm:ss.fff")
            );

            dh.Insert(query);

            dh.Dispose();

            return obj.id;
        }

        public void Delete(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("ServiceRequest", "ServiceRequestID = " + obj.id.ToString());
            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Delete(obj);
        }

        public List<ServiceRequest> Read()
        {
            DataHandler dh = new DataHandler();

            List<ServiceRequest> serviceRequests = new List<ServiceRequest>();


            String query = "SELECT S.ServiceRequestID, S.description, S.jobStarted, R.ClientID, R.contactNum, R.dateCreated, R.dateResolved, R.status, CL.CallID, CL.timeStarted, CL.timeEnded, CL.AgentID, CL.incoming " + 
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
                        read.GetInt32(8),
                        read.GetDateTime(9),
                        read.GetDateTime(10),
                        // 11 is CallLog.AgentID
                        read.GetBoolean(12)
                    );

                    serviceRequest = new ServiceRequest(
                        read.GetDateTime(5),
                        read.GetDateTime(6),
                        callLog,
                        read.GetString(1),
                        read.GetDateTime(2)
                    );


                    serviceRequest.id = read.GetInt32(0);
                    serviceRequest.contactNum = read.GetString(4);
                    serviceRequest.status = read.GetString(7);

                    serviceRequests.Add(serviceRequest);
                }
            }
            dh.Dispose();

            return serviceRequests;
        }

        public void Update(ServiceRequest obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(String.Format(
                "UPDATE dbo.ServiceRequest SET description='{1}', jobStarted={2} WHERE ServiceRequestID={0}",
                obj.id,
                obj.description,
                obj.jobStarted
            ));

            dh.Dispose();

            RequestController requestController = new RequestController();
            requestController.Update(obj);
        }
    }
}