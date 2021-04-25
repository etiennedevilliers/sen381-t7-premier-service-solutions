using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Controller;
using Data.Layer.Objects;

namespace Presentation.Forms.CallCentre
{
    public partial class frmCall : Form
    {
        public frmCall()
        {
            InitializeComponent();
        }

        private void frmCall_Load(object sender, EventArgs e)
        {
            AgentController agentController = new AgentController();

            foreach (Agent agent in agentController.Read())
            {
                cbAgents.Items.Add(agent);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            Hide();
            CallLog callLog = new CallLog(DateTime.Now, cbIncoming.Checked);
            callLog.Representative = cbAgents.SelectedItem as Agent;
            FrmNewRequest frmNewRequest = new FrmNewRequest(callLog);
            frmNewRequest.ShowDialog();
            Show();
        }
    }
}
