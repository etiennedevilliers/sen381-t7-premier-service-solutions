using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer.Controller;

namespace Data.Layer.Objects
{ 
    public class ClientServiceContract : ServiceContract
    {
        public ClientServiceContract(DateTime? StartDate, DateTime? EndDate, ServiceContract serviceContract) :
            base(serviceContract.Description, serviceContract.Cost, serviceContract.DateFinalised, serviceContract.DateTerminated, serviceContract.Status)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Id = serviceContract.Id;
            this.identifier = serviceContract.identifier;

        }

        public DateTime? StartDate;
        public DateTime? EndDate;

        public override string ToString()
        {
            return String.Format(
                "{0} From: {1} To: {2}",
                 base.ToString(),
                 StartDate,
                 EndDate
            );
        }
    }
}
