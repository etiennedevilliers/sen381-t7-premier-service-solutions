using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects
{
    
    public class Service_Request : Request
    {
        // public Service_Contract serviceContract;
        public String serviceDescription;

        public List<Job> jobList;
        public Service_Request(DateTime dtCreated, DateTime dtResolved, String desc, List<Job> jobList) : base(dtCreated, dtResolved) {
            this.serviceDescription = desc;
            this.jobList = jobList;
        }

    }
}
