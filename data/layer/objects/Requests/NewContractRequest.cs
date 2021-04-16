using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class NewContractRequest : Request
    {
        public ServiceContract serviceContracts;

        public NewContractRequest(DateTime dtCreated, DateTime dtResolved, CallLog call) 
                                                        : base(dtCreated, dtResolved, call) {
            
        }

        public override void Schedule() {

        }

        public override string ToString() {
            return String.Format("NewContractRequest({0}, {1}, {2}, ...)", dateCreated, dateResolved, call);
        }
    }
}
  