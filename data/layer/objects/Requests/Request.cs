using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class Request
    {
        //Fields
        private int _id;
        private DateTime _dateCreated;
        private DateTime _dateResolved;
        private string _status;
        private CallLog _call;
        private string _contactNum;
        private Client _client;
        private List<Agent> _handler = new List<Agent>();

        //Properties
        public DateTime dateCreated { get => _dateCreated; set => _dateCreated = value; }
        public DateTime dateResolved { get => _dateResolved; set => _dateResolved = value; }
        public string status { get => _status; set => _status = value; }
        public CallLog call { get => _call; set => _call = value; }
        public string contactNum { get => _contactNum; set => _contactNum = value; }
        public Client client { get => _client; set => _client = value; }
        public List<Agent> handler { get => _handler; set => _handler = value; }
        public int id { get => _id; set => _id = value; }

        //Constrcuctor
        protected Request(DateTime dateCreated, DateTime dateResolved, CallLog call)
        {
            this.dateCreated = dateCreated;
            this.dateResolved = dateResolved;
            this.call = call;
        }

        //Standard methods in a class
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else 
            {
                Request p = (Request)obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //Shedule
        public abstract void Schedule();
        //Ruben De Beer
    }
}
