using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class EmployeeController : IUpdate<Employee>
    {
        public void Update(Employee obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Employee SET name = '{0}', surname = '{1}', role = '{2}', contactNum = '{3}' WHERE EmployeeID = {4}", 
                obj.Name, obj.Surname, obj.Role, obj.ContactNum, obj.Id));

            dh.Dispose();
        }
    }
}
