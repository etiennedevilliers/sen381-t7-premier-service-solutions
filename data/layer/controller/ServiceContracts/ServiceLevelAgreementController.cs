using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using Data.Layer.Access;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class ServiceLevelAgreementController : ICreate<ServiceLevelAgreement>, IDelete<ServiceLevelAgreement>, IUpdate<ServiceLevelAgreement>,IRead<ServiceLevelAgreement>
    {
        //Basic CRUD
        public int Create(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO ServiceLevelAgreement(slaDescription) VALUES ('{0}')",
                obj.Description
            );

            int ID = dh.InsertID(query);

            obj.Id = ID;

            dh.Dispose();

            return ID;
        }

        public void Delete(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("ServiceLevelAgreement", "ServiceLevelAgreementID = " + obj.Id);

            dh.Dispose();
        }

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
                   newSLA.Id = read.GetInt32(0);

                   slas.Add(newSLA);
                }
            }

            dh.Dispose();
            return slas;
        }

        public void Update(ServiceLevelAgreement obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.ServiceLevelAgreement SET slaDescription = '{1}' WHERE ServiceLevelAgreementID = {0} ",
                obj.Id,
                obj.Description
                )) ;
        }
    }
}