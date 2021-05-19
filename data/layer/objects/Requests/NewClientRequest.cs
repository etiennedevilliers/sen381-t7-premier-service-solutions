using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    
    public class NewClientRequest : Request
    {
        private bool individual;

        public bool Individual { get => individual; set => individual = value; }

        //Constructor
        public NewClientRequest(bool individual, DateTime dateCreated, DateTime? dateResolved, CallLog call) : base(dateCreated, dateResolved, call)
        {
            this.individual = individual;
        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("NewClientRequest({0}, {1}, {2}, ...)", DateCreated, DateResolved, Call);
        }
    }
}
