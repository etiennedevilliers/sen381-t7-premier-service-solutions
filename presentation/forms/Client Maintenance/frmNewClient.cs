using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnIndividualNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Individual Client add successful, returning to Client Menu", "INDIVIDUAL CLIENT ADDED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            frmClientMenu form = new frmClientMenu();
            form.ShowDialog();
            Show();
        }

        private void btnNewBusiness_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Business Client add successful, returning to Client Menu", " BUSINESS CLIENT ADDED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            frmClientMenu form = new frmClientMenu();
            form.ShowDialog();
            Show();
        }
    }
}
