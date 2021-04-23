using System;
using System.Collections.Generic;
using System.Text;
using Data.Layer.Access;
using Data.Layer.Objects;
using System.Data.SqlClient;

namespace Data.Layer.Controller
{
    class TechnicianController : ICreate<Technician>, IRead<Technician>, IReadSpecific<Technician>, IUpdate<Technician>, IDelete<Technician>, IChildren<Service, Technician>
    {
        //Basic CRUD
        public int Create(Technician obj)
        {
            AgentController agentController = new AgentController();
            obj.Id = agentController.Create(obj);

            DataHandler dh = new DataHandler();

            dh.Insert(string.Format(
                        "INSERT INTO Technician(TechnicianID)" +
                        "VALUES ({0})",
                        obj.Id
                    ));

            dh.Dispose();

            return obj.Id;
        }

        public void Delete(Technician obj)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("Technician", "TechnicianID = " + obj.Id.ToString());

            dh.Dispose();
        }

        public List<Technician> Read()
        {
            DataHandler dh = new DataHandler();

            List<Technician> technicians = new List<Technician>();

            string query = "SELECT A.AgentID, A.aName, A.ContactNum, A.employmentStatus, A.employeeType " + 
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

                    technician.Id = read.GetInt32(0);

                    technicians.Add(technician);
                }
            }
            dh.Dispose();

            return technicians;
        }

        public Technician ReadSpecific(int ID)
        {
            DataHandler dh = new DataHandler();

            SqlDataReader read = dh.Select(string.Format(
                "SELECT A.aName, A.ContactNum, A.employmentStatus, A.employeeType " +
                "FROM Technician AS T " +
                "LEFT JOIN Agent AS A ON A.AgentID = T.TechnicianID " +
                "WHERE TechnicianID = {0}", ID
            ));
            Technician tech = null;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    tech = new Technician(
                        read.GetString(0),
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3)
                    );

                    tech.Id = ID;
                }
            }
            dh.Dispose();

            return tech;
        }

        public void Update(Technician obj)
        {
            DataHandler dh = new DataHandler();

            /*dh.Update(string.Format(
                    "UPDATE dbo.Technician " + 
                    "WHERE TechnicianID = {0}",
                    obj.name, obj.contactNum, obj.employmentStatus, obj.employeeType
                )); */

            dh.Dispose();

            AgentController agentController = new AgentController();
            agentController.Update(obj);
        }

        //Child CRUD
        public void Add(Service child, Technician parent)
        {
            DataHandler dh = new DataHandler();

            string query = string.Format(
                "INSERT INTO technicianServiceSkills(ServiceID, TechnicianID) VALUES({0}, {1})",
                child.Id,
                parent.Id
            );
            dh.Insert(query);

            dh.Dispose();
        }

        public void Remove(Service child, Technician parent)
        {
            DataHandler dh = new DataHandler();

            dh.Delete("technicianServiceSkills", string.Format(
                "ServiceID = {0} AND TechnicianID = {1}",
                child.Id,
                parent.Id
            ));

            dh.Dispose();
        }

        public List<Service> ReadChildren(Technician parent)
        {
            DataHandler dh = new DataHandler();

            List<Service> services = new List<Service>();

            string query = "SELECT S.ServiceID, sDescription, expectedDuration " +
                           "FROM Service AS S " +
                           "LEFT JOIN technicianServiceSkills AS SS ON S.ServiceID = SS.ServiceID " +
                           "WHERE SS.TechnicianID = {0}";

            SqlDataReader read = dh.Select(string.Format(query, parent.Id));
            Service service;

            if (read.HasRows)
            {
                while (read.Read())
                {
                    service = new Service(
                        read.GetString(1),
                        read.GetInt32(2)
                    );

                    service.Id = read.GetInt32(0);

                    services.Add(service);
                }
            }
            dh.Dispose();
            return services;
        }
    }
}