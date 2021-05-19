using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Objects
{
    public class RequestAgent : Agent
    {
        public Service ser;

        public RequestAgent(Service ser, Agent agent) : base(agent.Name, agent.Surname, agent.ContactNum, agent.EmploymentStatus, agent.EmployeeType, agent.Username, agent.Password)
        {
            this.ser = ser;

            Id = agent.Id;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} With: {1}",
                 base.ToString(),
                 ser.ToString()
            );
        }
    }
}
