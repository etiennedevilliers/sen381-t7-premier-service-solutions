using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Complaint_Request : Request
    {
        public Service_Contract serviceContract;

        public String complaintDescription;
        public Complaint_Request(int ID, DateTime dtCreated, DateTime dtResolved, String desc) : base(ID, dtCreated, dtResolved) {
            this.complaintDescription = desc;
        }

    }
}
