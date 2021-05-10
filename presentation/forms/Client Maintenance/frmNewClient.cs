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
using Logic;

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
            tbClientID.Text = ClientMaintenanceLogic.GenerateUniqueClientID();

        }

        public static string newcontact;
        public static string newclientname;
        public static string newclientsurname;
        public static string clientID;

        private void btnIndividualNew_Click(object sender, EventArgs e)
        {
            newcontact = txtContact.Text;
            newclientname = txtNameNewI.Text;
            newclientsurname = txtSurnameNewI.Text;
            clientID = tbClientID.Text;

            IndividualClientController individualClientController = new IndividualClientController();
            
            IndividualClient individualClient = new IndividualClient(
                newcontact,
                newclientname,
                newclientsurname,
                clientID
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

        private void button1_Click(object sender, EventArgs e)
        {
            tbClientID.Text = ClientMaintenanceLogic.GenerateUniqueClientID();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbClientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
