using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmClientMenu : Form
    {
        
        public frmClientMenu()
        {
            InitializeComponent();
        }

        private void frmClientMenu_Load(object sender, EventArgs e)
        {
            DBAccess dBAccess = new DBAccess();

        }

        private void tpgIndividualClients_Click(object sender, EventArgs e)
        {

        }

        public static Boolean Individual;

        private void btnAddI_Click(object sender, EventArgs e)
        {
            Individual = true;

            Hide();
            frmNewClient form = new frmNewClient();
            form.ShowDialog();
            Show();


        }

        private void btnEditI_Click(object sender, EventArgs e)
        {
            Individual = true;

            Hide();
            frmEditClient form = new frmEditClient();
            form.ShowDialog();
            Show();
        }

        public static Boolean Business;

        private void btnAddB_Click(object sender, EventArgs e)
        {
            Business = true;

            Hide();
            frmNewClient form = new frmNewClient();
            form.ShowDialog();
            Show();

        }

        private void btnEditB_Click(object sender, EventArgs e)
        {
            Business = true;

            Hide();
            frmEditClient form = new frmEditClient();
            form.ShowDialog();
            Show();
        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteI == DialogResult.Yes)
            {
                MessageBox.Show("Client successfully deleted", "CLIENT DELETED",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Client NOT deleted", "CLIENT UNCHANGED",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            DialogResult deleteB = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deleteB == DialogResult.Yes)
            {
                MessageBox.Show("Client successfully deleted", "CLIENT DELETED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Client NOT deleted", "CLIENT UNCHANGED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnViewContractI_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewContract form = new frmViewContract();
            form.ShowDialog();
            Show();
        }

        private void btnViewContractB_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewContract form = new frmViewContract();
            form.ShowDialog();
            Show();
        }

        private void btnAssignEmployeeB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee assigned to client", "EMPLOYEE ASSIGNED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
