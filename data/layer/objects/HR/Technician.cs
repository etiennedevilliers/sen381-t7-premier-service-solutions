using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    //Need Help  
    public class Technician : Agent
    {
        private  List<Service> _skills;
        private int _id;

        public List<Service> skills { get => _skills; set => _skills = value; }
        public int id { get => _id; set => _id = value; }

        public Technician (int Id, String name, String surname, String primaryContact, employmentStatus empstatus, List<Service> skills) 
            : base(Id, name, surname, primaryContact, empstatus, skills) {
            this.skills = skills;
            this.id = id;
        }

        

        public override string ToString()
        {
            return base.ToString();
        }     
}