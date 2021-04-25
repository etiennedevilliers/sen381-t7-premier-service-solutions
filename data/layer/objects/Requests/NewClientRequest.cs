using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    
    public class NewClientRequest : Request
    {
        //Fields

        //Properties

        //Constructor
        public NewClientRequest(DateTime dateCreated, DateTime? dateResolved, CallLog call) : base(dateCreated, dateResolved, call)
        {

        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("NewClientRequest({0}, {1}, {2}, ...)", DateCreated, DateResolved, Call);
        }
    }
}
