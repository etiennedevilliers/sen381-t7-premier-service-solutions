using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;
using data.layer.controller;

namespace Data.Layer.Objects
{
    public class ServiceContract
    {
        //Fields
        public int id;
        private string _description;
        private double _cost;
        private DateTime _dateFinalised;
        private DateTime _dateTerminated; 
        private string _status;

        public string Description { get => _description; set =>_description = value; }
        public List<Package> Packages { 
            get {
                ServiceContractController serviceContractController = new ServiceContractController();
                return serviceContractController.ReadChildren(this);
            }
        }
        public double Cost { get => _cost; set => _cost = value; }
        public DateTime DateFinalised { get => _dateFinalised; set => _dateFinalised = value; }
        public DateTime DateTerminated { get => _dateTerminated; set => _dateTerminated = value; }
        public string Status { get => _status; set => _status = value; }


        //Custom Constructor
        public ServiceContract(string description,double cost, DateTime dateFinalised, DateTime dateTerminated, string status)
        {    
            Description = description;
            Cost = cost;
            DateFinalised = dateFinalised;
            DateTerminated = dateTerminated;
            Status = status;
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
                return p.id.Equals(this.id);
            }

        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return String.Format("ServiceContract({0}, {1}, {2}, Packages count: {3}, {4}, {5})", id, Description, Cost, Packages.Count, DateFinalised, DateTerminated);
        }
        //Ruben De Beer
    }
}
