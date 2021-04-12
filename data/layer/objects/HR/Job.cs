using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class Job
    {
        public ServiceRequest serviceRequest;

        public Client client;

        public Technician technician;
        public DateTime dtStarted;
        public DateTime dtEnded;

        public int ID;
        

        public Job (int ID, Technician technician, DateTime dtStarted, DateTime dtEnded, Client client, ServiceRequest serviceRequest) {
            this.technician = technician;
            this.dtStarted = dtStarted;
            this.dtEnded = dtEnded;
            this.client = client;
            this.serviceRequest = serviceRequest;
            this.ID = ID;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Job p = (Job)obj;
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