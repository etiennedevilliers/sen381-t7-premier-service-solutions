using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Objects;
using Data.Layer.Controller;

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
            SLA_Ctr.Delete(SLA);
        }

        //Insert 
        public void AddSLA(ServiceLevelAgreement SLA)
        {
            SLA_Ctr.Create(SLA);
        }

    }
}
