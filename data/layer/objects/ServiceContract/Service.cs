﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Service
    {
        //Fields
        private int ID;
        private string description;
        private DateTime duration;


        //Custom Contructor
        public Service(int ID, string service_description, DateTime duration)
        {
            this.ID = ID;
            this.description = service_description;
            this.duration = duration;
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
                return p.ID.Equals(this.ID);
            }
        }

        public override int GetHashCode()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
