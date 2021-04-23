using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    class RequestController : IChildren<Agent, Request>, IChild<Client,Request>
    {
        internal int Create(Request obj)
        {
            DataHandler dh = new DataHandler();

            int ID = dh.InsertID(string.Format(
                "INSERT INTO Request(ClientID, dateCreated, dateResolved, status, contactNum, CallID) VALUES ({0},'{1}','{2}','{3}','{4}', {5})",
                (obj.Client != null) ? obj.Client.Id.ToString() : "null",
                obj.DateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.DateResolved.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.Status,
                obj.ContactNum,
                obj.Call.Id
            ));

            obj.Id = ID;

            dh.Dispose();

            return ID;
        }

        internal void Delete(Request obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Request", "RequestID = " + obj.Id.ToString());

            dh.Dispose();
        }

        internal void Update(Request obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.Request SET ClientID={1}, CallID={2}, dateCreated='{3}', dateResolved='{4}', status='{5}', contactNum='{6}' WHERE RequestID = {0}", 
                obj.Id,
                obj.Client.Id,
                obj.Call.Id,
                obj.DateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"), 
                obj.DateResolved.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.Status,
                obj.ContactNum
             ));

            dh.Dispose();
        }
    
        public void Add(Agent child, Request parent) {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO agentRequestHandlers(AgentID, RequestID) VALUES({0}, {1})",
                child.Id,
                parent.Id
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public void Remove(Agent child, Request parent) {
            DataHandler dh = new DataHandler();

            dh.Delete("agentRequestHandlers", string.Format(
                "AgentID = {0} AND RequestID = {1}",
                child.Id,
                parent.Id
            ));

            dh.Dispose();
        }

        public List<Agent> ReadChildren(Request parent) 
        {
            DataHandler dh = new DataHandler();

            List<Agent> agents = new List<Agent>();

            string query = "SELECT A.AgentID, A.aName, A.contactNum, A.employmentStatus, A.employeeType, T.TechnicianID " +
                            "FROM Agent A " +
                            "LEFT OUTER JOIN agentRequestHandlers H ON A.AgentID = H.AgentID " +
                            "LEFT OUTER JOIN Technician T ON T.TechnicianID = A.AgentID " +
                            "WHERE H.RequestID = {0}";

            SqlDataReader read = dh.Select(string.Format(query, parent.Id));
            Agent agent;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    if (!read.IsDBNull(5))
                    {
                        agent = new Technician(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4)
                        );
                    }
                    else
                    {
                        agent = new Agent(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4)
                        );
                    }

                    agent.Id = read.GetInt32(0);

                    agents.Add(agent);
                }
            }
            dh.Dispose();
            return agents;
        }


        //Child CRUD
        public void Set(Client child , Request parent)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(

                    "UPDATE Request SET ClientID = {0} WHERE RequestID = {1}",
                    child.Id,
                    parent.Id
                );

            dh.Update(query);

            dh.Dispose();
        }
 
        public Client ReadChild(Request parent)
        {
            DataHandler dh = new DataHandler();

            string qry = string.Format
                (
                    "SELECT R.ClientID, BC.name, IC.name, IC.surname, C.contactNum " +
                    "FROM Request R " +
                    "LEFT OUTER JOIN Client C ON C.ClientID = R.ClientID " +
                    "LEFT OUTER JOIN IndividualClient IC ON IC.IndividualClientID = C.ClientID " +
                    "LEFT OUTER JOIN BusinessClient BC ON BC.BusinessClientID = C.ClientID " +
                    "WHERE RequestID = {0}", parent.Id
                );

            SqlDataReader read = dh.Select(qry);
            Client newClient = null;

            if (read.HasRows)
            {
                read.Read();

                if (read.IsDBNull(1))
                {
                    newClient = new IndividualClient(read.GetString(4), read.GetString(2), read.GetString(3));
                }
                else
                {
                    newClient = new BusinessClient(read.GetString(4), read.GetString(1));
                }

                newClient.Id = read.GetInt32(0);
            }

            dh.Dispose();

            return newClient;
        }
    }
}
