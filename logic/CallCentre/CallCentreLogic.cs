using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic
{
    public class CallCentreLogic
    {
        private CallLog callLog;

        public CallCentreLogic(Agent agent, Boolean incoming)
        {
            callLog = new CallLog(DateTime.Now, incoming);
            callLog.Representative = agent;
        }

        public static List<Agent> GetCallCentreEmployees()
        {
            List<Agent> callCentreAgents = new List<Agent>();
            AgentController agentController = new AgentController();

            foreach (Agent agent in agentController.Read())
            {
                if (agent.EmployeeType == "CallCentre")
                    callCentreAgents.Add(agent);
            }

            return callCentreAgents;
        }

        public void CreateNewClientRequest(String contactNumber)
        {
            endCall();

            NewClientRequestController newClientRequestController = new NewClientRequestController();

            NewClientRequest newClientRequest = new NewClientRequest(DateTime.Now, null, callLog);
            newClientRequest.ContactNum = contactNumber;

            newClientRequestController.Create(newClientRequest);
        }

        public void CreateNewComplaintRequest(String complaintDescription, Client client, ServiceContract serviceContract)
        {
            endCall();

            ComplaintRequestController complaintRequestController = new ComplaintRequestController();
            RequestController requestController = new RequestController();

            ComplaintRequest complaintRequst = new ComplaintRequest(
                DateTime.Now,
                null,
                callLog,
                complaintDescription
            );


            complaintRequestController.Create(complaintRequst);


            requestController.Set(client, complaintRequst);
            complaintRequestController.Set(serviceContract, complaintRequst);
        }

        public void CreateNewNewContractRequest(ServiceContract serviceContract, Client client)
        {
            endCall();
            NewContractRequestController newContractRequestController = new NewContractRequestController();
            RequestController requestController = new RequestController();

            NewContractRequest newContractRequest = new NewContractRequest(
                DateTime.Now,
                null,
                callLog
            );

            newContractRequestController.Create(newContractRequest);
            newContractRequestController.Set(serviceContract, newContractRequest);
            requestController.Set(client, newContractRequest);
        }

        public void CreateNewServiceRequest(ServiceContract serviceContract, Client client, string desc)
        {
            endCall();

            ServiceRequestController serviceRequestController = new ServiceRequestController();
            RequestController requestController = new RequestController();

            ServiceRequest serviceRequest = new ServiceRequest(
                DateTime.Now,
                null,
                callLog,
                desc
            );

            serviceRequestController.Create(serviceRequest);
            serviceRequestController.Set(serviceContract, serviceRequest);
            requestController.Set(client, serviceRequest);

        }
        private void endCall()
        {
            CallLogController callLogController = new CallLogController();
            callLog.TimeEnded = DateTime.Now;
            callLogController.Create(callLog);
        }


    }
}
