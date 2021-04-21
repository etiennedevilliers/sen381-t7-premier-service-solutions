using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    //Need Help  
    public class Technician : Agent
    {
        private List<Service> _skills;

        public List<Service> skills { get => _skills; set => _skills = value; }

        public Technician( string name, string primaryContact, string empStatus, string empType)
            : base(name, primaryContact, empStatus, empType)
        {
            this.skills = skills;
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}