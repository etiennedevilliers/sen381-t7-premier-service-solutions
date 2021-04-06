using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class ServiceContract
    {
        //Fields
        private int ID;
        private string description;
        private List<Package> packages;
        private double cost;
        private DateTime dateFinalised;
        private DateTime dateTerminated; 
        private string status;

         
        //Custom Constructor
        public ServiceContract(int ID, string sc_description, double cost, DateTime DateFinalised, DateTime DateTerminated, string Status, List<Package> Packages)
        {
            this.ID = ID;
            this.description = sc_description;
            this.cost = cost;
            this.dateFinalised = DateFinalised;
            this.dateTerminated = DateTerminated;
            this.status = Status;
            this.packages = Packages;
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceContract p = (ServiceContract)obj;
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
        //Ruben De Beer
    }
}
