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

        public int id { get => id; set => id = value; }
        public string description { get => description; set => description = value; }

        //Custom COnstructor
        public ServiceLevelAgreement(int ID, string description)
        {
            this.id = ID; 
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
            return base.ToString();
        }
        //Ruben De Beer
    }
}