using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public abstract class Sales_Request : Request
    {
        public List<Service_Contract> serviceContracts;

        public Sales_Request(DateTime dtCreated, DateTime dtResolved, List<Service_Contract> serviceContracts) : base(dtCreated, dtResolved) {
            this.serviceContracts = serviceContracts;
        }

    }
}
