using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class Service_Request : Request
    {
        public Service_Contract serviceContract;
        public string serviceDescription;

        public List<Job> jobList;
        public Service_Request(int ID, DateTime dtCreated, DateTime dtResolved, string desc, List<Job> jobList, Service_Contract serviceContract) 
                                                              : base(ID, dtCreated, dtResolved) {
            serviceDescription = desc;
            this.jobList = jobList;
            this.serviceContract = serviceContract;
        }

    }
}
