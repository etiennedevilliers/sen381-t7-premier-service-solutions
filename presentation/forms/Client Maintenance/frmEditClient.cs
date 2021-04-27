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

        public static string contactNumEdit;
        public static string nameEdit;
        public static string surnameEdit; 

        private void btnIndividualEdit_Click(object sender, EventArgs e)
        {
            contactNumEdit = txtContactEdI.Text;
            nameEdit = txtNameEditI.Text;
            surnameEdit = txtSurnameEditI.Text;

            IndividualClientController individualClientController = new IndividualClientController();
            IndividualClient individualClient = new IndividualClient(
                contactNumEdit,
                nameEdit,
                surnameEdit
                );

            if (contactNumEdit.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nameEdit.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (surnameEdit.Equals(""))
            {
                MessageBox.Show("Please enter a client surname", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                individualClientController.Update(individualClient);

                MessageBox.Show("Individual Client edit successful, returning to Client Menu", "INDIVIDUAL CLIENT EDITED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }

            

            
        }

        public static string busicontactEdit;
        public static string busiNameEdit;

        private void btnEditBusiness_Click(object sender, EventArgs e)
        {
            busicontactEdit = txtContactEdB.Text;
            busiNameEdit = txtBusinessNameEdit.Text;

            BusinessClientController businessClientController = new BusinessClientController();

            BusinessClient businessClient = new BusinessClient(
                busicontactEdit,
                busiNameEdit
                );


            if (busicontactEdit.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (busiNameEdit.Equals(""))
            {
                MessageBox.Show("Please enter a business name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                businessClientController.Update(businessClient);

                MessageBox.Show("Business Client edit successful, returning to Client Menu", "BUSINESS CLIENT EDITED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }

            
        }
    }
}
