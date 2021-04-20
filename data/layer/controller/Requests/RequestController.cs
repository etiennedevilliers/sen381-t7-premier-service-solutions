using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;

namespace data.layer.controller
{
    class RequestController : IChildren<Agent, Request>
    {
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
    }
}
