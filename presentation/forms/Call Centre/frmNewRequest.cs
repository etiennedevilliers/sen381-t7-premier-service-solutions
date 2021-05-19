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
using Data.Layer.Controller;
using Logic;
using Logic.CallCentre;

namespace Presentation.Forms.CallCentre
{
    public partial class FrmNewRequest : Form
    {
        CallCentreLogic callLogic = new CallCentreLogic();
        CallLog call;

        public FrmNewRequest(Agent agentLoggedIn)
        {
            InitializeComponent();

            call = new CallLog(DateTime.Now, true);
            call.Representative = agentLoggedIn;
        }

        private void FrmNewRequest_Load(object sender, EventArgs e)
        {
            IndividualClientController individualClientController = new IndividualClientController();
            BusinessClientController businessClientController = new BusinessClientController();
            ServiceContractController serviceContractController = new ServiceContractController();

            foreach (IndividualClient client in individualClientController.Read())
            {
                cbExistingClient.Items.Add(client);
            }

            foreach (BusinessClient client in businessClientController.Read())
            {
                cbExistingClient.Items.Add(client);
            }

            foreach (ServiceContract serviceContract in serviceContractController.Read())
            {
                cbNewContractRequestServiceContract.Items.Add(serviceContract);
            }

            cbxClientType.SelectedIndex = 0;
        }

        private void btnNewClientRequest_Click(object sender, EventArgs e)
        {
            if (tbContactNumber.Text.Length == 0)
            {
                MessageBox.Show("Please enter the Client Contact Number first.");
                return;
            }

            callLogic.CreateNewClientRequest(
                tbContactNumber.Text,
                call,
                cbxClientType.SelectedIndex == 0
            );

            Close();
        }

        private void cbExistingClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbExistingClient.SelectedItem != null) {
                ClientController clientController = new ClientController();

                Client currentClient = cbExistingClient.SelectedItem as Client;
                cbComplaintServiceContract.Items.Clear();
                foreach (ServiceContract serviceContract in clientController.serviceContract.ReadChildren(currentClient))
                {
                    cbComplaintServiceContract.Items.Add(serviceContract);
                    cbServiceRequestServiceContract.Items.Add(serviceContract);
                }
            }
        }

        private void btnComplaintRequest_Click(object sender, EventArgs e)
        {
            if (cbExistingClient.SelectedItem == null)
            {
                MessageBox.Show("You need to select a Client first"); 
                return;
            }

            if (cbComplaintServiceContract.SelectedItem == null)
            {
                MessageBox.Show("You need to select the problematic ServiceContract first"); 
                return;
            }

            if (tbComplaintDescription.Text.Length == 0)
            {
                MessageBox.Show("You need to add a decription to the complaint first"); 
                return;
            }

            callLogic.CreateNewComplaintRequest(
                tbComplaintDescription.Text,
                cbExistingClient.SelectedItem as Client,
                cbComplaintServiceContract.SelectedItem as ServiceContract,
                call
            );

            Close();
        }

        private void btnNewContractRequest_Click(object sender, EventArgs e)
        {
            if (cbExistingClient.SelectedItem == null)
            {
                MessageBox.Show("You need to select a Client first");
                return;
            }

            if (cbNewContractRequestServiceContract.SelectedItem == null)
            {
                MessageBox.Show("You need to select a new ServiceContract first");
                return;
            }

            callLogic.CreateNewNewContractRequest(
                cbNewContractRequestServiceContract.SelectedItem as ServiceContract,
                cbExistingClient.SelectedItem as Client,
                call
            );

            Close();
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            if (cbExistingClient.SelectedItem == null)
            {
                MessageBox.Show("You need to select a Client first");
                return;
            }

            if (cbServiceRequestServiceContract.SelectedItem == null)
            {
                MessageBox.Show("You need to select a ServiceContract for service first");
                return;
            }

            if (tbServiceRequestDescription.Text.Length == 0)
            {
                MessageBox.Show("You need to add a decription first");
                return;
            }

            callLogic.CreateNewServiceRequest(
                cbServiceRequestServiceContract.SelectedItem as ServiceContract,
                cbExistingClient.SelectedItem as Client,
                tbServiceRequestDescription.Text,
                call
            );

            Close();
        }
    }
}
