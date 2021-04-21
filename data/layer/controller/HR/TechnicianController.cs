using System;
using System.Collections.Generic;
using System.Text;
using data.layer.access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace data.layer.controller
{
    class TechnicianController : ICreate<Technician>, IRead<Technician>, IUpdate<Technician>, IDelete<Technician>
    {
        
        
        public int Create(Technician obj)
        {
            AgentController agentController = new AgentController();
            int agentid = agentController.Create(obj);

            DataHandler dh = new DataHandler();

            dh.Insert(string.Format(
                        "INSERT INTO Technician(TechnicianID)" +
                        "VALUES ({0})",
                        obj.id
                    ));

            dh.Dispose();

            return obj.id;
        }

        public void Delete(Technician obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Technician", "TechnicianID = " + obj.id.ToString());

            dh.Dispose();
        }

        public List<Technician> Read()
        {
            DataHandler dh = new DataHandler();

            List<Technician> technicians = new List<Technician>();


            String query = "SELECT A.AgentID, A.aName, A.ContactNum, A.employmentStatus, A.employeeType " + 
                            "FROM Technician AS T " + 
                                "LEFT JOIN Agent AS A " + 
                                    "ON A.AgentID = T.TechnicianID";
                
            SqlDataReader read = dh.Select(query);
            Technician technician ;

            if (read.HasRows)
            {
                while (read.Read())
                {

                    technician = new Technician(
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3),
                        read.GetString(4)
                    );

                    technician.id = read.GetInt32(0);

                    technicians.Add(technician);
                }
            }
            dh.Dispose();

            return technicians;

                     
        }

        public void Update(Technician obj)
        {
            DataHandler dh = new DataHandler();

           /* dh.Update(string.Format(
                    "UPDATE dbo.Technician " + 
                    "WHERE TechnicianID = {0}",
                    obj.name, obj.contactNum, obj.employmentStatus, obj.employeeType
                )); */

            dh.Dispose();

            AgentController agentController = new AgentController();
            agentController.Update(obj);
           
        }
        
    }
}