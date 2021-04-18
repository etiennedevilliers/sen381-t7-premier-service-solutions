﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class ServiceLevelAgreement
    {
        //Fields
        private int _id;
        private string _description;

        public int id { get => _id; set => _id = value; }
        public string description { get => _description; set => _description = value; }

        //Custom COnstructor
        public ServiceLevelAgreement( string description)
        {
      
            this.description = description;
        }
          
        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServiceLevelAgreement p = (ServiceLevelAgreement)obj;
                return p.id.Equals(this._id);
            }

        }

        public override int GetHashCode()
        {
            return this.id;
        } 

        public override string ToString()
        {
            return String.Format("ServiceLevelAgreement({0}, {1})", id, description);
        }
        //Ruben De Beer
    }
}
