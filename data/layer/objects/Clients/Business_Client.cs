using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Business_Client : Client
    {
        //Fields
        private string business_name;

        //Properties
        public string Business_name { get => business_name; set => business_name = value; }

        public Business_Client(List<Service_Contract> agreement, string address, string primary_contact_cell_number, string Business_name) 
                        : base(agreement, address, primary_contact_cell_number)
        {
            business_name = Business_name;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Business_Client p = (Business_Client)obj;
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
