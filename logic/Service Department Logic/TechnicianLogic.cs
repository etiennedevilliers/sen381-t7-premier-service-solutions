using Data.Layer.Controller;
using Data.Layer.Objects;
using Logic.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ServiceDepartment
{
    class TechnicianLogic
    {
        TechnicianController techCtr = new TechnicianController();
        ServiceRequestController srCtr = new ServiceRequestController();
        RequestController rqCtr = new RequestController();

        GeneralLogic genLogic = new GeneralLogic();

        public void DeleteTechnician(Technician tech)
        {
            //Delete Children

            techCtr.Delete(tech);
        }

        public void CreateTechnician(Technician tech, List<Service> skills)
        {
            techCtr.Create(tech);

            foreach (Service i in skills)
            {
                techCtr.Add(i, tech);
            }
        }

        public void UpdateTechnician(Technician tech, List<Service> newSkills, List<Service> oldSkills)
        {
            techCtr.Update(tech);

            foreach (Service i in genLogic.GetAddedItems(oldSkills, newSkills))
            {
                techCtr.Add(i, tech);
            }

            foreach (Service i in genLogic.GetRemovedItems(oldSkills, newSkills))
            {
                techCtr.Remove(i, tech);
            }
        }

        public void UpdateTechnician(Technician tech)
        {
            techCtr.Update(tech);
        }

        SortedDictionary<DateTime, ServiceRequest> GetQueue(Technician tech)
        {
            SortedDictionary<DateTime, ServiceRequest> queue = new SortedDictionary<DateTime, ServiceRequest>();

            List<ServiceRequest> requests = srCtr.Read();

            foreach (ServiceRequest i in requests)
            {
                if (i.Status == "Open")
                {
                    List<RequestAgent> handlers = i.Handlers;

                    foreach (Agent j in handlers)
                    {
                        if (j.Id == tech.Id)
                        {
                            queue.Add(i.DateCreated, i);
                        }
                    }
                }
            }

            return queue;
        }

        public int GetQueueDuration(Technician tech)
        {
            SortedDictionary<DateTime, ServiceRequest> queue = GetQueue(tech);

            int dur = 0;

            foreach (ServiceRequest i in queue.Values)
            {
                List<Package> packages = i.ServiceContract.Packages;
                List<RequestAgent> reqAgents = rqCtr.ReadChildren(i);

                foreach (RequestAgent j in reqAgents)
                {
                    foreach (Package k in packages)
                    {
                        if (j.ser.Id == k.Service.Id)
                        {
                            dur += k.Service.ExpectedDuration;
                        }
                    }
                }
            }

            return dur;
        }

        public ServiceRequest GetServiceRequest(Technician tech)
        {
            SortedDictionary<DateTime, ServiceRequest> queue = GetQueue(tech);
            if (queue.Count > 0)
            {
                return (ServiceRequest) queue.Values.ToArray().GetValue(0);
            }
            else
            {
                return null;
            }
        }

        public Technician GetTechnician(Agent agent)
        {
            return techCtr.ReadSpecific(agent.Id);
        }
    }
}
