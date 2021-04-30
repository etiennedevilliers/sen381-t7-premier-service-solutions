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
using Data.Layer.Controller;
using Logic;


namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmServiceContract : Form
    {

        //Create gobal Service logic and service list  objects
        List<Service> List_Of_Services_Ob = new List<Service>();
        ServiceLogic Sl = new ServiceLogic();
        List<ServiceLevelAgreement> List_Of_Sla_Ob = new List<ServiceLevelAgreement>();

        public frmServiceContract()
        {
            InitializeComponent();
        }

        private void frmServiceContract_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadSLA();

        }//View list of services on load 

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            //Call the add service form 
            frmAddService form = new frmAddService();
            DialogResult res = form.ShowDialog();
            LoadServices();

        }//Show the add service form 

        public void LoadServices()
        {
            List_Of_Services_Ob = Sl.ViewServices();

            foreach (Service S in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    S.Id.ToString(),
                    S.Description,
                    S.ExpectedDuration.ToString()
               });
                lst.Tag = S;
                lstServiceView.Items.Add(lst);
            }

        }//Load the Services into the list view when form loads 

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {
            //If a item is selected in the list view perform delete 
            if (lstServiceView.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Service?", "WARNING: DELETE Service",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {

                    Service RService = lstServiceView.SelectedItems[0].Tag as Service;
                    // Parse the object to the Service logic to perform action
                    Sl.Removeservice(RService);

                    lstServiceView.Clear();

                    MessageBox.Show("Service successfully deleted", " DELETED",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Hide this form and dispay the Dialog for the Service Contract Manu
                    Hide();
                    frmServiceContract form = new frmServiceContract();
                    form.ShowDialog();
                    LoadServices();
                }

            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove a service

        private void btnServiceEdit_Click(object sender, EventArgs e)
        {

          
            if (lstServiceView.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to edit this Service?", "WARNING: Edit Service",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {
                    //Hide this form and dispay the Dialog for the Service Contract Manu

                    Service serv = lstServiceView.SelectedItems[0].Tag as Service;

                    frmEditService form = new frmEditService(serv);
                    DialogResult res = form.ShowDialog();
                    LoadServices();
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Edit a selected Service

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewSLA form = new frmNewSLA();
            Hide();
            DialogResult res = form.ShowDialog();
            LoadServices();

        }//Show the new SLA form 

        public void LoadSLA()
        {
            SLALogic Sl = new SLALogic();
            List_Of_Sla_Ob = Sl.ViewSLA();

            foreach (ServiceLevelAgreement S in List_Of_Sla_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    S.Id.ToString(),
                    S.Description,

               });
                lst.Tag = S;
                lstSLA.Items.Add(lst);
            }
        }//Load the SLA into the list view when form loads

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //If a item is selected in the list view perform delete 
            if (lstSLA.SelectedItems.Count > 0)
            {
                SLALogic SLA_L = new SLALogic();
                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this SLA?", "WARNING: DELETE SLA",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {

                    ServiceLevelAgreement RSLA = lstSLA.SelectedItems[0].Tag as ServiceLevelAgreement;
                    // Parse the object to the SLA logic to perform action
                    SLA_L.DeleteSLA(RSLA);

                    lstSLA.Clear();

                    MessageBox.Show("SLA successfully deleted", " DELETED",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Hide this form and dispay the Dialog for the Service Contract Manu
                    Hide();
                    frmServiceContract form = new frmServiceContract();
                    form.ShowDialog();
                    LoadSLA();
                }

            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove SLA

        private void btnEdit_Click(object sender, EventArgs e)
        {
     
            if (lstSLA.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to edit this SLA?", "WARNING: Edit SLA",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {
                    //Hide this form and dispay the Dialog for the Service Contract Manu

                    ServiceLevelAgreement sla = lstSLA.SelectedItems[0].Tag as ServiceLevelAgreement;
                    Hide();
                    frmEditSLA form = new frmEditSLA(sla);
                    DialogResult res = form.ShowDialog();
                    LoadServices();
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }//Edit the SLA
    }
}
