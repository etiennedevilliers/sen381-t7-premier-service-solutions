using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    
    public class NewContractRequest : Request
    {
        //Fields
        private ServiceContract serviceContract;

        //Properties
        public ServiceContract ServiceContract { get => serviceContract; set => serviceContract = value; }

        //Constructor
        public NewContractRequest(DateTime dtCreated, DateTime dtResolved, CallLog call) : base(dtCreated, dtResolved, call)
        {
            
        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("NewContractRequest({0}, {1}, {2}, ...)", DateCreated, DateResolved, Call);
        }
    }
}
  