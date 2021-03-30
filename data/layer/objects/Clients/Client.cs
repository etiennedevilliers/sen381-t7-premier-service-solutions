using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public abstract class Client
    {

        public List<Service_Contract> agreement;
        public string address;
        public string contactNum;

        public int ID { get; }

        public Client(int ID, List<Service_Contract> agreement, string address, string contactNum)
        {
            this.ID = ID;
            this.agreement  = agreement;
            this.address    = address;
            this.contactNum = contactNum;
        }
    }
}
