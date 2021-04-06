using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class NewClientRequest : Request
    {
        private Client client;
        private int _id;

        public NewClientRequest(int _id, DateTime _dateCreated, DateTime _dateResolved, Client client) : base(_id, _dateCreated, _dateResolved) {
            this.client = client;
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
                NewClientRequest p = (NewClientRequest)obj;
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
