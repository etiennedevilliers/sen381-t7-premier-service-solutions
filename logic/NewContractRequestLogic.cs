using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace sen381_t7_premier_service_solutions.logic
{
    class NewContractRequestLogic
    {
        private CallLog callLog;
        private NewContractRequest NewContractRequest;

        public NewContractRequestLogic(Agent agent, Boolean incoming, NewContractRequest newContractRequest)
        {
            callLog = new CallLog(DateTime.Now, incoming);
            callLog.Representative = agent;
        }




        private void endCall()
        {
            CallLogController callLogController = new CallLogController();
            callLog.TimeEnded = DateTime.Now;
            callLogController.Create(callLog);
        }
    }
}
