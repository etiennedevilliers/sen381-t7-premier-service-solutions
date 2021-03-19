using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public abstract class Sales_Request : Request
    {
        // public List<Service_Contract> serviceContract;

        public Sales_Request(DateTime dtCreated, DateTime dtResolved) : base(dtCreated, dtResolved) {
            
        }

    }
}
