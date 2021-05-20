using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class AgentController : ICreate<Agent>, IDelete<Agent>, IUpdate<Agent>, IRead<Agent>
    {
        //Basic CRUD
        public int Create(Agent obj)
        {
            DataHandler dh = new DataHandler();

            int ID = dh.InsertID(string.Format(
                "INSERT INTO Agent(aName, surname, contactNum, employmentStatus, employeeType, username, password) VALUES ('{0}','{1}','{2}','{3}', '{4}', '{5}', '{6}')",
                obj.Name,
                obj.Surname,
                obj.ContactNum,
                obj.EmploymentStatus,
                obj.EmployeeType,
                obj.Username,
                obj.Password
            ));

            obj.Id = ID;

            dh.Dispose();

            return ID;
        }

        public void Delete(Agent obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Agent", "AgentID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public void Update(Agent obj)
        {
            DataHandler dh = new DataHandler();

            dh.Update(string.Format(
                "UPDATE dbo.Agent SET aName='{1}', surname='{2}', contactNum='{3}', employmentStatus='{4}', employeeType='{5}', username='{6}', password='{7}' WHERE AgentID = {0}", 
                obj.Id,
                obj.Name,
                obj.Surname,
                obj.ContactNum,
                obj.EmploymentStatus,
                obj.EmployeeType,
                obj.Username,
                obj.Password
             ));

            dh.Dispose();
        }

        public List<Agent> Read() 
        {
            DataHandler dh = new DataHandler();

            List<Agent> agents = new List<Agent>();
            SqlDataReader read = dh.Select("SELECT AgentID, aName, surname, contactNum, employmentStatus, employeeType, username, password FROM Agent");
            Agent agent;

            if (read.HasRows)
            {
                while (read.Read())
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

                    agent.Id = read.GetInt32(0);

                    agents.Add(agent);
                }
            }

            dh.Dispose();
            return agents;
        }
    }
}