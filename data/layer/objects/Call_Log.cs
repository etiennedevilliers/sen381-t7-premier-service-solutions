using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Call_Log
    {
        public DateTime dtCallStarted;
        public DateTime dtCallEnded;
        public bool incoming;
        public Agent reperasentative;
        public int ID;

        public Call_Log(int ID, DateTime dtCallStarted, DateTime dtCallEnded, Agent reperasentative, bool incoming) {
            this.dtCallStarted   = dtCallStarted;
            this.dtCallEnded     = dtCallEnded;
            this.reperasentative = reperasentative;
            this.ID = ID;
            this.incoming = incoming;
        }
    }
}
