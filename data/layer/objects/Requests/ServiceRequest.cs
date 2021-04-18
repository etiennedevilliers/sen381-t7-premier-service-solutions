using System;
using System.Collections.Generic;
using System.Text;
using data.layer.controller;

namespace Data.Layer.Objects
{      
    
    public class ServiceRequest : Request
    {
        private string _description;
        private DateTime _jobStarted;

        public ServiceContract serviceContract { get {
            ServiceRequestController serviceRequestController = new ServiceRequestController();
            return serviceRequestController.ReadChild(this);
        } }
        public string description { get => _description; set => _description = value; }
        public DateTime jobStarted { get => _jobStarted; set => _jobStarted = value; }

        public ServiceRequest(DateTime dtCreated, DateTime dtResolved, CallLog call, string desc, DateTime Jobstarted)
                                                              : base(dtCreated, dtResolved, call) {
            description = desc;
            this.jobStarted = Jobstarted;
        }

        public override string ToString()
        {
            return String.Format("ServiceRequest({0}, {1}, {2}, {3}, JobStarted={4}, contract={5} ...)", dateCreated, dateResolved, call, description, jobStarted, serviceContract);
        }

        //Shedule
        public override void Schedule()
        {
            throw new NotImplementedException();
        } 
    }
}
              