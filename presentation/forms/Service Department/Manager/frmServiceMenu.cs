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

namespace Presentation.Forms.ServiceDepartment
{
    public partial class frmServiceMenu : Form
    {
        List<ServiceRequest> requests = new List<ServiceRequest>();
        ServiceRequestController ctr = new ServiceRequestController();

        public frmServiceMenu()
        {
            InitializeComponent();
        }

        private void frmServiceMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCloseRequest_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lstServices.SelectedItems[0].SubItems[0].Text);

            foreach (ServiceRequest i in requests)
            {
                if (i.Id == id)
                {
                    i.Status = "Closed";
                    ctr.Update(i);
                }
            }

            LoadData();
        }

        void LoadData()
        {
            lstServices.Items.Clear();
            requests = ctr.Read();

            foreach (ServiceRequest i in requests)
            {
                if (i.Status == "Open")
                {
                    Client client = i.Client;
                    List<Agent> handlers = i.Handlers;
                    string technicianNames = "";

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

                    ListViewItem lst = new ListViewItem(
                        new string[]
                        {
                        i.Id.ToString(), i.Description, i.DateCreated.ToShortDateString(), i.JobStarted.ToShortDateString(),
                        i.DateResolved.ToShortDateString(), i.Call.TimeStarted.ToLongTimeString(), i.Call.TimeEnded.ToLongTimeString(), technicianNames
                        });

                    if (client is IndividualClient)
                    {
                        IndividualClient ind = (IndividualClient)client;
                        lst.SubItems.Add(ind.Name);
                    }
                    else if (client is BusinessClient)
                    {
                        BusinessClient bus = (BusinessClient)client;
                        lst.SubItems.Add(bus.Name);
                    }

                    lstServices.Items.Add(lst);
                }
            }
        }
    }
}