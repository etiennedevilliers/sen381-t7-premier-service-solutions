using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects
{
    
    public abstract class New_Client_Request : Request
    {
        // public Client client

        public New_Client_Request(DateTime dtCreated, DateTime dtResolved) : base(dtCreated, dtResolved) {
            
        }

    }
}
