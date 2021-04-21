using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class Agent 
    {
        //Fields
        private int id;
        private string name;
        private string contactNum;
        private string employmentStatus;
        private string employeeType;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public string EmploymentStatus { get => employmentStatus; set => employmentStatus = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }

        //Constructor
        public Agent(string name, string contactNum, string employmentStatus, string employeeType)
        {
            this.name = name;
            this.contactNum = contactNum;
            this.employmentStatus = employmentStatus;
            this.employeeType = employeeType;
        }

        //Standard Classes
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Agent p = (Agent) obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("Agent({0}, {1}, {2}, {3})", name, contactNum, employeeType, employmentStatus);
        }
    }
}