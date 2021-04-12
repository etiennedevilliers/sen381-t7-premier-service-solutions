using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class ServiceLevelAgreement
    {
        //Fields
        public int id;
        public string description;
 
        //Custom COnstructor
        public ServiceLevelAgreement(int ID, string description)
        {
            this.id = ID;
            this.description = description;
        }
          
        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceLevelAgreement p = (ServiceLevelAgreement)obj;
                return p.id.Equals(this.id);
            }

        }

        public override int GetHashCode()
        {
            return this.id;
        } 

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
