using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic
{
    class Scheduler
    {
        public void Schedule(Technician tech)
        {
            ServiceRequestController ctr = new ServiceRequestController();
            List<ServiceRequest> requests = ctr.Read();
            List<Service> skills = tech.Skills;

            foreach (ServiceRequest i in requests)
            {
                if (i.Status == "Open")
                {
                    List<Package> packages = i.ServiceContract.Packages;

                    foreach (Package j in packages)
                    {
                        foreach (Service k in skills)
                        {
                            if (j.Service.Id == k.Id)
                            {
                                tech.EmploymentStatus = "Working";
                                i.Handlers.Add(tech);
                                new RequestController().Add(tech, i);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}