using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller
{
    internal class RequestController : ICreate<Request>, IDelete<Request>, IUpdate<Request>
    {
        public int Create(Request obj)
        {
            DataHandler dh = new DataHandler();


            int ID = dh.InsertID(string.Format(
                "INSERT INTO Request(ClientID, dateCreated, dateResolved, status, contactNum, CallID) VALUES ({0},'{1}','{2}','{3}','{4}', {5})",
                (obj.client != null) ? obj.client.id.ToString() : "null",
                obj.dateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.dateResolved.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.status,
                obj.contactNum,
                obj.call.id
            ));

            obj.id = ID;

            dh.Dispose();

            return ID;
        }
        public void Delete(Request obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Request", "RequestID = " + obj.id.ToString());

            dh.Dispose();
        }

        public void Update(Request obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.Request SET ClientID={1}, CallID={2}, dateCreated='{3}', dateResolved='{4}', status='{5}', contactNum='{6}' WHERE RequestID = {0}", 
                obj.id,
                obj.client.id,
                obj.call.id,
                obj.dateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.dateResolved.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.status,
                obj.contactNum
             ));

            dh.Dispose();
        }
    }
}
