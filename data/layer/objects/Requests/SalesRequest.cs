using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class SalesRequest : Request
    {
        public List<ServiceContract> serviceContracts;

        public SalesRequest(int ID, DateTime dtCreated, DateTime dtResolved, List<ServiceContract> serviceContracts) 
                                                                                     : base(ID, dtCreated, dtResolved) {
            this.serviceContracts = serviceContracts;
        }
        //Ruben De Beer

    }
}
  