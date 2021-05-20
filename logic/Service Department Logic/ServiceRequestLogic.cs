using Data.Layer.Controller;
using Data.Layer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ServiceDepartment
{
    class ServiceRequestLogic
    {
        ServiceRequestController srCtr = new ServiceRequestController();
        RequestController rqCtr = new RequestController();

        TechnicianLogic techLogic = new TechnicianLogic();

        public bool Schedule(ServiceRequest sr)
        {
            List<Package> packages = sr.ServiceContract.Packages;
            List<Technician> techs = new TechnicianController().Read();

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
                            int queueDuration = techLogic.GetQueueDuration(j);
                            int queueDurationMin = techLogic.GetQueueDuration(j);
                            if (techMin != null)
                            {
                                queueDurationMin = techLogic.GetQueueDuration(techMin);
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
                techLogic.UpdateTechnician(techMin);
                reqAgent = new RequestAgent(serMin, techMin);
                rqCtr.Add(reqAgent, sr);

                return true;
            }

            return false;
        }

        public void UpdateRequestStatus(ServiceRequest sr, string status)
        {
            sr.Status = status;
            srCtr.Update(sr);
        }

        public List<ServiceRequest> ReadServiceRequests()
        {
            return srCtr.Read();
        }
    }
}