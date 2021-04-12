using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller
{
    internal class ClientController : DataHandler, ICreate<Client>, IUpdate<Client>, IDelete<Client>
    {
        public int Create(Client obj)
        {
            return insertID("INSERT INTO Client(contactNum) VALUES ('" + obj.contactNum + "')");
        }

        public void Delete(Client obj)
        {
            delete("Client", "ClientID = " + obj.id.ToString());
        }

        public void Update(Client obj)
        {
            update(string.Format("UPDATE dbo.Client SET contactNum = '{0}' WHERE ClientID = {1}", obj.contactNum, obj.id));
        }
    }
}
