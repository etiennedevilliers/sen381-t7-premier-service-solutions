using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic
{
    public class NewContractRequestLogic
    {
        private CallLog callLog;
        public NewContractRequest newContractRequest;

        public NewContractRequestLogic(Agent agent, Boolean incoming, NewContractRequest ncr)
        {
            callLog = new CallLog(DateTime.Now, incoming);
            callLog.Representative = agent;

            this.newContractRequest = ncr;
        }

        public void addServiceContract()
        {
            endCall();
            ClientController clientController = new ClientController();
            NewContractRequestController newContractRequestController = new NewContractRequestController();

            clientController.Add(
                newContractRequest.ServiceContract,
                newContractRequest.Client
            );

            newContractRequest.Status = "Resolved";

            newContractRequestController.Update(newContractRequest);




        }



        private void endCall()
        {
            CallLogController callLogController = new CallLogController();
            callLog.TimeEnded = DateTime.Now;
            callLogController.Create(callLog);
        }
    }
}
