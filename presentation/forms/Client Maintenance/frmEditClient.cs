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
    public partial class frmEditClient : Form
    {
        public frmEditClient()
        {
            InitializeComponent();
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            Boolean isIndividuale = frmClientMenu.Individual;
            Boolean isBusinesse = frmClientMenu.Business;

            if (isIndividuale)
            {
                TabPage tab = tpcEditClient.TabPages[0];
                //tpcNewClient.SelectTab(tab);
                tpcEditClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 0;
                //tpgIndividualNew.Show();
                //tpgBusinessNew.Hide();
            }
            else
            {
                TabPage tab = tpcEditClient.TabPages[1];
                //tpcNewClient.SelectTab(tab);
                tpcEditClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 1;
                //tpgBusinessNew.Show();
                //tpgIndividualNew.Hide();
            }
        }

        public static string name;
        public static string surname; 

        private void btnIndividualEdit_Click(object sender, EventArgs e)
        {
            name = txtNameEditI.Text;
            surname = txtSurnameEditI.Text; 

            MessageBox.Show("Individual Client edit successful, returning to Client Menu", "INDIVIDUAL CLIENT EDITED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            frmClientMenu form = new frmClientMenu();
            form.ShowDialog();
            Show();
        }

        public static string busiName;

        private void btnEditBusiness_Click(object sender, EventArgs e)
        {
            busiName = txtBusinessNameEdit.Text; 

            MessageBox.Show("Business Client edit successful, returning to Client Menu", "BUSINESS CLIENT EDITED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            frmClientMenu form = new frmClientMenu();
            form.ShowDialog();
            Show();
        }
    }
}
