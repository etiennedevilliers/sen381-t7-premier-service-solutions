using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    internal class ClientController : ICreate<Client>, IUpdate<Client>, IDelete<Client>, IChildren<ServiceContract, Client>
    {
        public void Add(ServiceContract child, Client parent)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO clientServiceContracts(ServiceContractID, ClientID) VALUES({0}, {1})",
                child.Id,
                parent.Id
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

        public List<ServiceContract> ReadChildren(Client parent)
        {
            DataHandler dh = new DataHandler();

            List<ServiceContract> serviceContracts = new List<ServiceContract>();

            string query = String.Format("SELECT SC.ServiceContractID, SC.description, SC.dateFinalised, SC.dateTerminated, SC.cost, SC.status, SC.identifier " +
                                         "FROM ServiceContract AS SC " +
                                            "LEFT JOIN clientServiceContracts as CSC ON CSC.ServiceContractID = SC.ServiceContractID " +
                                         "WHERE CSC.ClientID = {0}", parent.Id);
            SqlDataReader read = dh.Select(query);

            ServiceContract newSc;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newSc = new ServiceContract(
                            read.GetString(1),
                            decimal.ToDouble(read.GetDecimal(4)),
                            read.GetDateTime(2),
                            read.GetDateTime(3),
                            read.GetString(5),
                            read.IsDBNull(6) ? null : read.GetString(6)
                        );

                    newSc.Id = read.GetInt32(0);

                    serviceContracts.Add(newSc);
                }
            }

            dh.Dispose();

            return serviceContracts;
        }

        public void Remove(ServiceContract child, Client parent)
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
