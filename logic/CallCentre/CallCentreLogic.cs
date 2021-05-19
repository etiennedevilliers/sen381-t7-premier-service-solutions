using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic.CallCentre
{
    public class CallCentreLogic
    {
        public void CreateNewClientRequest(string contactNumber, CallLog callLog, bool ind)
        {
            EndCall(callLog);

            NewClientRequestController newClientRequestController = new NewClientRequestController();

            NewClientRequest newClientRequest = new NewClientRequest(ind, DateTime.Now, null, callLog);
            newClientRequest.ContactNum = contactNumber;

            newClientRequestController.Create(newClientRequest);
        }

        public void CreateNewComplaintRequest(string complaintDescription, Client client, ServiceContract serviceContract, CallLog callLog)
        {
            EndCall(callLog);

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

        public void CreateNewNewContractRequest(ServiceContract serviceContract, Client client, CallLog callLog)
        {
            EndCall(callLog);
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

        public void CreateNewServiceRequest(ServiceContract serviceContract, Client client, string desc, CallLog callLog)
        {
            EndCall(callLog);

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

        public void EndCall(CallLog call)
        {
            CallLogController callLogController = new CallLogController();
            call.TimeEnded = DateTime.Now;
            callLogController.Create(call);
        }
    }
}
