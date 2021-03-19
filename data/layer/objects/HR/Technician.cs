using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions
{
    
    public class Technician : Agent
    {
        public List<Service> skills;

        public Technician (int ID, String name, String surname, String primaryContact, EmploymentStatus employmentStatus, List<Service> skills) 
            : base(ID, name, surname, primaryContact, EmployeeType.Technician, employmentStatus) {
            this.skills = skills;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}