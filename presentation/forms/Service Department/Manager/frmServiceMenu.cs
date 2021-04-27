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
        List<ServiceRequest> requests = new List<ServiceRequest>();
        List<Technician> technicians = new List<Technician>();

        ServiceRequestController rqCtr = new ServiceRequestController();
        TechnicianController tcCtr = new TechnicianController();

        public frmServiceMenu()
        {
            InitializeComponent();
        }

        private void frmServiceMenu_Load(object sender, EventArgs e)
        {
            LoadRequests();
            LoadTechnicians();
        }

        private void btnCloseRequest_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lstServices.SelectedItems[0].SubItems[0].Text);

            foreach (ServiceRequest i in requests)
            {
                if (i.Id == id)
                {
                    i.Status = "Closed";
                    rqCtr.Update(i);
                }
            }

            LoadRequests();
        }

        void LoadRequests()
        {
            lstServices.Items.Clear();
            requests = rqCtr.Read();
            Client client;
            List<Agent> handlers;
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
                        if (j is Technician)
                        {
                            technicianNames += j.Name + ", ";
                        }
                    }

                    if (technicianNames != "")
                    {
                        technicianNames = technicianNames.Substring(0, technicianNames.Length - 2);
                    }

                    lst = new ListViewItem(
                        new string[]
                        {
                        i.Id.ToString(), i.Description, i.DateCreated.ToShortDateString(), i.JobStarted.ToString(),
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

                    lstServices.Items.Add(lst);
                }
            }
        }

        void LoadTechnicians()
        {
            lstTechnicians.Items.Clear();
            technicians = tcCtr.Read();
            TechnicianHandler handler = new TechnicianHandler();
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

                if (skillSet != "")
                {
                    skillSet = skillSet.Substring(0, skillSet.Length - 2);
                }

                lst = new ListViewItem(
                        new string[]
                        {
                        i.Id.ToString(), i.Name, i.ContactNum, i.EmploymentStatus, skillSet
                        });

                if (i.EmploymentStatus == "Working")
                {
                    currentRequest = handler.GetServiceRequest(i);
                    lst.SubItems.Add(currentRequest.Id.ToString());
                }

                lstTechnicians.Items.Add(lst);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lstTechnicians.SelectedItems[0].SubItems[0].Text);

            foreach (Technician i in technicians)
            {
                if (i.Id == id)
                {
                    tcCtr.Delete(i);
                }
            }

            LoadTechnicians();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddTechnician form = new frmAddTechnician();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                Technician tech = form.newTech;

                tcCtr.Create(tech);

                foreach (Service i in form.newSkills)
                {
                    tcCtr.Add(i, tech);
                }
            }

            LoadTechnicians();
        }
    }
}