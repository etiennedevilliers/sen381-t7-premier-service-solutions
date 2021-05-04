using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    internal class ClientController : ICreate<Client>, IUpdate<Client>, IDelete<Client>, IChildren<ClientServiceContract, Client>
    {
        public void Add(ClientServiceContract child, Client parent)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format( // Check date dates
                "INSERT INTO clientServiceContracts(ServiceContractID, ClientID, DateStart, DateEnd) VALUES({0}, {1}, '{2}', '{3}')",
                child.Id,
                parent.Id,
                child.StartDate,
                child.EndDate
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public int Create(Client obj)
        {
            DataHandler dh = new DataHandler();

            int ID = dh.InsertID("INSERT INTO Client(contactNum) VALUES ('" + obj.ContactNum + "')");

            dh.Dispose();

            return ID;
        }

        public void Delete(Client obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Client", "ClientID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<ClientServiceContract> ReadChildren(Client parent)
        {
            DataHandler dh = new DataHandler();

            List<ClientServiceContract> clientServiceContracts = new List<ClientServiceContract>();

            string query = String.Format("SELECT SC.ServiceContractID, SC.description, SC.dateFinalised, SC.dateTerminated, SC.cost, SC.status, CSC.DateStart, CSC.DateEnd " +
                                         "FROM clientServiceContracts as CSC " +
                                            "LEFT JOIN ServiceContract AS SC ON CSC.ServiceContractID = SC.ServiceContractID " +
                                         "WHERE CSC.ClientID = {0}", parent.Id);
            SqlDataReader read = dh.Select(query);

            if (read.HasRows)
            {
                while (read.Read())
                {
                    ServiceContract newSc = new ServiceContract(
                            read.GetString(1),
                            decimal.ToDouble(read.GetDecimal(4)),
                            read.GetDateTime(2),
                            read.GetDateTime(3),
                            read.GetString(5)
                        );

                    newSc.Id = read.GetInt32(0);

                    ClientServiceContract clientServiceContract = new ClientServiceContract(
                        read.IsDBNull(6) ? null : new DateTime?(read.GetDateTime(6)),
                        read.IsDBNull(7) ? null : new DateTime?(read.GetDateTime(7)),
                        newSc
                    );

                    clientServiceContracts.Add(clientServiceContract);
                }
            }

            dh.Dispose();

            return clientServiceContracts;
        }

        public void Remove(ClientServiceContract child, Client parent)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("clientServiceContracts", string.Format(
                "ServiceContractID = {0} AND ClientID = {1}",
                child.Id,
                parent.Id
            ));

            dh.Dispose();
        }

        public void Update(Client obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Client SET contactNum = '{0}' WHERE ClientID = {1}", obj.ContactNum, obj.Id));

            dh.Dispose();
        }
    }
}
