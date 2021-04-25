using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{      
    
    public class ServiceRequest : Request
    {
        //Fields
        private string description;
        private DateTime jobStarted;

        //Properties
        public ServiceContract ServiceContract
        {
            get
            {
                return new ServiceRequestController().ReadChild(this);
            }
        }
        public string Description { get => description; set => description = value; }
        public DateTime JobStarted { get => jobStarted; set => jobStarted = value; }

        //Constructor
        public ServiceRequest(DateTime dateCreated, DateTime? dateResolved, CallLog call, string description, DateTime jobStarted) : base(dateCreated, dateResolved, call)
        {
            this.description = description;
            this.jobStarted = jobStarted;
        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("ServiceRequest({0}, {1}, {2}, {3}, JobStarted={4}, contract={5} ...)", DateCreated, DateResolved, Call, description, jobStarted, ServiceContract);
        }
    }
}