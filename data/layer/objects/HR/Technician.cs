using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    //Need Help  
    public class Technician : Agent
    {
        //Fields

        //Properties
        public List<Service> Skills
        {
            get
            {
                return new TechnicianController().ReadChildren(this);
            }
        }

        //Constructor
        public Technician( string name, string primaryContact, string empStatus, string empType) : base(name, primaryContact, empStatus, empType)
        {
            
        }

        //Standard Methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}