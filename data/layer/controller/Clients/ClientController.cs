using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    internal class ClientController : ICreate<Client>, IUpdate<Client>, IDelete<Client>
    {
        public ServiceContractChildren serviceContract = new ServiceContractChildren();
        public EquipmentChildren equipment = new EquipmentChildren();
        public AddressChildren address = new AddressChildren();

        public class ServiceContractChildren : IChildren<ClientServiceContract, Client>
        {
            public void Add(ClientServiceContract child, Client parent)
            {
                DataHandler dh = new DataHandler();

                string query = string.Format( // Check date dates
                    "INSERT INTO clientServiceContracts(ServiceContractID, ClientID, DateStart, DateEnd) VALUES({0}, {1}, '{2}', '{3}')",
                    child.Id,
                    parent.Id,
                    child.StartDate.Value == null ? null : child.StartDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    child.EndDate.Value == null ? null : child.EndDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")
                );
                dh.Insert(query);

                dh.Dispose();
            }

            public List<ClientServiceContract> ReadChildren(Client parent)
            {
                DataHandler dh = new DataHandler();

                List<ClientServiceContract> clientServiceContracts = new List<ClientServiceContract>();

                string query = String.Format("SELECT SC.ServiceContractID, SC.description, SC.dateFinalised, SC.dateTerminated, SC.cost, SC.status, SC.identifier, CSC.DateStart, CSC.DateEnd " +
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
                                read.GetString(5),
                                read.IsDBNull(6) ? null : read.GetString(6)
                            );

                        newSc.Id = read.GetInt32(0);

                        ClientServiceContract clientServiceContract = new ClientServiceContract(
                            read.IsDBNull(7) ? null : new DateTime?(read.GetDateTime(7)),
                            read.IsDBNull(8) ? null : new DateTime?(read.GetDateTime(8)),
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
        }

        public class EquipmentChildren : IChildren<Equipment, Client>
        {
            public void Add(Equipment child, Client parent)
            {
                DataHandler dh = new DataHandler();

                child.Id = dh.InsertID(string.Format(
                                "INSERT INTO Equipment(SerialNumber, Manufacturer, ClientID, EquipmentCategoryID)" +
                                "VALUES ('{0}', '{1}', {2}, {3})",
                                child.SerialNumber, child.Manufacturer, parent.Id, child.Category.Id
                            ));

                dh.Dispose();
            }

            public List<Equipment> ReadChildren(Client parent)
            {
                DataHandler dh = new DataHandler();

                List<Equipment> equipmentList = new List<Equipment>();

                string query = String.Format(
                    "SELECT EquipmentID, SerialNumber, Manufacturer, E.EquipmentCategoryID, EC.CategoryName " +
                    "FROM Equipment E INNER JOIN EquipmentCategory EC ON EC.EquipmentCategoryID = E.EquipmentCategoryID " +
                    "WHERE ClientID = {0}", 
                    parent.Id
                );

                SqlDataReader read = dh.Select(query);
                Equipment equipment;
                EquipmentCategory category;

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        equipment = new Equipment(
                                read.GetString(1),
                                read.GetString(2)
                            );

                        equipment.Id = read.GetInt32(0);

                        category = new EquipmentCategory(
                                read.GetString(4)
                            );

                        category.Id = read.GetInt32(3);

                        equipment.Category = category;

                        equipmentList.Add(equipment);
                    }
                }

                dh.Dispose();

                return equipmentList;
            }

            public void Remove(Equipment child, Client parent)
            {
                DataHandler dh = new DataHandler();

                dh.Delete("Equipment", "EquipmentID = " + child.Id.ToString());

                dh.Dispose();
            }
        }

        public class AddressChildren : IChildren<Address, Client>
        {
            public void Add(Address child, Client parent)
            {
                DataHandler dh = new DataHandler();

                child.Id = dh.InsertID(string.Format(
                                "INSERT INTO Address(country, province, district, locality, postalCode, streetAddress, premise, ClientID)" +
                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                                child.Country, child.Province, child.District, child.Locality, child.PostalCode, child.StreetAddress, child.Premise, parent.Id
                            ));

                dh.Dispose();
            }

            public List<Address> ReadChildren(Client parent)
            {
                DataHandler dh = new DataHandler();

                List<Address> addrList = new List<Address>();
                SqlDataReader read = dh.Select("SELECT AddressID, country, province, district, locality, postalCode, streetAddress, premise FROM Address WHERE ClientID = " + parent.Id.ToString());
                Address address;

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        address = new Address(
                                read.GetString(1),
                                read.GetString(2),
                                read.GetString(3),
                                read.GetString(4),
                                read.GetString(5),
                                read.GetString(6),
                                read.GetString(7)
                            );

                        address.Id = read.GetInt32(0);

                        addrList.Add(address);
                    }
                }

                dh.Dispose();

                return addrList;
            }

            public void Remove(Address child, Client parent)
            {
                DataHandler dh = new DataHandler();

                dh.Delete("Address", "AddressID = " + child.Id.ToString());

                dh.Dispose();
            }
        }

        public int Create(Client obj)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO Client(contactNum, ClientIdentifier) VALUES ('{0}', '{1}')",
                obj.ContactNum,
                obj.ClientIdentifier
            );

            int ID = dh.InsertID(query);

            dh.Dispose();

            return ID;
        }

        public void Delete(Client obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Client", "ClientID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public void Update(Client obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Client SET contactNum = '{0}', ClientIdentifier = '{2}' WHERE ClientID = {1}", obj.ContactNum, obj.Id, obj.ClientIdentifier));

            dh.Dispose();
        }
    }
}
