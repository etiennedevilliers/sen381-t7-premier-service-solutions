using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            InitializeComponent();
        }


        
        private void frmNewClient_Load(object sender, EventArgs e)
        {
            IndividualClientController individualClientController = new IndividualClientController();
            BusinessClientController businessClientController = new BusinessClientController();

            Boolean isIndividual = frmClientMenu.Individual;
            Boolean isBusiness = frmClientMenu.Business;

            if (isIndividual)
            {
                TabPage tab = tpcNewClient.TabPages[0];
                //tpcNewClient.SelectTab(tab);
                tpcNewClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 0;
                //tpgIndividualNew.Show();
                //tpgBusinessNew.Hide();
            }
            else
            {
                TabPage tab = tpcNewClient.TabPages[1];
                //tpcNewClient.SelectTab(tab);
                tpcNewClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 1;
                //tpgBusinessNew.Show();
                //tpgIndividualNew.Hide();
            }
        }

        public static string newcontact;
        public static string newclientname;
        public static string newclientsurname;

        private void btnIndividualNew_Click(object sender, EventArgs e)
        {
            newcontact = txtContact.Text;
            newclientname = txtNameNewI.Text;
            newclientsurname = txtSurnameNewI.Text;

            IndividualClientController individualClientController = new IndividualClientController();
            
            IndividualClient individualClient = new IndividualClient(
                newcontact,
                newclientname,
                newclientsurname
                );


            if (newcontact.Equals(""))
            {
                MessageBox.Show("Please enter client contact details", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newclientname.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newclientsurname.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                individualClientController.Create(individualClient);

                MessageBox.Show("Individual Client add successful, returning to Client Menu", "INDIVIDUAL CLIENT ADDED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }


        }

        public static string newbusicontact;
        public static string newbusinessclient;

        private void btnNewBusiness_Click(object sender, EventArgs e)
        {
            newbusicontact = txtnewbusicontact.Text;
            newbusinessclient = txtBusinessNameNew.Text;

            BusinessClientController businessClientController = new BusinessClientController();

            BusinessClient businessClient = new BusinessClient(
                newbusicontact,
                newbusinessclient
                );


            if (newbusicontact.Equals(""))
            {
                MessageBox.Show("Please enter business contact details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newbusinessclient.Equals(""))
            {
                MessageBox.Show("Please enter a business client name", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                businessClientController.Create(businessClient);

                MessageBox.Show("Business Client add successful, returning to Client Menu", " BUSINESS CLIENT ADDED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }
            
        }

    }
}
