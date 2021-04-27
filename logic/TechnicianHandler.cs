using Data.Layer.Controller;
using Data.Layer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class TechnicianHandler
    {
        public ServiceRequest GetServiceRequest(Technician tech)
        {
            ServiceRequestController srCtr = new ServiceRequestController();
            List<ServiceRequest> requests = srCtr.Read();

            foreach (ServiceRequest i in requests)
            {
                if (i.Status == "Open")
                {
                    List<Agent> handlers = i.Handlers;

                    foreach (Agent j in handlers)
                    {
                        if (j.Id == tech.Id)
                        {
                            return i;
                        }
                    }
                }
            }

            return null;
        }
    }
}
