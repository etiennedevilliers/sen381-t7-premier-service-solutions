using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Forms.ServiceDepartment;
//using Presentation.Forms.ClientMaintenance;
using Presentation.Forms.Contract_Maintenance;


namespace Presentation.Forms.Welcome
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnServiceDep_Click(object sender, EventArgs e)
        {
            Hide();
            frmServiceMenu form = new frmServiceMenu();
            form.ShowDialog();
            Show();
        }

        private void btnTechnician_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewServices form = new frmViewServices();
            form.ShowDialog();
            Show();
        }

        private void btnContractMain_Click(object sender, EventArgs e)
        {
            //Hide the current form 
            Hide();
            //Create  instance of the target form 
            //frmContractMaintenance
            frmContractMenu form = new frmContractMenu();

            //Show the target form dialog
            form.ShowDialog();

            //Show the target form 
            form.Show();
        }
    }
}
