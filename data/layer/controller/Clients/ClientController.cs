using System;
using System.Collections.Generic;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    internal class ClientController : ICreate<Client>, IUpdate<Client>, IDelete<Client>
    {
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

        public void Update(Client obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format("UPDATE dbo.Client SET contactNum = '{0}' WHERE ClientID = {1}", obj.ContactNum, obj.Id));

            dh.Dispose();
        }
    }
}
