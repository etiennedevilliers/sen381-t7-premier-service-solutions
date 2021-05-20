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
using Logic.ServiceDepartment;

namespace Presentation.Forms.ServiceDepartment
{
    public partial class frmTechnician : Form
    {
        TechnicianLogic techLogic = new TechnicianLogic();
        ServiceRequestLogic serLogic = new ServiceRequestLogic();
        ServiceRequest currentServiceRequest;
        Technician tech;

        public frmTechnician(Agent agentLoggedIn)
        {
            tech =  techLogic.GetTechnician(agentLoggedIn);

            InitializeComponent();
        }

        private void frmViewServices_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            serLogic.UpdateRequestStatus(currentServiceRequest, "Resolved");

            if (techLogic.GetQueueDuration(tech) == 0)
            {
                tech.EmploymentStatus = "Open";
                techLogic.UpdateTechnician(tech);
            }

            LoadData();
        }

        void LoadData()
        {
            lstCurrentServices.Items.Clear();

            currentServiceRequest = techLogic.GetServiceRequest(tech);

            if (currentServiceRequest != null)
            {
                lblServiceContract.Text = "Current Service Request: " + currentServiceRequest.Description;

                List<Package> packages = currentServiceRequest.ServiceContract.Packages;
                List<Service> skills = tech.Skills;

                RequestController reqCtr = new RequestController();
                List<RequestAgent> reqAgents = reqCtr.ReadChildren(currentServiceRequest);

                List<Equipment> equipment = new ClientController().equipment.ReadChildren(currentServiceRequest.Client);

                foreach (RequestAgent i in reqAgents)
                {
                    if (i.Id == tech.Id)
                    {
                        foreach (Service j in skills)
                        {
                            if (i.ser.Equals(j))
                            {
                                ListViewItem lst = new ListViewItem( new string[]
                                {
                                    j.Description,
                                    j.ExpectedDuration.ToString()
                                });

                                lstCurrentServices.Items.Add(lst);
                            }
                        }
                    }

                    foreach (Package j in packages)
                    {
                        if (j.Service.Equals(i.ser))
                        {
                            foreach (Equipment k in equipment)
                            {
                                if (k.Category.Equals(j.Category))
                                {
                                    ListViewItem lst = new ListViewItem(new string[]
                                    {
                                        k.SerialNumber,
                                        k.Manufacturer,
                                        k.Category.Name
                                    });

                                    lstEquipment.Items.Add(lst);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                lblServiceContract.Text = "Current Service Request: None";
                btnComplete.Enabled = false;
            }
        }
    }
}
