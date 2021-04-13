using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class IndividualClientController : ICreate<IndividualClient>, IRead<IndividualClient>, IUpdate<IndividualClient>, IDelete<IndividualClient>
    {
        public int Create(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            ClientController cl = new ClientController();
            obj.id = cl.Create(obj);

            dh.Insert("INSERT INTO IndividualClient(IndividualClientID, name, surname) VALUES (" + obj.id + ", '" + obj.name + "', '" + obj.surname + "')");
            
            dh.Dispose();
            
            return obj.id;
        }

        public void Delete(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("IndividualClient", "IndividualClientID = " + obj.id.ToString());
            ClientController cl = new ClientController();
            cl.Delete(obj);

            dh.Dispose();
        }

        public List<IndividualClient> Read()
        {
            DataHandler dh = new DataHandler();

            List<IndividualClient> indList = new List<IndividualClient>();
            SqlDataReader read = dh.Select("SELECT IC.IndividualClientID, name, surname, contactNum FROM dbo.IndividualClient AS IC LEFT JOIN dbo.Client AS C ON C.ClientID = IC.IndividualClientID");
            IndividualClient newCl;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newCl = new IndividualClient(
                            read.GetString(3),
                            read.GetString(1),
                            read.GetString(2)
                        );

                    newCl.id = read.GetInt32(0);

                    indList.Add(newCl);
                }
            }

            dh.Dispose();

            return indList;
        }

        public void Update(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.IndividualClient SET name = '{0}', surname = '{1}' WHERE IndividualClientID = {2}", obj.name, obj.surname, obj.id));
            ClientController cl = new ClientController();
            cl.Update(obj);

            dh.Dispose();
        }
    }
}