using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class IndividualClient : Client
    {
        //Fields
        public string name;
        public string surname;

        public IndividualClient(int ID, List<Service_Contract> agreement, string address, string contactName, string name, string surname)
                                : base(ID, agreement, address, contactName) {
            this.surname = name;
            this.name = surname;
            
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                IndividualClient p = (IndividualClient)obj;
                return p.ID.Equals(this.ID);
            }
        }

        public override int GetHashCode()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
