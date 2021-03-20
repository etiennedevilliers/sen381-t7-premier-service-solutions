using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Service_Contract
    {
        //Fields
        private int ID;
        private string sc_description;
        private List<Tuple<Package, Service_Level_Agreement>> service_list;
        private double cost;
        private DateTime date_valid_start;
        private DateTime date_valid_end; 
        private string indended_for;

        //Properties
        public int ID1 { get => ID; }
        public string Sc_description { get => sc_description; set => sc_description = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime Date_valid_start { get => date_valid_start; set => date_valid_start = value; }
        public DateTime Date_valid_end { get => date_valid_end; set => date_valid_end = value; }
        public string Indended_for { get => indended_for; set => indended_for = value; }
        internal List<Tuple<Package, Service_Level_Agreement>> Service_list { get => service_list; set => service_list = value; }
         
        //Custom Constructor
        public Service_Contract(int ID, string sc_description, double cost, DateTime date_valid_start, DateTime date_valid_end, string indended_for, List<Tuple<Package, Service_Level_Agreement>> service_list)
        {
            this.ID = ID;
            Sc_description = sc_description;
            Cost = cost;
            Date_valid_start = date_valid_start;
            Date_valid_end = date_valid_end;
            Indended_for = indended_for;
            Service_list = service_list;
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Service_Contract p = (Service_Contract)obj;
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
