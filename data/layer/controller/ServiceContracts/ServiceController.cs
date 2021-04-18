using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class ServiceController : ICreate<Service>, IDelete<Service>, IUpdate<Service>,IRead<Service>
    {

        //Create 
        public int Create(Service obj)
        {

            DataHandler dh = new DataHandler();
            int ID = dh.InsertID(string.Format(
                "INSERT INTO  Service(sDescription,expectedDuration) VALUES ('{0}','{1}')",
                obj.description,
                obj.expectedDuration
                ));

            obj.id = ID;

            dh.Dispose();

            return ID;
        }

        //Delete 
        public void Delete(Service obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Service", "ServiceID = " + obj.id.ToString());

            dh.Dispose();
        }

        //Read 
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
                       // 
                        read.GetInt32(2),
                        read.GetString(1)                                          
                        );

                  newservice.id = read.GetInt32(0);

                    services.Add(newservice);
                }
            }
            dh.Dispose();
            return services;
        }



        //Update 
        public void Update(Service obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Service SET sDescription = '{1}', expectedDuration = '{2}' WHERE ServiceID = {0} ,",

                obj.description,
                obj.expectedDuration          
                ));
        }
    }
}
