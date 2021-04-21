using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class CallLog
    {
        //Fields
        private int id;
        private DateTime  timeStarted;
        private DateTime  timeEnded;
        private Agent representative;
        private bool incoming;

        //Properties
        public int Id { get => id; set => id = value; }
        public DateTime TimeStarted { get => timeStarted; set => timeStarted = value; }
        public DateTime TimeEnded { get => timeEnded; set => timeEnded = value; }
        public Agent Representative { get => representative; set => representative = value; }
        public bool Incoming { get => incoming; set => incoming = value; }        

        //Constructors
        public CallLog(DateTime timeStarted, DateTime timeEnded, bool incoming)
        {
            this.timeStarted = timeStarted;
            this.timeEnded = timeEnded;
            this.incoming = incoming;
        }

        //Standard Classes
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                CallLog p = (CallLog)obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("CallLog({0}, {1}, {2}, {3}, {4})", id, timeStarted, timeEnded, representative, incoming);
        }
    }
}
 