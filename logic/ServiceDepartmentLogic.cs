using Data.Layer.Controller;
using Data.Layer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class ServiceDepartmentLogic
    {
        TechnicianController techCtr = new TechnicianController();
        ServiceRequestController srCtr = new ServiceRequestController();
        RequestController rqCtr = new RequestController();

        public bool Schedule(ServiceRequest sr)
        {
            TechnicianController techCtr = new TechnicianController();

            List<Package> packages = sr.ServiceContract.Packages;
            List<Technician> techs = techCtr.Read();

            Technician techMin = null;
            Service serMin = null;
            RequestAgent reqAgent;
            List<Service> skills;

            foreach (Package i in packages)
            {
                foreach (Technician j in techs)
                {
                    skills = j.Skills;

                    foreach (Service k in skills)
                    {
                        if (k.Equals(i.Service))
                        {
                            int queueDuration = GetQueueDuration(j);
                            int queueDurationMin = GetQueueDuration(j);
                            if (techMin != null)
                            {
                                queueDurationMin = GetQueueDuration(techMin);
                            }

                            if (queueDuration <= queueDurationMin)
                            {
                                techMin = j;
                                serMin = k;
                            }
                        }
                    }
                }

                if (techMin == null)
                {
                    return false;
                }

                techMin.EmploymentStatus = "Working";
                techCtr.Update(techMin);
                reqAgent = new RequestAgent(serMin, techMin);
                rqCtr.Add(reqAgent, sr);

                return true;
            }

            return false;
        }

        public void CloseRequest(ServiceRequest sr)
        {
            sr.Status = "Closed";
            srCtr.Update(sr);
        }

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

        public void EditTechnician(Technician tech, List<Service> skills)
        {

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
    }
}