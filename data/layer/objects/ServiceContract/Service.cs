using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{ 
    public class Service
    {
        //Fields
        private int _id;
        private int _expectedDuration;
        private string _description;

        //Properties
        public int id { get => _id; set => _id = value; }
        public string description { get => _description; set => _description = value; }
        public int  expectedDuration { get => _expectedDuration; set => _expectedDuration = value; }

        //Custom Contructor
        public Service( int duration, string Description)
        {
         
            this.expectedDuration = duration;
            this.description = Description;
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
