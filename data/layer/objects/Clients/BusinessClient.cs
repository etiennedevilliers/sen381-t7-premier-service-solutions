using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        private string name;
        private List<Employee> employees;

        //Properties
        public string Name { get => name; set => name = value; }
        public List<Employee> Employees
        {
            get
            {
                if (employees == null)
                {
                    employees = new BusinessClientController().ReadChildren(this);
                    return employees;
                }
                else
                {
                    return employees;
                }
            }

            set => employees = value;
        }

        //Constructor
        public BusinessClient(string name, string contactNum, string clientIdentifier) : base(contactNum, clientIdentifier)
        {
            this.name = name;
        }
 
        //Standard Methods
        public override string ToString()
        {
            return string.Format("BusinessClient({0}, {1}, {2})", ClientIdentifier, name, contactNum);
        }
    }
}
