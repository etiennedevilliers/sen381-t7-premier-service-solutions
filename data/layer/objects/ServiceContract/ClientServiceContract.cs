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
        public DateTime? StartDate;
        public DateTime? EndDate;

        public ClientServiceContract(DateTime? StartDate, DateTime? EndDate, ServiceContract serviceContract) :
            base(serviceContract.Description, serviceContract.Cost, serviceContract.DateFinalised, serviceContract.DateTerminated, serviceContract.Status, serviceContract.identifier)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Id = serviceContract.Id;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} From: {1} To: {2}",
                 base.ToString(),
                 StartDate,
                 EndDate
            );
        }
    }
}