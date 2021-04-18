using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class ServiceContractController : ICreate<ServiceContract>, IDelete<ServiceContract>, IUpdate<ServiceContract>,IRead<ServiceContract>
    {


        public int Create(ServiceContract obj)
        {

            DataHandler dh = new DataHandler();

            obj.Id = dh.InsertID(string.Format("INSERT INTO ServiceContract (description, dateFinalised, dateTerminated, cost, status ) VALUES ('{0}', '{1}','{2}', '{3}','{4}')",        
                obj.Description, 
                obj.DateFinalised,
                obj.DateTerminated,
                obj.Cost, 
                obj.Status));

            dh.Dispose();

            return obj.Id;
        }


        public void Delete(ServiceContract obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("ServiceContract","ServiceContractID = "+obj.Id.ToString());

            dh.Dispose();
        }

        public void Update(ServiceContract obj)
        {

            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.ServiceContract SET description = '{0}', dateFinalised = '{1}', dateTerminated = '{2}', cost = '{3}', status = '{4}' WHERE  ServiceContractID = {5}",
                obj.Description, obj.DateFinalised, obj.DateTerminated, obj.Cost, obj.Status, obj.Id ));

            dh.Dispose();

        }

        public List<ServiceContract> Read()
        {
            DataHandler dh = new DataHandler();

            List<ServiceContract> scrList = new List<ServiceContract>();
            SqlDataReader read = dh.Select("SELECT ServiceContractID, description, dateFinalised, dateTerminated, cost, status FROM ServiceContract "); //Geen Fk Select nie 
            ServiceContract newSc;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newSc = new ServiceContract(
                            read.GetString(1),
                            read.GetDouble(2),
                            read.GetDateTime(3),
                            read.GetDateTime(4),
                            read.GetString(5)
                        );

                    newSc.Id = read.GetInt32(0);

                    scrList.Add(newSc);
                }
            }

            dh.Dispose();

            return scrList;
        }

    }
}
