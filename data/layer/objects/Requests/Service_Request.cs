using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Service_Request : Request
    {
        public Service_Contract serviceContract;
        public string serviceDescription;

        public List<Job> jobList;
        public Service_Request(DateTime dtCreated, DateTime dtResolved, string desc, List<Job> jobList, Service_Contract serviceContract) : base(dtCreated, dtResolved) {
            serviceDescription = desc;
            this.jobList = jobList;
            this.serviceContract = serviceContract;
        }

    }
}
