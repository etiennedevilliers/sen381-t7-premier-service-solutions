using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class AddressController : ICreate<Address>, IRead<Address>, IUpdate<Address>, IDelete<Address>
    {
        Client client;

        public AddressController(Client client)
        {
            this.client = client;
        }

        //Basic CRUD
        public int Create(Address obj)
        {
            DataHandler dh = new DataHandler();

            dh.Insert(string.Format(
                        "INSERT INTO Address(country, province, district, locality, postalCode, streetAddress, premise, ClientID)" +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                        obj.Country, obj.Province, obj.District, obj.Locality, obj.PostalCode, obj.StreetAddress, obj.Premise, client.Id
                    ));

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(Address obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Address", "AddressID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<Address> Read()
        {
            DataHandler dh = new DataHandler();

            List<Address> addrList = new List<Address>();
            SqlDataReader read = dh.SelectSimple("Address", "WHERE ClientID = " + client.Id.ToString());
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

        public void Update(Address obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                    "UPDATE Address" +
                    "SET country = '{0}', province = '{1}', district = '{2}', locality = '{3}', postalCode = '{4}', streetAddress = '{5}', premise = '{6}'" +
                    "WHERE AddressID = {7}",
                    obj.Country, obj.Province, obj.District, obj.Locality, obj.PostalCode, obj.StreetAddress, obj.Premise, obj.Id
                ));

            dh.Dispose();
        }
    }
}