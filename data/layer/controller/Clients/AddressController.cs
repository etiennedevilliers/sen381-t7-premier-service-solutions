using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class AddressController : IUpdate<Address>
    {
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