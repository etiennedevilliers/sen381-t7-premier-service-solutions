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
    }
}
