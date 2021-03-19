using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    class Service
    {
        //Fields
        private int ID;
        private string service_description;
        private DateTime duration;

        //Properties 
        public string Service_description { get => service_description; set => service_description = value; }
        public DateTime Duration { get => duration; set => duration = value; }

        //Custom Contructor
        public Service(string service_description, DateTime duration)
        {
            this.Service_description = service_description;
            this.Duration = duration;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Service p = (Service)obj;
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
