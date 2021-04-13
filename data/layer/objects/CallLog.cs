using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class CallLog
    {
        //Fields
        private DateTime  _timeStarted;
        private DateTime  _timeEnded;
        private Agent _representative;
        private bool _incoming;
        private int _id;

        //Properties
        public DateTime timeStarted { get => _timeStarted; set => _timeStarted = value; }
        public DateTime timeEnded { get => _timeEnded; set => _timeEnded = value; }
        public Agent representative { get => _representative; set => _representative = value; }
        public bool incoming { get => _incoming; set => _incoming = value; }
        public int id { get => _id; }

        //Constrcutors
        public CallLog(DateTime timeStarted, DateTime timeEnded, bool incoming)
        {
            this.timeStarted = timeStarted;
            this.timeEnded = timeEnded;
            this.representative = representative;
            this.incoming = incoming;
        }

        public CallLog(int ID, DateTime timeStarted, DateTime timeEnded, bool incoming)
        {
            this.timeStarted = timeStarted;
            this.timeEnded = timeEnded;
            this.representative = representative;
            this.incoming = incoming;
            this._id = ID;
        }

        //Standard Classes
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                CallLog p = (CallLog)obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this._id;
        }

        public override string ToString()
        {
            return String.Format("CallLog({0}, {1}, {2}, {3}, {4})", id, timeStarted, timeEnded, representative, incoming);
        }
    }
}
 