using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public abstract class Client
    {

        public List<Service_Contract> agreement;
        public string address;
        public string primary_contact_cell_number;

        public int ID { get; }

        public Client(List<Service_Contract> agreement, string address, string primary_contact_cell_number)
        {
            this.agreement                   = agreement;
            this.address                     = address;
            this.primary_contact_cell_number = primary_contact_cell_number;
        }
    }
}
