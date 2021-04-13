using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class EmployeeController : IRead<Employee>, ICreate<Employee>, IUpdate<Employee>, IDelete<Employee>
    {
        BusinessClient bus;

        public EmployeeController(BusinessClient bus)
        {
            this.bus = bus;
        }

        public int Create(Employee obj)
        {
            DataHandler dh = new DataHandler();

            obj.id = dh.InsertID(string.Format(
                    "INSERT INTO Employee(name, surname, role, contactNum, BusinessClientID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    obj.name, obj.surname, obj.role, obj.contactNum, bus.id));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(Employee obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Employee", "EmployeeID = " + obj.id.ToString());

            dh.Dispose();
        }

        public List<Employee> Read()
        {
            DataHandler dh = new DataHandler();

            List<Employee> empList = new List<Employee>();
            SqlDataReader read = dh.Select("SELECT EmployeeID, name, surname, role, contactNum FROM Employee WHERE BusinessClientID = " + bus.id.ToString());
            Employee newEmp;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newEmp = new Employee(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4)
                        );

                    newEmp.id = read.GetInt32(0);

                    empList.Add(newEmp);
                }
            }

            dh.Dispose();

            return empList;
        }

        public void Update(Employee obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Employee SET name = '{0}', surname = '{1}', role = '{2}', contactNum = '{3}' WHERE EmployeeID = {4}", obj.name, obj.surname, obj.role, obj.contactNum, obj.id));
            
            dh.Dispose();
        }
    }
}
