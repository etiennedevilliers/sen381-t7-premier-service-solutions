using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects.Clients
{
    class Employee
    {

        private string _name;
        private string _surname;
        private string _role;
        private string _contactNum;
        private int _id;

        public string name { get => _name; set => _name = value; }
        public string surname { get => _surname; set => _surname = value; }
        public string role { get => _role; set => _role = value; }
        public string contactNum { get => _contactNum; set => _contactNum = value; }
        public int id { get => _id; set => _id = value; }

        public Employee(string name, string surname, string role, string contactNum, int id)
        {
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.contactNum = contactNum;
            this.id = id;      
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Employee p = (Employee)obj;
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
