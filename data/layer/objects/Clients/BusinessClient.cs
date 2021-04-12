using System;
using System.Collections.Generic;
using System.Text;
using data.layer.controller;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        private string _businessName;
        public List<Employee> employees;

        //Properties
        public string businessName { get => _businessName; set => _businessName = value; }

        //Constructor
        public BusinessClient(string contactNum, string businessName) 
                        : base(contactNum)
        {
            this.businessName = businessName;
        }

        public void AddEmployee(Employee emp){
            EmployeeController empContr = new EmployeeController(this);
            empContr.Create(emp);
        }

        public List<Employee> GetEmployees()
        {
            EmployeeController empContr = new EmployeeController(this);
            return empContr.Read();
        }
 
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BusinessClient p = (BusinessClient)obj;
                return p.id.Equals(this._id);
            }
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return string.Format("BusinessClient({0}, {1}, {2})", id, businessName, contactNum);
        }
        //Ruben De Beer
    }
}
