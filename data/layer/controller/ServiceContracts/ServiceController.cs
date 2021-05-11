using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using Data.Layer.Access;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class ServiceController : ICreate<Service>, IDelete<Service>, IUpdate<Service>,IRead<Service>
    {
        //Basic CRUD
        public int Create(Service obj)
        {
            DataHandler dh = new DataHandler();
            int ID = dh.InsertID(string.Format(
                "INSERT INTO  Service(sDescription,expectedDuration) VALUES ('{0}','{1}')",
                obj.Description,
                obj.ExpectedDuration
                ));

            obj.Id = ID;

            dh.Dispose();

            return ID;
        }

        public void Delete(Service obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Service", "ServiceID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<Service> Read()
        {
            DataHandler dh = new DataHandler();

            List<Service> services = new List<Service>();

            SqlDataReader read = dh.Select("SELECT ServiceID, sDescription, expectedDuration FROM Service");

            Service newservice;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newservice = new Service(
                        read.GetString(1),
                        read.GetInt32(2)
                    );

                    newservice.Id = read.GetInt32(0);

                    services.Add(newservice);
                }
            }

            dh.Dispose();

            return services;
        }

        public void Update(Service obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Service SET sDescription = '{1}', expectedDuration = '{2}' WHERE ServiceID = {0}",
                obj.Id,
                obj.Description,
                obj.ExpectedDuration
                ));
        }
    }
}

