using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class ServiceContractController : ICreate<ServiceContract>, IDelete<ServiceContract>, IUpdate<ServiceContract>,IRead<ServiceContract>, IChildren<Package, ServiceContract>
    {


        public int Create(ServiceContract obj)
        {

            DataHandler dh = new DataHandler();

            obj.id = dh.InsertID(string.Format("INSERT INTO ServiceContract (description, dateFinalised, dateTerminated, cost, status ) VALUES ('{0}', '{1}','{2}', '{3}','{4}')",        
                obj.Description, 
                obj.DateFinalised,
                obj.DateTerminated,
                obj.Cost, 
                obj.Status));

            dh.Dispose();

            return obj.id;
        }


        public void Delete(ServiceContract obj)
        {
            DataHandler dh = new DataHandler();
            dh.Delete("ServiceContract","ServiceContractID = "+obj.id.ToString());

            dh.Dispose();
        }

        public void Update(ServiceContract obj)
        {

            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.ServiceContract SET description = '{0}', dateFinalised = '{1}', dateTerminated = '{2}', cost = '{3}', status = '{4}' WHERE  ServiceContractID = {5}",
                obj.Description, obj.DateFinalised, obj.DateTerminated, obj.Cost, obj.Status, obj.id ));

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
                            Decimal.ToDouble(read.GetDecimal(4)),
                            read.GetDateTime(2),
                            read.GetDateTime(3),
                            read.GetString(5)
                        );

                    newSc.id = read.GetInt32(0);

                    scrList.Add(newSc);
                }
            }

            dh.Dispose();

            return scrList;
        }

        public void Add(Package child, ServiceContract parent)
        {
            DataHandler dh = new DataHandler();

            String query = string.Format(
                "INSERT INTO serviceContractPackages(ServiceContractID, PackageID) VALUES({0}, {1})",
                parent.id,
                child.id
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public void Remove(Package child, ServiceContract parent) 
        {
            DataHandler dh = new DataHandler();

            dh.Delete("serviceContractPackages", String.Format(
                "ServiceContractID={0} AND PackageID={1}",
                parent.id,
                child.id
            ));

            dh.Dispose();
        }

        public List<Package> ReadChildren(ServiceContract parent)
        {
            DataHandler dh = new DataHandler();

            List<Package> packageList = new List<Package>();

            String query = String.Format("SELECT P.PackageID, P.pName, P.pDescription, S.ServiceID, S.expectedDuration, S.sDescription, SLA.ServiceLevelAgreementID, SLA.slaDescription FROM Package AS P " +
	                            "LEFT JOIN Service AS S ON S.ServiceID = P.ServiceID " +
	                            "LEFT JOIN ServiceLevelAgreement AS SLA ON SLA.ServiceLevelAgreementID = P.ServiceLevelAgreementID " +
	                            "LEFT JOIN serviceContractPackages AS SCP ON SCP.PackageID = P.PackageID " +
                            "WHERE SCP.ServiceContractID={0}", parent.id);

            SqlDataReader read = dh.Select(query);
            Service service;
            ServiceLevelAgreement serviceLevelAgreement;
            Package package;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    service = new Service(
                        read.GetInt32(4),
                        read.GetString(5)
                    );
                    service.id = read.GetInt32(3);
                    
                    serviceLevelAgreement = new ServiceLevelAgreement(
                        read.GetString(7)
                    );
                    serviceLevelAgreement.id = read.GetInt32(6);

                    package = new Package(
                        read.GetString(1),
                        read.GetString(2),
                        service,
                        serviceLevelAgreement
                    );

                    package.id = read.GetInt32(0);

                    packageList.Add(package);
                }
            }

            dh.Dispose();

            return packageList;

        }

    }
}
