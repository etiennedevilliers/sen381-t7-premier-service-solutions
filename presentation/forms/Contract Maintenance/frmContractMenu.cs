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
    public partial class frmContractMenu : Form
    {
        public frmContractMenu()
        {
            InitializeComponent();
        }

        private void frmContractMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnViewContracts_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewContracts form = new frmViewContracts();
            form.ShowDialog();
          

        }

        private void btnEditContracts_Click(object sender, EventArgs e)
        {
           
            Hide();
            frmNewContract form = new frmNewContract();
            form.ShowDialog();
        
        }
    }
}
