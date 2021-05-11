using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmServiceContractMenu : Form
    {
        public frmServiceContractMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            frmCreateService form = new frmCreateService();
            form.Show();


        }
    }
}
