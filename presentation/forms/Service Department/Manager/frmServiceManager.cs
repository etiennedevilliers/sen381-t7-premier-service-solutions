using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Objects;
using Logic.ServiceDepartment;
using Logic.General;
using Data.Layer.Controller;

namespace Presentation.Forms.ServiceDepartment
{
    public partial class frmServiceManager : Form
    {
        ServiceRequestLogic serLogic = new ServiceRequestLogic();
        TechnicianLogic techLogic = new TechnicianLogic();
        GeneralLogic genLogic = new GeneralLogic();
        Agent agentLoggedIn;

        public frmServiceManager(Agent agentLoggedIn)
        {
            this.agentLoggedIn = agentLoggedIn;

            InitializeComponent();
        }

        private void frmServiceMenu_Load(object sender, EventArgs e)
        {
            LoadRequests();
            LoadTechnicians();
        }

        void LoadRequests()
        {
            lstRequests.Items.Clear();
            List<ServiceRequest> requests = serLogic.ReadServiceRequests();
            Client client;
            List<RequestAgent> handlers;
            string technicianNames;
            IndividualClient ind;
            BusinessClient bus;
            ListViewItem lst;

            foreach (ServiceRequest i in requests)
            {
                if (i.Status == "Open" || i.Status == "Resolved")
                {
                    client = i.Client;
                    handlers = i.Handlers;
                    technicianNames = "";

                    foreach (Agent j in handlers)
                    {
                        if (j.EmployeeType == "Technician")
                        {
                            technicianNames += j.Name + ", ";
                        }
                    }

                    technicianNames = genLogic.TruncList(technicianNames);

                    lst = new ListViewItem(
                        new string[]
                        {
                            i.Description, i.DateCreated.ToShortDateString(), i.JobStarted.ToString(),
                            i.DateResolved.ToString(), i.Call.TimeStarted.ToLongTimeString(), i.Call.TimeEnded.ToLongTimeString(), technicianNames
                        });

                    if (client is IndividualClient)
                    {
                        ind = (IndividualClient) client;
                        lst.SubItems.Add(ind.Name);
                    }
                    else if (client is BusinessClient)
                    {
                        bus = (BusinessClient) client;
                        lst.SubItems.Add(bus.Name);
                    }
                    lst.SubItems.Add(i.Status);

                    lst.Tag = i;

                    lstRequests.Items.Add(lst);
                }
            }
        }

        void LoadTechnicians()
        {
            lstTechnicians.Items.Clear();
            List<Technician> technicians = new TechnicianController().Read();
            ServiceRequest currentRequest;
            List<Service> skills;
            string skillSet;
            ListViewItem lst;

            foreach (Technician i in technicians)
            {
                skills = i.Skills;
                skillSet = "";

                foreach (Service j in skills)
                {
                    skillSet += j.Description + ", ";
                }

                skillSet = genLogic.TruncList(skillSet);

                lst = new ListViewItem(
                        new string[]
                        {
                            i.Name, i.ContactNum, i.EmploymentStatus, skillSet
                        });

                if (i.EmploymentStatus == "Working")
                {
                    currentRequest = techLogic.GetServiceRequest(i);
                    lst.SubItems.Add(currentRequest.Id.ToString());
                }

                lst.Tag = i;

                lstTechnicians.Items.Add(lst);
            }
        }

        //Requests Tab
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (serLogic.Schedule((ServiceRequest)lstRequests.SelectedItems[0].Tag))
            {
                MessageBox.Show("Technicians Successfully Scheduled");
            }
            else
            {
                MessageBox.Show("Technicians Not Scheduled");
            }

            LoadRequests();
            LoadTechnicians();
        }

        private void btnCloseRequest_Click(object sender, EventArgs e)
        {
            serLogic.UpdateRequestStatus((ServiceRequest)lstRequests.SelectedItems[0].Tag, "Closed");

            LoadRequests();
        }

        //Technicians Tab
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddTechnician form = new frmAddTechnician();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                techLogic.CreateTechnician(form.newTech, form.newSkills);
            }

            LoadTechnicians();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Technician tech = (Technician) lstTechnicians.SelectedItems[0].Tag;
            List<Service> skills = tech.Skills;

            frmEditTechnician form = new frmEditTechnician(tech, skills);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                techLogic.UpdateTechnician(form.tech, form.skills, skills);
            }

            LoadTechnicians();
        }
    }
}