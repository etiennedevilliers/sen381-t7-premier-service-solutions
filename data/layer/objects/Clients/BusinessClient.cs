using System;
using System.Collections.Generic;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{
    public class BusinessClient : Client
    {
        //Fields
        private string name;

        //Properties
        public string Name { get => name; set => name = value; }
        public List<Employee> Employees
        {
            get
            {
                return new BusinessClientController().ReadChildren(this);
            }
        }

        //Constructor
        public BusinessClient(string contactNum, string name) : base(contactNum)
        {
            this.name = name;
        }
 
        //Standard Methods
        public override string ToString()
        {
            return string.Format("BusinessClient({0}, {1}, {2})", id, name, contactNum);
        }
    }
}
