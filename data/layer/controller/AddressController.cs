using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class AddressController : ICreate<Address>, IRead<Address>, IUpdate<Address>, IDelete<Address>
    {
        Client client;

        public AddressController(Client client)
        {
            this.client = client;
        }

        public int Create(Address obj)
        {
            DataHandler dh = new DataHandler();

            dh.Insert(string.Format(
                        "INSERT INTO Address(country, province, district, locality, postalCode, streetAddress, premise, ClientID)" +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                        obj.country, obj.province, obj.district, obj.locality, obj.postalCode, obj.streetAddress, obj.premise, client.id
                    ));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(Address obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Address", "AddressID = " + obj.id.ToString());

            dh.Dispose();
        }

        public List<Address> Read()
        {
            DataHandler dh = new DataHandler();

            List<Address> addrList = new List<Address>();
            SqlDataReader read = dh.SelectSimple("Address", "WHERE ClientID = " + client.id.ToString());
            Address newAddr;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    newAddr = new Address(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4),
                            read.GetString(5),
                            read.GetString(6),
                            read.GetString(7)
                        );

                    newAddr.id = read.GetInt32(0);

                    addrList.Add(newAddr);
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
                    obj.country, obj.province, obj.district, obj.locality, obj.postalCode, obj.streetAddress, obj.premise, obj.id
                ));

            dh.Dispose();
        }
    }
}
