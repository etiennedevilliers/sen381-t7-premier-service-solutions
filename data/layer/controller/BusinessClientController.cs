using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class BusinessClientController : ICreate<BusinessClient>, IRead<BusinessClient>, IUpdate<BusinessClient>, IDelete<BusinessClient>
    {
        public int Create(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            ClientController cl = new ClientController();
            obj.id = cl.Create(obj);

            dh.Insert("INSERT INTO BusinessClient(BusinessClientID, name) VALUES (" + obj.id + ", '" + obj.businessName + "')");

            return obj.id;
        }

        public void Delete(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("BusinessClient", "BusinessClientID = " + obj.id.ToString());
            ClientController cl = new ClientController();
            cl.Delete(obj);
        }

        public List<BusinessClient> Read()
        {
            DataHandler dh = new DataHandler();

            List<BusinessClient> indList = new List<BusinessClient>();
            SqlDataReader read = dh.Select("SELECT IC.BusinessClientID, name, contactNum FROM dbo.BusinessClient AS IC LEFT JOIN dbo.Client AS C ON C.ClientID = IC.BusinessClientID");
            BusinessClient newCl;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newCl = new BusinessClient(
                            read.GetString(2),
                            read.GetString(1)
                        );

                    newCl.id = read.GetInt32(0);

                    indList.Add(newCl);
                }
            }

            return indList;
        }

        public void Update(BusinessClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.BusinessClient SET name = '{0}' WHERE BusinessClientID = {1}", obj.businessName, obj.id));
            ClientController cl = new ClientController();
            cl.Update(obj);
        }
    }
}
