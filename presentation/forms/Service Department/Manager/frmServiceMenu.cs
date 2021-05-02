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
    public partial class frmServiceMenu : Form
    {
        ServiceDepartmentLogic sdLogic = new ServiceDepartmentLogic();
        GeneralLogic genLogic = new GeneralLogic();

        public frmServiceMenu()
        {
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
            List<ServiceRequest> requests = new ServiceRequestController().Read();
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
                    currentRequest = sdLogic.GetServiceRequest(i);
                    lst.SubItems.Add(currentRequest.Id.ToString());
                }

                lst.Tag = i;

                lstTechnicians.Items.Add(lst);
            }
        }

        //Requests Tab
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (sdLogic.Schedule((ServiceRequest)lstRequests.SelectedItems[0].Tag))
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
            sdLogic.CloseRequest((ServiceRequest)lstRequests.SelectedItems[0].Tag);

            LoadRequests();
        }

        //Technicians Tab
        private void btnRemove_Click(object sender, EventArgs e)
        {
            sdLogic.DeleteTechnician((Technician) lstTechnicians.SelectedItems[0].Tag);

            LoadTechnicians();
            LoadRequests();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddTechnician form = new frmAddTechnician();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                sdLogic.CreateTechnician(form.newTech, form.newSkills);
            }

            LoadTechnicians();
        }
    }
}