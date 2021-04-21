using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class EmployeeController : IRead<Employee>, ICreate<Employee>, IUpdate<Employee>, IDelete<Employee>
    {
        BusinessClient bus;

        public EmployeeController(BusinessClient bus)
        {
            this.bus = bus;
        }

        //Basic CRUD
        public int Create(Employee obj)
        {
            DataHandler dh = new DataHandler();

            obj.Id = dh.InsertID(string.Format(
                    "INSERT INTO Employee(name, surname, role, contactNum, BusinessClientID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    obj.Name, obj.Surname, obj.Role, obj.ContactNum, bus.Id));

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(Employee obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Employee", "EmployeeID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<Employee> Read()
        {
            DataHandler dh = new DataHandler();

            List<Employee> empList = new List<Employee>();
            SqlDataReader read = dh.Select("SELECT EmployeeID, name, surname, role, contactNum FROM Employee WHERE BusinessClientID = " + bus.Id.ToString());
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

                    newEmp.Id = read.GetInt32(0);

                    empList.Add(newEmp);
                }
            }

            dh.Dispose();

            return empList;
        }

        public void Update(Employee obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Employee SET name = '{0}', surname = '{1}', role = '{2}', contactNum = '{3}' WHERE EmployeeID = {4}", 
                obj.Name, obj.Surname, obj.Role, obj.ContactNum, obj.Id));

            dh.Dispose();
        }
    }
}
