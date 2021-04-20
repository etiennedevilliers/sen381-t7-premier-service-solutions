using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller
{
    class RequestController : IChildren<Agent, Request>, IChild<Client,Request>
    {
        private String table_name;
        private String table_identifier_name;

        internal int Create(Request obj)
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

        internal void Delete(Request obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Request", "RequestID = " + obj.id.ToString());

            dh.Dispose();
        }

        internal void Update(Request obj)
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
    
        public void Add(Agent child, Request parent) {
            DataHandler dh = new DataHandler();

            String query = string.Format(
                "INSERT INTO agentRequestHandlers(AgentID, RequestID) VALUES({0}, {1})",
                child.id,
                parent.id
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public void Remove(Agent child, Request parent) {
            DataHandler dh = new DataHandler();

            dh.Delete("Request", String.Format(
                "AgentID={0} AND RequestID={1}",
                child.id,
                parent.id
            ));

            dh.Dispose();
        }

        public List<Agent> ReadChildren(Request parent) 
        {
            DataHandler dh = new DataHandler();

            List<Agent> agents = new List<Agent>();

            String query = "SELECT A.AgentID, A.aName, A.contactNum, A.employmentStatus, A.employeeType FROM Agent AS A " +
	                            "LEFT JOIN agentRequestHandlers AS H ON A.AgentID = H.AgentID " +
                            "WHERE H.RequestID = {0}";

            SqlDataReader read = dh.Select(String.Format(query, parent.id));
            Agent agent;

            if (read.HasRows)
            {
                while (read.Read())
                {

                    agent = new Agent(
                        read.GetInt32(0),
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3),
                        read.GetString(4)
                    );

                    agents.Add(agent);
                }
            }
            dh.Dispose();
            return agents;
        }


        //IChild Implementation 
    
        public void Set(Client child , Request parent)
        {

            DataHandler dh = new DataHandler();


            string query = string.Format(

                    "UPDATE {0} SET ClientID = {1} WHERE {2} = {3}",
                    table_name,
                    child.id,
                    table_identifier_name,
                    parent.id
                );

            dh.Update(query);
            dh.Dispose();

        }
 
        public Client ReadChild(Request parent)
        {
            DataHandler dh = new DataHandler();

            string qry = string.Format("SELECT C.ClientID ,C.contactNumber, I.IndividualClientID,I.name,I.surname FROM Client as C"+
                "LEFT JOIN IndividualClient AS I ON I.IndividualClientID = C.ClientID"+
                "WHERE C.ClientID = {0}"
                );

            SqlDataReader read = dh.Select(qry);
            Client newClient = null;

            if (read.HasRows)
            {
                if (!read.IsDBNull(0))
                {
                    newClient = new IndividualClient(read.GetString(1),read.GetString(2),read.GetString(3));
                }
                else
                {
                    newClient = new BusinessClient(read.GetString(1),read.GetString(2));
                }
               
            }
            dh.Dispose();
            return newClient;
        }

    }
}
