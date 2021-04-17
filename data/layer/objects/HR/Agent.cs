using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Layer.Objects
{
    public class Agent 
    {
        private int _id;
        private string _name;
        private string _contactNum;
        private string _employmentStatus;
        private string _employeeType;

        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string contactNum { get => _contactNum; set => _contactNum = value; }
        public string employmentStatus { get => _employmentStatus; set => _employmentStatus = value; }
        public string employeeType { get => _employeeType; set => _employeeType = value; }

        public Agent(int id, string name, string contactNum, string employmentStatus, string employeeType)
        {
            this.id = id;
            this.name = name;
            this.contactNum = contactNum;
            this.employmentStatus = employmentStatus;
            this.employeeType = employeeType;
        }

        public Agent(string name, string contactNum, string employmentStatus, string employeeType)
        {
            this.name = name;
            this.contactNum = contactNum;
            this.employmentStatus = employmentStatus;
            this.employeeType = employeeType;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Agent p = (Agent) obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this._id;
        }

        public override string ToString()
        {
            return String.Format("Agent({0}, {1}, {2}, {3})", name, contactNum, employeeType, employmentStatus);
        }
        //Ruben De Beer
    }
}