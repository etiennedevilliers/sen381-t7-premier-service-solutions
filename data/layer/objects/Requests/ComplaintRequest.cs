using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class ComplaintRequest : Request
    {
        //Fields
        private ServiceContract serviceContract;
        private string description;

        //Properties 
        public ServiceContract ServiceContract { get => serviceContract; set => serviceContract = value; }
        public string Description { get => description; set => description = value; }

        //Constructor
        public ComplaintRequest(DateTime dateCreated, DateTime? dateResolved, CallLog call, string description) : base(dateCreated, dateResolved, call)
        {
            this.description = description;
        }

        //Standard Methods
        public override string ToString()
        {
            return string.Format("ComplaintRequest({0}, {1}, {2}, {3}, ...)", DateCreated, DateResolved, Call, description);
        }
    }
}