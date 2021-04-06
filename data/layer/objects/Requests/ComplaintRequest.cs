using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    
    public class ComplaintRequest : Request
    {
        //Fields
        private ServiceContract _serviceContract;
        private int _id;
        private string _description;

        //Properties 
        public ServiceContract serviceContract { get => _serviceContract; set => _serviceContract = value; }
        public int id { get => _id; set => _id = value; }
        public string description { get => _description; set => _description = value; }



        public ComplaintRequest(int ID, DateTime dtCreated, DateTime dtResolved, String desc) : base(ID, dtCreated, dtResolved) {
            this.description = desc;
        }

        public override void Schedule()    
        {
            throw new NotImplementedException();
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
                ComplaintRequest p = (ComplaintRequest)obj;
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
        //Ruben De Beer


    }
}
