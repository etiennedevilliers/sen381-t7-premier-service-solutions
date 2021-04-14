using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;


namespace Data.Layer.Objects
{
    public class ServiceContract
    {
        //Fields
        private int _ID;
        private string _description;
        private List<Package> _packages;
        private double _cost;
        private DateTime _dateFinalised;
        private DateTime _dateTerminated; 
        private string _status;

        public int Id { get => _ID; set => _ID = value; }
        public string Description { get => _description; set =>_description = value; }
        public List<Package> Packages { get => _packages; set => _packages = value; }
        public double Cost { get => _cost; set => _cost = value; }
        public DateTime DateFinalised { get => _dateFinalised; set => _dateFinalised = value; }
        public DateTime DateTerminated { get => _dateTerminated; set => _dateTerminated = value; }
        public string Status { get => _status; set => _status = value; }


        //Custom Constructor
        public ServiceContract(int id, string description, List<Package> packages, double cost, DateTime dateFinalised, DateTime dateTerminated, string status)
        {
            Id = id;
            Description = description;
            Packages = packages;
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
                return p.id.Equals(this._ID);
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
        //Ruben De Beer
    }
}
