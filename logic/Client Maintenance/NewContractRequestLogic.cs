using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic.ClientMaintenance
{
    public class NewContractRequestLogic
    {
        public class DateValidationResponse
        {
            public bool valid;
            public string reason;

            public DateValidationResponse(bool valid, string reason)
            {
                this.valid = valid;
                this.reason = reason;
            }
        }

        public DateValidationResponse checkDateTime(NewContractRequest newContractRequest, DateTime startDate, DateTime endDate)
        {
            ServiceContract serviceContract = newContractRequest.ServiceContract;
            ClientController clientController = new ClientController();

            if (startDate < serviceContract.DateFinalised)
                return new DateValidationResponse(false, string.Format("This Service Contract is only valid from after {0}", serviceContract.DateFinalised));
            if (endDate > serviceContract.DateTerminated)
                return new DateValidationResponse(false, string.Format("This Service Contract is only valid until {0}", serviceContract.DateTerminated));

            foreach (ClientServiceContract clientSC in clientController.serviceContract.ReadChildren(newContractRequest.Client))
            {
                //bool overlap = a.start < b.end && b.start < a.end;
                bool overlap = startDate < clientSC.EndDate && clientSC.StartDate < endDate;
                if (overlap)
                    return new DateValidationResponse(
                        false,
                        string.Format(
                            "This service overlaps with a assigned ServiceContract: {0}",
                            clientSC
                        )
                    );
            }

            if (endDate < startDate) 
                return new DateValidationResponse(false, "End date cannot be before start date");

            return new DateValidationResponse(true, "");
        }
    }
}
