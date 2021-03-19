using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    public class Package
    {
        //Fields 
        private int ID;
        private List<Service> services;
        private string package_name;
        private string package_decription;

        //Properties 
        public int ID1 { get => ID; set => ID = value; }
        public string Package_name { get => package_name; set => package_name = value; }
        public string Package_decription { get => package_decription; set => package_decription = value; }
        internal List<Service> Services { get => services; set => services = value; }

        //Custom Constructor 
        public Package(int ID , string Package_Name,string Package_Description, List<Service> Services1)
        {
            this.ID1 = ID;
            this.Services = Services1;
            this.Package_name = Package_Name;
            this.Package_decription = Package_Description;
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
