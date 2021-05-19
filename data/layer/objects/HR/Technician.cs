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
        public Technician( string name, string surname, string primaryContact, string empStatus, string empType, string username, string password) : base(name, surname, primaryContact, empStatus, empType, username, password)
        {
            
        }

        //Standard Methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}