using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class SalesRequest : Request
    {
        public List<ServiceContract> serviceContracts;

        public SalesRequest(DateTime dtCreated, DateTime dtResolved, CallLog call, List<ServiceContract> serviceContracts) 
                                                                                     : base(dtCreated, dtResolved, call) {
            this.serviceContracts = serviceContracts;
        }
        //Ruben De Beer

    }
}
  