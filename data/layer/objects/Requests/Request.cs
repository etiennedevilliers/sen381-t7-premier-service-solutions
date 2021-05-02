using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    
    public abstract class Request
    {
        //Fields
        private int id;
        private DateTime dateCreated;
        private string status;
        private CallLog call;
        private string contactNum;

        //Properties
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime? DateResolved;
        public string Status { get => status; set => status = value; }
        public CallLog Call { get => call; set => call = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public Client Client {
            get
            {
                return new RequestController().ReadChild(this);
            }
        }
        public List<RequestAgent> Handlers
        {
            get
            {
                return new RequestController().ReadChildren(this);
            }
        }
        public int Id { get => id; set => id = value; }

        //Constructor
        protected Request(DateTime dateCreated, DateTime? dateResolved, CallLog call)
        {
            this.dateCreated = dateCreated;
            this.DateResolved = dateResolved;
            this.call = call;

            this.Status = "Open";
        }

        //Standard Methods
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else 
            {
                Request p = (Request)obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
