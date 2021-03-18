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

        public String name;
        public String surname;
        public String primaryContact;

        public EmployeeType employeeType;
        public EmploymentStatus employmentStatus;

        public Agent (String name, String surname, String primaryContact,EmployeeType employeeType, EmploymentStatus employmentStatus) {
            this.name = name;
            this.surname = surname;
            this.primaryContact = primaryContact;
            this.employeeType = employeeType;
            this.employmentStatus = employmentStatus;
        }  

    }
}