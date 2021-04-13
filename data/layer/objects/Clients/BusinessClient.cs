using System;
using System.Collections.Generic;
using System.Text;
using data.layer.controller;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        private string _name;

        //Properties
        public string name { get => _name; set => _name = value; }
        public List<Employee> employees
        {
            get
            {
                EmployeeController emp = new EmployeeController(this);
                return emp.Read();
            }
        }

        //Constructor
        public BusinessClient(string contactNum, string name)
                        : base(contactNum)
        {
            this.name = name;
        }

        //Employee Methods
        public void AddEmployee(Employee emp){
            EmployeeController empContr = new EmployeeController(this);
            empContr.Create(emp);
        }
 
        //Standard Methods
        public override string ToString()
        {
            return string.Format("BusinessClient({0}, {1}, {2})", id, name, contactNum);
        }
    }
}
