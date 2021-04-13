using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public abstract class NewClientRequest : Request
    {

        public NewClientRequest(int id, DateTime dateCreated, DateTime dateResolved) : base(id, dateCreated, dateResolved) {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
