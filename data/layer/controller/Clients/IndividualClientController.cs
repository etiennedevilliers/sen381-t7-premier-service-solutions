using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class IndividualClientController : ICreate<IndividualClient>, IRead<IndividualClient>, IUpdate<IndividualClient>, IDelete<IndividualClient>
    {
        //Basic CRUD
        public int Create(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            ClientController cl = new ClientController();
            obj.Id = cl.Create(obj);

            dh.Insert("INSERT INTO IndividualClient(IndividualClientID, name, surname) VALUES (" + obj.Id + ", '" + obj.Name + "', '" + obj.Surname + "')");
            
            dh.Dispose();
            
            return obj.Id;
        }

        public void Delete(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("IndividualClient", "IndividualClientID = " + obj.Id.ToString());
            ClientController cl = new ClientController();
            cl.Delete(obj);

            dh.Dispose();
        }

        public List<IndividualClient> Read()
        {
            DataHandler dh = new DataHandler();

            List<IndividualClient> indList = new List<IndividualClient>();
            SqlDataReader read = dh.Select("SELECT IC.IndividualClientID, name, surname, contactNum, ClientIdentifier FROM dbo.IndividualClient AS IC LEFT JOIN dbo.Client AS C ON C.ClientID = IC.IndividualClientID");
            IndividualClient newCl;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newCl = new IndividualClient(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.IsDBNull(4) ? null : read.GetString(4)
                        );

                    newCl.Id = read.GetInt32(0);

                    indList.Add(newCl);
                }
            }

            dh.Dispose();

            return indList;
        }

        public void Update(IndividualClient obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.IndividualClient SET name = '{0}', surname = '{1}' WHERE IndividualClientID = {2}", obj.Name, obj.Surname, obj.Id));
            ClientController cl = new ClientController();
            cl.Update(obj);

            dh.Dispose();
        }
    }
}