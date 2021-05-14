using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmNewClientCreation : Form
    {
        public frmNewClientCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewClient frm = new frmNewClient();
            frm.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewBusinessClient frm = new frmNewBusinessClient();
            frm.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
