using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Package
    {
        //Fields 
        private int ID;
        private List<Service> services;
        private string name;
        private string decription;



        //Custom Constructor 
        public Package(int ID , string Name,string Description, List<Service> Services)
        {
            this.ID = ID;
            this.services = Services;
            this.name = Name;
            this.decription = Description;
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Package p = (Package)obj;
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
