using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        public string businessName;

        public BusinessClient(int ID, List<Service_Contract> agreement, string address, string contactNum, string businessName) 
                        : base(ID, agreement, address, contactNum)
        {
            this.businessName = businessName;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BusinessClient p = (BusinessClient)obj;
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
