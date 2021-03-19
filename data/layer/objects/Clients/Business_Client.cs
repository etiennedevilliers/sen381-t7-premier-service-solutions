using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    public class Business_Client : Client
    {
        //Fields
        private string business_name;
        private int ID;

        //Properties
        public string Business_name { get => business_name; set => business_name = value; }
        public int ID1 { get => ID; set => ID = value; }

        public override object client()
        {
            throw new NotImplementedException();
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
