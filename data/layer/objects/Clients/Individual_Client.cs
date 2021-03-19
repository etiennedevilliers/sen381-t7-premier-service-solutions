using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    public class Individual_Client : Client
    {
        //Fields
        private string name;
        private string surname;

        //Properties
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Individual_Client(List<Service_Contract> agreement, string address, string primary_contact_cell_number, string Name, string Surname)
                                : base(agreement, address, primary_contact_cell_number) {
            surname = Surname;
            name = Name;
            
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Individual_Client p = (Individual_Client)obj;
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
