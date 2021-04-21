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
                "INSERT INTO Agent(aName, contactNum, employmentStatus, employeeType) VALUES ('{0}','{1}','{2}','{3}')",
                obj.Name,
                obj.ContactNum,
                obj.EmploymentStatus,
                obj.EmployeeType
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
                "UPDATE dbo.Request SET aName='{1}', contactNum='{2}', employmentStatus='{3}', employeeType='{4}' WHERE AgentID = {0}", 
                obj.Id,
                obj.Name,
                obj.ContactNum,
                obj.EmploymentStatus,
                obj.EmployeeType
             ));

            dh.Dispose();
        }

        public List<Agent> Read() 
        {
            DataHandler dh = new DataHandler();

            List<Agent> agents = new List<Agent>();
            SqlDataReader read = dh.Select("SELECT AgentID, aName, contactNum, employmentStatus, employeeType FROM Agent");
            Agent agent;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    agent = new Agent(
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3),
                        read.GetString(4)
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