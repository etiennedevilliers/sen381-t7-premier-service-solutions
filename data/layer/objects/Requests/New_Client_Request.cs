using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public abstract class New_Client_Request : Request
    {
        public Client client;

        public New_Client_Request(int ID, DateTime dtCreated, DateTime dtResolved, Client client) : base(ID, dtCreated, dtResolved) {
            this.client = client;
        }

    }
}
