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

        public Technician(int Id, string name, string primaryContact, string empStatus, string empType, List<Service> skills)
            : base(Id, name, primaryContact, empStatus, empType)
        {
            this.skills = skills;
            this.id = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}