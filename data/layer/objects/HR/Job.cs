using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Job
    {
        public Service_Request serviceRequest;

        public Client client;

        public Technician technician;
        public DateTime dtStarted;
        public DateTime dtEnded;
        

        public Job (Technician technician, DateTime dtStarted, DateTime dtEnded, Client client, Service_Request serviceRequest) {
            this.technician = technician;
            this.dtStarted = dtStarted;
            this.dtEnded = dtEnded;
            this.client = client;
            this.serviceRequest = serviceRequest;
        }  

    }
}