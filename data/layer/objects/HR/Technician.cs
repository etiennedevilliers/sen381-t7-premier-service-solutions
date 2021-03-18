using System;
using System.Collections.Generic;
using System.Text;

namespace sen381_t7_premier_service_solutions.data.layer.objects
{
    
    public class Technician : Agent
    {
        /// public List<Service> skills;

        public Technician (String name, String surname, String primaryContact, EmploymentStatus employmentStatus) 
            : base(name, surname, primaryContact, EmployeeType.Technician, employmentStatus) {

        }  

    }
}