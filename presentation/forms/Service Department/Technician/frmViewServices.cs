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
        ServiceDepartmentLogic sdLogic = new ServiceDepartmentLogic();
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
            tech = techCtr.ReadSpecific(8);
            //

            LoadData();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            currentServiceRequest.Status = "Resolved";
            RequestController rqCtr = new RequestController();
            rqCtr.Update(currentServiceRequest);

            if (sdLogic.GetQueueDuration(tech) == 0)
            {
                tech.EmploymentStatus = "Open";
                TechnicianController techCtr = new TechnicianController();
                techCtr.Update(tech);
            }

            LoadData();
        }

        void LoadData()
        {
            lstCurrentServices.Items.Clear();

            currentServiceRequest = sdLogic.GetServiceRequest(tech);

            if (currentServiceRequest == null)
            {
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
            else
            {
                //No work
            }
        }
    }
}
