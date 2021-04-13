using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class NewClientRequest : Request
    {

        public NewClientRequest(DateTime dateCreated, DateTime dateResolved, CallLog call) : base(dateCreated, dateResolved, call) {

        }

        public override void Schedule()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("NewClientRequest({0}, {1}, {2}, ...)", dateCreated, dateResolved, call);
        }

    }
}
