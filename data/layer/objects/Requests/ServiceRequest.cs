using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{      
    
    public class ServiceRequest : Request
    {
        private ServiceContract _serviceContract;
        private string _description;
        private DateTime _jobStarted;
        private int _id;

        public ServiceContract serviceContract { get => _serviceContract; set => _serviceContract = value; }
        public string description { get => _description; set => _description = value; }
        public DateTime jobStarted { get => _jobStarted; set => _jobStarted = value; }
        public int id { get => _id; set => _id = value; }  

        public ServiceRequest(int ID, DateTime dtCreated, DateTime dtResolved, string desc, DateTime Jobstarted, ServiceContract serviceContract) 
                                                              : base(ID, dtCreated, dtResolved) {
            description = desc;
            this.jobStarted = Jobstarted;
            this.serviceContract = serviceContract;
            this.id = ID;
        }

        //Standard methods in a class
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceRequest p = (ServiceRequest)obj;
                return p.id.Equals(this._id);
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

        //Shedule
        public override void Schedule()
        {
            throw new NotImplementedException();
        } 
        //Ruben De Beer
    }
}
              