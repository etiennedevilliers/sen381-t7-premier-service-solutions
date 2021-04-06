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
        public int id { get => _id; set => _id = value; }

        //Constrcutor
        public CallLog(DateTime timeStarted, DateTime timeEnded, Agent representative, bool incoming, int Id)
        {
            this.timeStarted = timeStarted;
            this.timeEnded = timeEnded;
            this.representative = representative;
            this.incoming = incoming;
            this.id = Id;
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
            return base.ToString();
        }











    }
}
 