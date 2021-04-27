using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public class ServiceContract
    {
        //Fields
        private int id;
        private string description;
        private double cost;
        private DateTime dateFinalised;
        private DateTime dateTerminated; 
        private string status;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public List<Package> Packages
        {
            get
            {
                return new ServiceContractController().ReadChildren(this);
            }
        }
        public double Cost { get => cost; set => cost = value; }
        public DateTime DateFinalised { get => dateFinalised; set => dateFinalised = value; }
        public DateTime DateTerminated { get => dateTerminated; set => dateTerminated = value; }
        public string Status { get => status; set => status = value; }
        public string identifier;

        //Constructor
        public ServiceContract(string description, double cost, DateTime dateFinalised, DateTime dateTerminated, string status,string identifier)
        {
            this.description = description;
            this.cost = cost;
            this.dateFinalised = dateFinalised;
            this.dateTerminated = dateTerminated;
            this.status = status;
            this.identifier = identifier;
        }

        //Standard Methods
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceContract p = (ServiceContract) obj;
                return p.Id.Equals(id);
            }

        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("ServiceContract({0}, {1}, {2}, Packages count: {3}, {4}, {5})", identifier, description, cost, Packages.Count, dateFinalised, dateTerminated);
        }
    }
}