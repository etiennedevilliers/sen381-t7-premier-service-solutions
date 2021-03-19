using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public abstract class Request
    {
        public enum RequestStatus {
            unresolved,
            resolved
        }

        public DateTime dtCreated;
        public DateTime dtResolved;

        public RequestStatus status;

        public int ID;

        public Request(int ID, DateTime dtCreated, DateTime dtResolved) {
            this.dtCreated = dtCreated;
            this.dtResolved = dtResolved;
            this.status = RequestStatus.unresolved;
            this.ID = ID;
        }

    }
}
