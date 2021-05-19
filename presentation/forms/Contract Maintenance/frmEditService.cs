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
using Logic.ContractMaintenance;

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmEditService : Form
    {

        private Service service;
        //Create gobal Service logic and service list  objects
        List<Service> List_Of_Services_Ob = new List<Service>();
        private ServiceLogic Sl = new ServiceLogic();

        public string description;
        public int duration;

        public frmEditService(Service service)
        {
            InitializeComponent();
            this.service = service;

            txtDescription.Text = service.Description;
            txtDuration.Text = service.ExpectedDuration.ToString();
        }

        private void frmEditService_Load(object sender, EventArgs e)
        {
            loadList();

        }//Populate the list of Service objects

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Here we call from the Service logic

            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Please enter updated service description details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data validation
            if (txtDuration.Text.Equals(""))//Data Validation
            {
                MessageBox.Show("Please enter updated service duration details", "EMPTY FIELDS!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data Validation
            else
            {
               
                this.service.Description = txtDescription.Text;
                this.service.ExpectedDuration = int.Parse(txtDuration.Text);

                Sl.UpdateService(this.service);
                MessageBox.Show("Service successfully Updated", " Edit",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }//End of Else

        }//Update service

     void loadList()
        {
            // Display the services
            List_Of_Services_Ob = Sl.GetServices();

            foreach (Service S in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
                {
                    S.Id.ToString(),
                    S.Description,
                    S.ExpectedDuration.ToString()
                });

                lst.Tag = S;
            }
        }//Load the services from Service logic
    }
}
