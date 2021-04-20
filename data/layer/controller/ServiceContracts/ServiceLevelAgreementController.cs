using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class ServiceLevelAgreementController : ICreate<ServiceLevelAgreement>, IDelete<ServiceLevelAgreement>, IUpdate<ServiceLevelAgreement>,IRead<ServiceLevelAgreement>
    {

        //Create  
        public int Create(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            String query = string.Format(
                "INSERT INTO ServiceLevelAgreement(slaDescription) VALUES ('{0}')",
                obj.description
            );

            Console.WriteLine(query);

            int ID = dh.InsertID(query);

            obj.id = ID;

            dh.Dispose();

            return ID;
        }

        //Delete 
        public void Delete(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("ServiceLevelAgreement", "ServiceLevelAgreementID = " + obj.id);

            dh.Dispose();
        }

        //Read 
        public List<ServiceLevelAgreement> Read()
        {
            DataHandler dh = new DataHandler();

            List<ServiceLevelAgreement> slas = new List<ServiceLevelAgreement>();

            SqlDataReader read = dh.Select("SELECT ServiceLevelAgreementID, slaDescription FROM ServiceLevelAgreement");

            ServiceLevelAgreement newSLA;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newSLA = new ServiceLevelAgreement(
                        read.GetString(1)
                        );
                   newSLA.id = read.GetInt32(0);

                   slas.Add(newSLA);
                }
            }

           
            dh.Dispose();
            return slas;
        }


        //Update
        public void Update(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.ServiceLevelAgreement SET slaDescription = '{1}' WHERE ServiceLevelAgreementID = {0}",
                obj.id,
                obj.description
                )) ;
        }
    }
}
