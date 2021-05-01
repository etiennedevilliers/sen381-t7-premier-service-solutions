using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Data.Layer.Objects;

namespace Logic.CustomExceptions
{ 

    [Serializable]
    class PackageExictsException : Exception
    {

        //Create a constructor for this class with a error message parameter


        ServiceLevelAgreement SLA;
        Service Service;

        public PackageExictsException(Service service, ServiceLevelAgreement sla) : base(string.Format("Service Level Agremnet{0} and Service{1} exist in Package {0}", sla.Id, service.Id))
        {
            this.SLA = sla;
            this.Service = service;
        }

    }
}
