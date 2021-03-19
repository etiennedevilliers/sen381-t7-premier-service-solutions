using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Call_Log
    {
        public DateTime dtCallStarted;
        public DateTime dtCallEnded;

        public Boolean incoming;

        // public Agent reperasentative;

        public Call_Log(DateTime dtCallStarted, DateTime dtCallEnded) {
            this.dtCallStarted = dtCallStarted;
            this.dtCallEnded   = dtCallEnded;
        }
    }
}
