using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects
{
    
    public class Agent 
    {
        public enum EmploymentStatus {
            employed,
            unemployed
        }

        public enum EmployeeType {
            Technician,
            CallCentre,
            ClientMaintenance,
            ContractMaintenance,
            ServiceDepartment,
            ClientSatisfaction
        }

        public int ID;

        public String name;

        public String surname;
        public String primaryContact;

        public EmployeeType employeeType;
        public EmploymentStatus employmentStatus;

        public Agent (int ID, String name, String surname, String primaryContact,EmployeeType employeeType, EmploymentStatus employmentStatus) {
            this.ID = ID;
            this.name = name;
            this.surname = surname;
            this.primaryContact = primaryContact;
            this.employeeType = employeeType;
            this.employmentStatus = employmentStatus;
        }  

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Agent p = (Agent) obj;
                return p.ID.Equals(this.ID);
            }
        }

        public override int GetHashCode()
        {
            return this.ID;
        }

    }
}