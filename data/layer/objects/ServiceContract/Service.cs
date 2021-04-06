using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{ 
    public class Service
    {
        //Fields
        private int _id;
        private DateTime _expectedDuration;

        //Properties
        public int id { get => _id; set => _id = value; }
        public DateTime expectedDuration { get => _expectedDuration; set => _expectedDuration = value; }

        //Custom Contructor
        public Service(int ID, DateTime duration)
        {
            this.id = ID;
            this.expectedDuration = duration;
        }
     

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }    
            else
            {
                Service p = (Service)obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode() 
        {
            return this.id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        //Ruben De Beer
    }
}
