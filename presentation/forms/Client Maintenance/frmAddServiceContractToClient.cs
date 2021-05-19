using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.ClientMaintenance;
using Data.Layer.Controller;
using Data.Layer.Objects;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmAddServiceContractToClient : Form
    {
        NewContractRequestLogic newContractRequestLogic = new NewContractRequestLogic();
        NewContractRequest newContractRequest;
        public DateTime startDate;
        public DateTime endDate;

        public frmAddServiceContractToClient(NewContractRequest newContractRequest)
        {
            InitializeComponent();

            this.newContractRequest = newContractRequest;

            Client client = newContractRequest.Client;

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
            
            lblServiceContract.Text = newContractRequest.ServiceContract.ToString();

            updateErrorLabel();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            updateErrorLabel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateErrorLabel();
        }

        private void updateErrorLabel()
        {
            errorLabel.Text = newContractRequestLogic.checkDateTime(
                newContractRequest,
                dtpStart.Value,
                dtpEnd.Value
            ).reason;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            if (!newContractRequestLogic.checkDateTime(newContractRequest, dtpStart.Value, dtpEnd.Value).valid) {
                MessageBox.Show("Pick Valid dates first!");
                return;
            }

            startDate = dtpStart.Value;
            endDate = dtpEnd.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
