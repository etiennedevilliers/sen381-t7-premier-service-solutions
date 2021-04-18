using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Objects;
using data.layer.access;
using System.Data.SqlClient;


namespace data.layer.controller
{
   class PackageController : ICreate<Package>, IDelete<Package>, IUpdate<Package>//IRead<Package>
    {
        /* ServiceContract SC;

        public PackageController(ServiceContract sc)
        {
            this.SC = sc;
        }*/

        //Create 
        public int Create(Package obj)
        {
           
            DataHandler dh = new DataHandler(); //Create a instance of Data handler to connect to make use of the Numerous Commands (Like stored procedures, but for the program)

            //Call the InsertID Method to insert the new instance of the package to the database
            int ID = dh.InsertID(string.Format(
                "INSERT INTO Package(ServiceID, ServiceLevelAgreementID, pName, pDescription) VALUES ({0}, {1}, '{2}', '{3}')",        
                 obj.service.id,
                 obj.sla.id,
                 obj.name,
                 obj.decription
                ));

            obj.id = ID;

            dh.Dispose(); //Close the Data handler Which represents the InsertInto SQL Command (We close the DH because addo . net does not allow for more than one command to be utelized at a time)
    
            return ID;
        }

        //Delete 

        public void Delete(Package obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Package", "PackageID = " + obj.id.ToString());

            dh.Dispose();

        }
        //Update 

        public void Update(Package obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.Package SET ServiceID = {1}, ServiceLevelAgreementID = {2}, pName = '{3}', pDescription = '{4}' WHERE PackageID = {0} ",

                 obj.id,
                 obj.service.id,
                 obj.sla.id,
                 obj.name,
                 obj.decription          
                ));

            dh.Dispose();
        }

        /*//Read 
        public List<Package> Read()
        {
            DataHandler dh = new DataHandler();

            List<Package> packageList = new List<Package>();

            SqlDataReader read = dh.Select("SELECT PackageID, pDecription, pName FROM Package WHERE ServiceContractID = " + SC.Id.ToString());
            ServiceContract newServiceContract;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    NewPackage = new Package(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3)
                        );

                    newPackage.Id = read.GetInt32(0);

                    packageList.Add(newServiceContract);
                }
            }

            dh.Dispose();

            return empList;
        }*/


    }
}
