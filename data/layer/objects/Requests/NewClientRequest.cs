using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class NewClientRequest : Request
    {
        private Client client;

        public NewClientRequest(int id, DateTime dateCreated, DateTime dateResolved, Client client) : base(id, dateCreated, dateResolved) {
            this.client = client;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
