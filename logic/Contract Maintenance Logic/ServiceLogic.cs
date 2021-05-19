using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;
using Logic.CustomExceptions;

namespace Logic.ContractMaintenance
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
            S_ctr.Delete(RemoveService);//Actually delete the Service

        }//Remove service 

        public bool ServiceInPackage(Service SER)
        {
            bool Found = false;
            foreach (Package package in new PackageController().Read())
            {
                if (package.Service.Equals(SER))
                {
                    Found = true;
                    throw new ServiceExistsException(package);
                }
             
            }
            return Found;
        }//Check if SLA is in a Package 

        public void UpdateService(Service UpdateService)
        {
            S_ctr.Update(UpdateService);

        }//Update service 

        public List<Service> GetServices()
        {
            ServiceController S_ctr = new ServiceController();

            List<Service> returnlist = S_ctr.Read();

            return returnlist;

        }//View Service //Return a list of services

    }

   
}
