using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Controller;
using Data.Layer.Objects;
using Logic;

namespace Presentation.Forms.ServiceDepartment
{
    public partial class frmViewServices : Form
    {
        ServiceRequest currentServiceRequest;
        Technician tech;

        public frmViewServices()
        {
            InitializeComponent();
        }

        private void frmViewServices_Load(object sender, EventArgs e)
        {
            //To be replaced with login
            TechnicianController techCtr = new TechnicianController();
            tech = techCtr.ReadSpecific(7);
            //

            TechnicianHandler handler = new TechnicianHandler();
            currentServiceRequest = handler.GetServiceRequest(tech);

            List<Package> packages = currentServiceRequest.ServiceContract.Packages;
            List<Service> skills = tech.Skills;

            foreach (Package i in packages)
            {
                foreach (Service j in skills)
                {
                    if (i.Service.Id == j.Id)
                    {
                        lstCurrentServices.Items.Add(i.Service.Description);
                    }
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Update Request status

            Scheduler sch = new Scheduler();
            sch.Schedule(tech);
        }
    }
}
