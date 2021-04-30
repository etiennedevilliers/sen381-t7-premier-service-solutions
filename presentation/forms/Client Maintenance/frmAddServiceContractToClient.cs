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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmAddServiceContractToClient : Form
    {
        private NewContractRequestLogic newContractRequestLogic;

        public frmAddServiceContractToClient(NewContractRequestLogic newContractRequestLogic)
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
