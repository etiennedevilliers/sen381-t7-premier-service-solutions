using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;
using Logic.CustomExceptions;

namespace Logic
{
    class PackageLogic
    {
        private PackageController P_ctr = new PackageController();

        public void Addpackage(Package P)
        {
           
            P_ctr.Create(P);

        }//Add Package 

        public void RemovePackage(Package P)
        {
           
            P_ctr.Delete(P);

        }//Still need to do  //Remove package

        public void EditPackage(Package P)
        {
            PackageController P_Ctr = new PackageController();
            P_Ctr.Update(P);
        }

        public List<Package> ViewPackage()
        {

            List<Package> returnlist = P_ctr.Read();

            return returnlist;

        }//View Package 

        public void SLA_and_Service_In_Package(Package p)
        {
            int ServiceContractID;
            //later
            bool SLAPresent = false;  
            bool SPresent = false;

            List<Service> PlaceholderService = new ServiceController().Read();
            List<ServiceLevelAgreement> PlaceholderSla = new ServiceLevelAgreementController().Read();
          
            ServiceLevelAgreement slaID = PlaceholderSla[0];
            Service ServiceID = PlaceholderService[0]; 

            foreach (Service service in new ServiceController().Read())
            {
             
                if (service.Id.Equals(p.Service.Id))
                {
                    ServiceID = service;
                    SPresent = true;
                }
            }//Get service id 

            foreach (ServiceLevelAgreement SLA in new ServiceLevelAgreementController().Read())
            {
              
                if (SLA.Id.Equals(p.Sla.Id))
                {
                    slaID = SLA;
                    SLAPresent = true;
                }
            }//Get sla id
            
            if (SLAPresent == true && SPresent == true)
            {
                throw new PackageExictsException(ServiceID,slaID);
            }

            //Check if packageis in ServiceContract
           
            foreach (ServiceContract Sc in new ServiceContractController().Read())
            {
                if (Sc.Packages.Equals(p.Id))
                {
                    ServiceContractID = Sc.Id;
                }
            }
        }//Still need to do 
    }
}
