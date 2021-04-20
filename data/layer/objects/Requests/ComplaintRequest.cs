using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class ComplaintRequest : Request
    {
        //Fields
        private ServiceContract _serviceContract;
        private string _description;

        //Properties 
        public ServiceContract serviceContract { get => _serviceContract; set => _serviceContract = value; }
        public string description { get => _description; set => _description = value; }



        public ComplaintRequest(DateTime dtCreated, DateTime dtResolved, CallLog call, String desc) : base(dtCreated, dtResolved, call) {
            this.description = desc;
        }

        public override void Schedule()    
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("ComplaintRequest({0}, {1}, {2}, {3}, ...)", dateCreated, dateResolved, call, description);
        }
    }
}
