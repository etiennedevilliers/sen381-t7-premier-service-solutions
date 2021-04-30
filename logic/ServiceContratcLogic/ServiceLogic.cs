using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace Logic
{
    class ServiceLogic
    {
        //Global controller object
        ServiceController S_ctr = new ServiceController();

        public void AddService(Service Ser) {

            S_ctr.Create(Ser);   
            
        }//Add a service

        public void Removeservice(Service RemoveService)
        {
            S_ctr.Delete(RemoveService);

        }//Remove service 

        public void UpdateService(Service UpdateService)
        {
            S_ctr.Update(UpdateService);

        }//Update service 

        public List<Service> ViewServices()
        {
            ServiceController S_ctr = new ServiceController();

            List<Service> returnlist = S_ctr.Read();

            return returnlist;

        }//View Service //Return a list of services



    }
}
