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

namespace Presentation.Forms.CallCentre
{
    public partial class frmCallCentre : Form
    {
        Agent agentLoggedIn;

        public frmCallCentre(Agent agentLoggedIn)
        {
            this.agentLoggedIn = agentLoggedIn;

            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            FrmNewRequest form = new FrmNewRequest(agentLoggedIn);
            form.ShowDialog();
        }
    }
}
