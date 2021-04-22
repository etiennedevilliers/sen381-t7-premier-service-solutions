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
        public frmServiceMenu()
        {
            InitializeComponent();
        }

        private void frmServiceMenu_Load(object sender, EventArgs e)
        {
            ServiceRequestController ctr = new ServiceRequestController();
            List<ServiceRequest> requests = ctr.Read();

            foreach (ServiceRequest i in requests)
            {
                IndividualClient client = (IndividualClient) i.Client;
                if (client != null)
                {
                    ListViewItem lst = new ListViewItem(
                        new string[] { i.Description, i.DateCreated.ToString(), i.JobStarted.ToString(),
                                    i.DateResolved.ToString(), client.GetType().ToString(),
                                    i.Call.TimeStarted.ToString(), i.Call.TimeEnded.ToString() });
                    lstServices.Items.Add(lst);
                }
            }
        }
    }
}