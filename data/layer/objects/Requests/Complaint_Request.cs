using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
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
