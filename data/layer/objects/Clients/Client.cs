using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    public abstract class Client
    {
        protected List<Service_Contract> agreement;
        protected string address;
        protected string primary_contact_cell_number;

        public abstract object client();
            
    }
}
