using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Data.Layer.Access;
using Data.Layer.Objects;

namespace Data.Layer.Controller
{
    class RequestController : IChildren<RequestAgent, Request>, IChild<Client,Request>
    {
        internal int Create(Request obj)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO Request(ClientID, dateCreated, dateResolved, status, contactNum, CallID) VALUES ({0},'{1}','{2}','{3}','{4}', {5})",
                (obj.Client != null) ? obj.Client.Id.ToString() : "null",
                obj.DateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.DateResolved == null ? "NULL" : obj.DateResolved.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                obj.Status,
                obj.ContactNum,
                obj.Call.Id
            );

            int ID = dh.InsertID(query);

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
            Client client = obj.Client;

            DataHandler dh = new DataHandler();

            if (client == null) 
            {
                dh.Update(string.Format(
                    "UPDATE dbo.Request SET ClientID={1}, CallID={2}, dateCreated='{3}', dateResolved='{4}', status='{5}', contactNum='{6}' WHERE RequestID = {0}",
                    obj.Id,
                    "NULL",
                    obj.Call.Id,
                    obj.DateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    obj.DateResolved == null ? "null" : obj.DateResolved.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    obj.Status,
                    obj.ContactNum
                 ));
            }
            else
            {
                dh.Update(string.Format(
                    "UPDATE dbo.Request SET ClientID={1}, CallID={2}, dateCreated='{3}', dateResolved='{4}', status='{5}', contactNum='{6}' WHERE RequestID = {0}",
                    obj.Id,
                    client.Id,
                    obj.Call.Id,
                    obj.DateCreated.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    obj.DateResolved == null ? "null" : obj.DateResolved.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    obj.Status,
                    obj.ContactNum
                 ));
            }

            dh.Dispose();


        }
    
        public void Add(RequestAgent child, Request parent) {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO agentRequestHandlers(AgentID, RequestID, ServiceID) VALUES({0}, {1}, {2})",
                child.Id,
                parent.Id,
                child.ser == null ? "null" : child.ser.Id.ToString()
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public void Remove(RequestAgent child, Request parent) {
            DataHandler dh = new DataHandler();

            dh.Delete("agentRequestHandlers", string.Format(
                "AgentID = {0} AND RequestID = {1}",
                child.Id,
                parent.Id
            ));

            dh.Dispose();
        }

        public List<RequestAgent> ReadChildren(Request parent)
        {
            DataHandler dh = new DataHandler();

            List<RequestAgent> reqAgents = new List<RequestAgent>();

            string query = "SELECT A.AgentID, A.aName, A.surname, A.contactNum, A.employmentStatus, A.employeeType, A.username, A.password, T.TechnicianID, S.ServiceID, S.sDescription, S.expectedDuration " +
                            "FROM Agent A " +
                            "LEFT OUTER JOIN agentRequestHandlers H ON A.AgentID = H.AgentID " +
                            "LEFT OUTER JOIN Service S ON S.ServiceID = H.ServiceID " +
                            "LEFT OUTER JOIN Technician T ON T.TechnicianID = A.AgentID " +
                            "WHERE H.RequestID = {0}";

            SqlDataReader read = dh.Select(string.Format(query, parent.Id));
            RequestAgent reqAgent;
            Agent agent;
            Service ser = null;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    if (!read.IsDBNull(8))
                    {
                        agent = new Technician(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4),
                            read.GetString(5),
                            read.GetString(6),
                            read.GetString(7)
                        );
                    }
                    else
                    {
                        agent = new Agent(
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetString(4),
                            read.GetString(5),
                            read.GetString(6),
                            read.GetString(7)
                        );
                    }

                    agent.Id = read.GetInt32(0);

                    if (!read.IsDBNull(9))
                    {
                        ser = new Service(read.GetString(10), read.GetInt32(11));
                        ser.Id = read.GetInt32(9);
                    }

                    reqAgent = new RequestAgent(
                        ser ?? null,
                        agent
                    );

                    reqAgents.Add(reqAgent);
                }
            }

            dh.Dispose();

            return reqAgents;
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
                    "SELECT R.ClientID, BC.name, IC.name, IC.surname, C.contactNum, C.ClientIdentifier " +
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
                while (read.Read()) 
                {
                    if (read.IsDBNull(0)) 
                    {
                        dh.Dispose();
                        return null;
                    }
                        

                    if (read.IsDBNull(1))
                    {
                        newClient = new IndividualClient(
                            read.GetString(2), 
                            read.GetString(3), 
                            read.GetString(4),
                            read.IsDBNull(5) ? null : read.GetString(5)
                        );
                    }
                    else
                    {
                        newClient = new BusinessClient(
                            read.GetString(1), 
                            read.GetString(4),
                            read.IsDBNull(5) ? null : read.GetString(5)
                        );
                    }

                    newClient.Id = read.GetInt32(0);
                }   
            }

            dh.Dispose();

            return newClient;
        }
    }
}
