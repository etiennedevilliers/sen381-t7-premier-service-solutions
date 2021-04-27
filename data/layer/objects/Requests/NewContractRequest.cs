using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    
    public class NewContractRequest : Request
    {

        //Properties
        public ServiceContract ServiceContract { 
            get {
                NewContractRequestController newContractRequestController = new NewContractRequestController();

                return newContractRequestController.ReadChild(this);
            } 
        }

        //Constructor
        public NewContractRequest(DateTime dtCreated, DateTime? dtResolved, CallLog call) : base(dtCreated, dtResolved, call)
        {
            
        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("NewContractRequest({0}, {1}, {2}, ...)", DateCreated, DateResolved, Call);
        }
    }
}
  