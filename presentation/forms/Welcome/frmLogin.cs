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
using Presentation.Forms.CallCentre;
using sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance;

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

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNewRequest.OpenRequest();
            Show();
          
        }

        private void btnClientMain_Click(object sender, EventArgs e)
        {
            Hide();
            frmClientMenu form = new frmClientMenu();
            form.ShowDialog();
            Show();

        }
    }
}
