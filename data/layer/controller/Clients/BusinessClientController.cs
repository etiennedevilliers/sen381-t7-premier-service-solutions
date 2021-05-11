using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class BusinessClientController : ICreate<BusinessClient>, IRead<BusinessClient>, IUpdate<BusinessClient>, IDelete<BusinessClient>, IChildren<Employee, BusinessClient>
    {
        //Basic CRUD
        public int Create(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            ClientController cl = new ClientController();
            obj.Id = cl.Create(obj);

            dh.Insert("INSERT INTO BusinessClient(BusinessClientID, name) VALUES (" + obj.Id + ", '" + obj.Name + "')");

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("BusinessClient", "BusinessClientID = " + obj.Id.ToString());
            ClientController cl = new ClientController();
            cl.Delete(obj);

            dh.Dispose();
        }

        public List<BusinessClient> Read()
        {
            DataHandler dh = new DataHandler();

            List<BusinessClient> busList = new List<BusinessClient>();
            SqlDataReader read = dh.Select(
                "SELECT BC.BusinessClientID, BC.name, C.contactNum, C.ClientIdentifier " +
                "FROM dbo.BusinessClient AS BC " +
                    "LEFT JOIN dbo.Client AS C ON C.ClientID = BC.BusinessClientID "
            );
            BusinessClient newCl;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newCl = new BusinessClient(
                            read.GetString(2),
                            read.GetString(1),
                            read.IsDBNull(3) ? null : read.GetString(3)
                        );

                    newCl.Id = read.GetInt32(0);

                    busList.Add(newCl);
                }
            }
            dh.Dispose();
            return busList;
        }

        public void Update(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.BusinessClient SET name = '{0}' WHERE BusinessClientID = {1}", obj.Name, obj.Id));
            ClientController cl = new ClientController();
            cl.Update(obj);

            dh.Dispose();
        }


        // IChildren interface
        public void Add(Employee child, BusinessClient parent)
        {
            DataHandler dh = new DataHandler();

            child.Id = dh.InsertID(string.Format(
                    "INSERT INTO Employee(name, surname, role, contactNum, BusinessClientID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    child.Name, child.Surname, child.Role, child.ContactNum, parent.Id));

            dh.Dispose();
        }

        public void Remove(Employee child, BusinessClient parent)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Employee", "EmployeeID = " + child.Id.ToString());

            dh.Dispose();
        }

        public List<Employee> ReadChildren(BusinessClient parent)
        {
            DataHandler dh = new DataHandler();

            List<Employee> empList = new List<Employee>();

            string query = string.Format(
                "SELECT EmployeeID, name, surname, role, contactNum FROM Employee WHERE BusinessClientID = {0}",
                parent.Id
            );

            SqlDataReader read = dh.Select(query);
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
    }
}