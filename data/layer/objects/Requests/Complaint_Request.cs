using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects
{
    
    public class Complaint_Request : Request
    {
        // public Service_Contract serviceContract;
        public String complaintDescription;
        public Complaint_Request(DateTime dtCreated, DateTime dtResolved, String desc) : base(dtCreated, dtResolved) {
            this.complaintDescription = desc;
        }

    }
}
