﻿using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using Data.Layer.Access;
using System.Data.SqlClient;


namespace Data.Layer.Controller
{
   class PackageController : ICreate<Package>, IDelete<Package>, IUpdate<Package>, IRead<Package>
    {
        //Basic CRUD
        public int Create(Package obj)
        {
            DataHandler dh = new DataHandler();

            int ID = dh.InsertID(string.Format(
                "INSERT INTO Package(ServiceID, ServiceLevelAgreementID, pName, pDescription) VALUES ({0}, {1}, '{2}', '{3}', '{4}')",        
                 obj.Service.Id,
                 obj.Sla.Id,
                 obj.Name,
                 obj.Description,
                 obj.Equiptment
                ));

            obj.Id = ID;

            dh.Dispose(); 
    
            return ID;
        }

        public void Delete(Package obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Package", "PackageID = " + obj.Id.ToString());

            dh.Dispose();

        }

        public void Update(Package obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.Package SET ServiceID = {1}, ServiceLevelAgreementID = {2}, pName = '{3}', pDescription = '{4}', EquipmentCategoryID = '{5}' WHERE PackageID = {0} ",

                 obj.Id,
                 obj.Service.Id,
                 obj.Sla.Id,
                 obj.Name,
                 obj.Description,
                 obj.Equiptment
                ));

            dh.Dispose();
        }

        public List<Package> Read()
        {            
            DataHandler dh = new DataHandler();

            List<Package> packageList = new List<Package>();

            string query = "SELECT P.PackageID, P.pName, P.pDescription, S.ServiceID, S.expectedDuration, S.sDescription, SLA.ServiceLevelAgreementID, SLA.slaDescription, P.EquipmentCategoryID FROM Package AS P " +
	                            "LEFT JOIN Service AS S ON S.ServiceID = P.ServiceID " +
	                            "LEFT JOIN ServiceLevelAgreement AS SLA ON SLA.ServiceLevelAgreementID = P.ServiceLevelAgreementID";

            SqlDataReader read = dh.Select(query);
            Service service;
            ServiceLevelAgreement serviceLevelAgreement;
            Package package;
            


            if (read.HasRows)
            {
                while (read.Read())
                {
                    service = new Service(
                        read.GetString(5),
                        read.GetInt32(4)
                    );
                    service.Id = read.GetInt32(3);
                    
                    serviceLevelAgreement = new ServiceLevelAgreement(
                        read.GetString(7)
                    );
                    serviceLevelAgreement.Id = read.GetInt32(6);

                    package = new Package(
                        read.GetString(1),
                        read.GetString(2),
                        service,
                        serviceLevelAgreement,
                        read.GetInt32(8)
                    );

                    package.Id = read.GetInt32(0);

                    packageList.Add(package);
                }
            }

            dh.Dispose();

            return packageList;
        }
    }
}