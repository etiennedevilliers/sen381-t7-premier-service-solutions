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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmNewBusinessClient : Form
    {
        public frmNewBusinessClient()
        {
            InitializeComponent();
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
