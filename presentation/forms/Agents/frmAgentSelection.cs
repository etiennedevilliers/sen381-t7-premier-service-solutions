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
using Logic;

namespace Presentation.Forms.Agents
{

    public partial class frmSelectAgent : Form
    {


        public static Agent GetAgent()
        {
            frmSelectAgent form = new frmSelectAgent();

            form.ShowDialog();

            return form.agentSelected;


            

        }

        private List<Agent> callCentreAgents;
        public Agent agentSelected = null;

        private class AgentListItem
        {
            public Agent agent;

            public AgentListItem(Agent agent)
            {
                this.agent = agent;
            }

            public override string ToString()
            {
                return String.Format("{0}, {1}", agent.Name, agent.ContactNum);
            }
        }
        private frmSelectAgent()
        {
            InitializeComponent();
        }


        private void frmCall_Load(object sender, EventArgs e)
        {
            callCentreAgents = CallCentreLogic.GetCallCentreEmployees();

            refreshAgentList();
        }

        private void refreshAgentList()
        {
            agentCollection.Items.Clear();
            foreach (Agent agent in callCentreAgents)
            {
                if (agent.Name.ToLower().Contains(tbNameFilter.Text.ToLower()))
                    agentCollection.Items.Add(new AgentListItem(agent));
            }
        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            if (agentCollection.SelectedItem != null)
            {
                agentSelected = (agentCollection.SelectedItem as AgentListItem).agent;
                Close();
            }
            else
            {
                MessageBox.Show("No agent selected");
            }
            
        }

        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {
            refreshAgentList();
        }
    }
}
