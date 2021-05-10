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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmNewBusinessClient : Form
    {
        public frmNewBusinessClient()
        {
            InitializeComponent();
            tbClientID.Text = ClientMaintenanceLogic.GenerateUniqueClientID();
        }

        public static string newbusicontact;
        public static string newbusinessclient;
        public static string clientID;

        private void btnNewBusiness_Click(object sender, EventArgs e)
        {
            newbusicontact = txtnewbusicontact.Text;
            newbusinessclient = txtBusinessNameNew.Text;
            clientID = tbClientID.Text;

            BusinessClientController businessClientController = new BusinessClientController();

            BusinessClient businessClient = new BusinessClient(
                newbusicontact,
                newbusinessclient,
                clientID
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

        private void button1_Click(object sender, EventArgs e)
        {
            tbClientID.Text = ClientMaintenanceLogic.GenerateUniqueClientID();
        }
    }
}
