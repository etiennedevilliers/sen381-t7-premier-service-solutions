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
    class SLALogic
    {
        //Global controller object
        ServiceLevelAgreementController SLA_Ctr = new ServiceLevelAgreementController();

        //View 
        public List<ServiceLevelAgreement> ViewSLA()
        {

            List<ServiceLevelAgreement> returnlist = SLA_Ctr.Read();

            return returnlist;

        }//View Service //Return a list of services

        //Update 
        public void UpdateSla(ServiceLevelAgreement SLA)
        {
            SLA_Ctr.Update(SLA);
        }

        //Delete 
        public void DeleteSLA(ServiceLevelAgreement SLA)
        {
            //Call SLA  If SLA Exiss then throw Exception before Deleting 
            SLA_Ctr.Delete(SLA);
      
        }

        //Insert 
        public void AddSLA(ServiceLevelAgreement SLA)
        {
            SLA_Ctr.Create(SLA);
        }

        public void SLAInPackage(ServiceLevelAgreement SLA)
        {
            foreach (Package package in new PackageController().Read())
            {
                if (package.Sla.Equals(SLA))
                {
                    throw new SLAExistsException(package);

                } 
            }
        }//Check if service is in packages

    }
}
