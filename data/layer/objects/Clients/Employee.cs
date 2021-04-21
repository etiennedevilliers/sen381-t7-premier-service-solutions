using System;
using System.Collections.Generic;

namespace Data.Layer.Objects
{
    public class Employee
    {
        //Fields
        private int id;
        private string name;
        private string surname;
        private string role;
        private string contactNum;

        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Role { get => role; set => role = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }

        //Constructor
        public Employee(string name, string surname, string role, string contactNum)
        {
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.contactNum = contactNum;
        }

        //Standard Methods
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Employee p = (Employee)obj;
                return p.Id.Equals(id);
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return string.Format("Employee({0}, {1}, {2}, {3})", id, name, surname, contactNum);
        }
    }
}
