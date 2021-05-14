using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Data.Layer.Controller;
using Data.Layer.Objects;
using Presentation.Forms.Agents;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmAddServiceContractToClient : Form
    {
        public static void FullfillNewContractRequest(NewContractRequest newContractRequest)
        {
            Agent agent = frmSelectAgent.GetAgent();

            if (agent != null)
            {
                NewContractRequestLogic newContractRequestLogic = new NewContractRequestLogic(
                    agent,
                    false,
                    newContractRequest
                );

                frmAddServiceContractToClient form = new frmAddServiceContractToClient(newContractRequestLogic);
                form.ShowDialog();
            }
        }

        private NewContractRequestLogic newContractRequestLogic;

        private frmAddServiceContractToClient(NewContractRequestLogic newContractRequestLogic)
        {
            InitializeComponent();

            this.newContractRequestLogic = newContractRequestLogic;

            Client client = newContractRequestLogic.newContractRequest.Client;

            if (client is IndividualClient)
            {
                IndividualClient iClient = client as IndividualClient;
                lblClient.Text = iClient.ToString();

            }
            else
            {
                BusinessClient bClient = client as BusinessClient;
                lblClient.Text = bClient.ToString();
            }
            
            lblServiceContract.Text = newContractRequestLogic.newContractRequest.ServiceContract.ToString();

            updateErrorLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            updateErrorLabel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateErrorLabel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateErrorLabel()
        {
            errorLabel.Text = newContractRequestLogic.checkDateTime(
                dtpStart.Value,
                dtpEnd.Value
            ).NotValidReason;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            if (!newContractRequestLogic.checkDateTime(startDate, endDate).Valid) {
                MessageBox.Show("Pick Valid dates first!");
                return;
            }

            newContractRequestLogic.addServiceContract(startDate, endDate);
            Close();
        }
    }
}
