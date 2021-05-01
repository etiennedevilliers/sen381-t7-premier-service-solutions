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

        public class DateValidationResponse
        {
            public bool Valid;
            public String NotValidReason;

            public DateValidationResponse(bool valid, string reason)
            {
                this.Valid = valid;
                this.NotValidReason = reason;
            }
        } 

        public NewContractRequestLogic(Agent agent, Boolean incoming, NewContractRequest ncr)
        {
            callLog = new CallLog(DateTime.Now, incoming);
            callLog.Representative = agent;

            this.newContractRequest = ncr;
        }

        public DateValidationResponse checkDateTime(DateTime startDate, DateTime endDate)
        {
            ServiceContract serviceContract = newContractRequest.ServiceContract;
            ClientController clientController = new ClientController();

            if (startDate < serviceContract.DateFinalised)
                return new DateValidationResponse(false, String.Format("This Service Contract is only valid from after {0}", serviceContract.DateFinalised));
            if (endDate > serviceContract.DateTerminated)
                return new DateValidationResponse(false, String.Format("This Service Contract is only valid until {0}", serviceContract.DateTerminated));

            foreach (ClientServiceContract clientSC in clientController.ReadChildren(newContractRequest.Client))
            {
                //bool overlap = a.start < b.end && b.start < a.end;
                bool overlap = startDate < clientSC.EndDate && clientSC.StartDate < endDate;
                if (overlap)
                    return new DateValidationResponse(
                        false,
                        String.Format(
                            "This service overlaps with a assigned ServiceContract: {0}",
                            clientSC
                        )
                    );
            }

            if (endDate < startDate) 
                return new DateValidationResponse(false, "End date cannot be before start date");

            return new DateValidationResponse(true, "");
        }

        public void addServiceContract(DateTime startDate, DateTime endDate)
        {
            endCall();
            ClientController clientController = new ClientController();
            NewContractRequestController newContractRequestController = new NewContractRequestController();

            ClientServiceContract clientServiceContract = new ClientServiceContract(startDate, endDate, newContractRequest.ServiceContract);

            clientController.Add(
                clientServiceContract,
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
