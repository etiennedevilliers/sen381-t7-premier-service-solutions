using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class ServiceContractController : ICreate<ServiceContract>, IDelete<ServiceContract>, IUpdate<ServiceContract>//,IRead<ServiceContract>
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

        //ServiceContract sc = new ServiceContract();

        /*  public List<ServiceContract> Read()
      {

          /*DataHandler dh = new DataHandler();

          List<ServiceContract> Constracts = new List<ServiceContract>();
          SqlDataReader read = dh.Select("SELECT ServiceContractID, description, dateFinalised, dateTerminated, cost, status FROM ServiceContract WHERE ServiceContractID = " + sc.id.ToString());

          return Constracts;
      }*/

    }
}
