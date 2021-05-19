using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using Data.Layer.Objects;
using Data.Layer.Controller;
using Logic.ClientMaintenance;
using Logic.CallCentre;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmClientMaintenance : Form
    {
        Agent agentLoggedIn;
        ClientLogic clientLogic = new ClientLogic();
        CallCentreLogic callLogic = new CallCentreLogic();

        public frmClientMaintenance(Agent agentLoggedIn)
        {
            this.agentLoggedIn = agentLoggedIn;

            InitializeComponent();
        }

        private void frmClientMenu_Load(object sender, EventArgs e)
        {
            LoadIndividualClient();
            LoadBusinessClient();
            LoadNewContractRequests();
            LoadNewClientRequests();
        }

        void LoadNewClientRequests()
        {
            NewClientRequestController newClientRequestController = new NewClientRequestController();
            lvNewClientRequests.Items.Clear();
            foreach (NewClientRequest newClientRequest in newClientRequestController.Read())
            {
                if (newClientRequest.Status == "Open")
                {
                    ListViewItem lstI = new ListViewItem(
                        new string[] {
                            newClientRequest.ContactNum,
                            newClientRequest.Individual ? "Individual" : "Business"
                        }
                    );

                    lstI.Tag = newClientRequest;

                    lvNewClientRequests.Items.Add(lstI);
                }
            }
        }

        void LoadNewContractRequests() 
        {
            lvServiceContractRequests.Items.Clear();
            NewContractRequestController newContractRequestController = new NewContractRequestController();

            foreach (NewContractRequest newContractRequest in newContractRequestController.Read())
            {
                if (newContractRequest.Status == "Open")
                {
                    Client client = newContractRequest.Client;

                    if (client is IndividualClient)
                    {
                        IndividualClient iClient = client as IndividualClient;

                        ListViewItem listViewItem = new ListViewItem(new string[] {
                            string.Format("{0} {1}", iClient.Name, iClient.Surname),
                            "Individual Client",
                            newContractRequest.ServiceContract.Description,
                            newContractRequest.DateCreated.ToShortDateString(),
                            newContractRequest.Status
                        });

                        listViewItem.Tag = newContractRequest;

                        lvServiceContractRequests.Items.Add(listViewItem);
                    }
                    else
                    {
                        BusinessClient bClient = client as BusinessClient;

                        ListViewItem listViewItem = new ListViewItem(new string[] {
                            bClient.Name,
                            "Business Client",
                            newContractRequest.ServiceContract.Description,
                            newContractRequest.DateCreated.ToShortDateString(),
                            newContractRequest.Status
                        });

                        listViewItem.Tag = newContractRequest;

                        lvServiceContractRequests.Items.Add(listViewItem);
                    }
                }
            }
        }

        void LoadIndividualClient()
        {
            IndividualClientController individualClientController = new IndividualClientController();
            lstClientsI.Items.Clear();
            foreach (IndividualClient client in individualClientController.Read())
            {
                ListViewItem lstI = new ListViewItem(
                    new string[] {
                        client.ClientIdentifier,
                        client.Name,
                        client.Surname,
                        client.ContactNum
                    }
                );

                lstI.Tag = client;

                lstClientsI.Items.Add(lstI);
            }
        }

        void LoadBusinessClient()
        {
            BusinessClientController businessClientController = new BusinessClientController();
            lstClientsB.Items.Clear();
            foreach (BusinessClient client in businessClientController.Read())
            {
                ListViewItem lstB = new ListViewItem(
                    new string[]
                    {
                        client.ClientIdentifier,
                        client.Name,
                        client.ContactNum
                    }
                 );

                lstB.Tag = client;
                lstClientsB.Items.Add(lstB);
            }
        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteI == DialogResult.Yes)
            {
                if (lstClientsI.SelectedItems.Count > 0) {
                    IndividualClientController individualClientController = new IndividualClientController();
                    IndividualClient client = lstClientsI.SelectedItems[0].Tag as IndividualClient;
                        individualClientController.Delete(client);
                    lstClientsI.Items.Clear();
                    LoadIndividualClient();
                    MessageBox.Show("Client successfully deleted", "INDIVIDUAL CLIENT DELETED",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Client NOT deleted", "CLIENT UNCHANGED",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            DialogResult deleteB = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deleteB == DialogResult.Yes)
            {
                if (lstClientsB.SelectedItems.Count > 0)
                {
                    BusinessClientController businessClientController = new BusinessClientController();
                    BusinessClient client = lstClientsB.SelectedItems[0].Tag as BusinessClient;
                    businessClientController.Delete(client);
                    lstClientsB.Items.Clear();
                    LoadBusinessClient();
                    MessageBox.Show("Client successfully deleted", "BUSINESS CLIENT DELETED",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Client NOT deleted", "CLIENT UNCHANGED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewI_Click(object sender, EventArgs e)
        {
            if (lstClientsI.SelectedItems.Count > 0)
            {
                IndividualClient client = lstClientsI.SelectedItems[0].Tag as IndividualClient;

                frmViewClient form = new frmViewClient(client);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a client to view");
            }

            LoadIndividualClient();
        }

        private void btnViewB_Click(object sender, EventArgs e)
        {
            if (lstClientsB.SelectedItems.Count > 0)
            {
                BusinessClient client = lstClientsB.SelectedItems[0].Tag as BusinessClient;

                frmViewClient form = new frmViewClient(client);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a client to view");
            }

            LoadBusinessClient();
        }

        private void btnCallClient_Click(object sender, EventArgs e)
        {
            if (lvServiceContractRequests.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Service Contract request first!");
                return;
            }

            NewContractRequest newContractRequest = lvServiceContractRequests.SelectedItems[0].Tag as NewContractRequest;
            frmAddServiceContractToClient form = new frmAddServiceContractToClient(newContractRequest);

            CallLog call = new CallLog(DateTime.Now, false);
            call.Representative = agentLoggedIn;

            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                newContractRequest.Status = "Closed";
                new NewContractRequestController().Update(newContractRequest);

                callLogic.EndCall(call);

                clientLogic.AddServiceContract(newContractRequest, form.startDate, form.endDate);

                LoadNewContractRequests();
            }
        }

        private void btnResolveNewClientRequest_Click(object sender, EventArgs e)
        {
            if (lvNewClientRequests.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select request first!");
                return;
            }

            NewClientRequest newClientRequest = lvNewClientRequests.SelectedItems[0].Tag as NewClientRequest;
            frmNewClient form = new frmNewClient(newClientRequest.Individual);

            CallLog call = new CallLog(DateTime.Now, false);
            call.Representative = agentLoggedIn;

            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                newClientRequest.Status = "Closed";
                new NewClientRequestController().Update(newClientRequest);

                callLogic.EndCall(call);

                clientLogic.CreateClient(form.newClient);

                LoadNewClientRequests();
                LoadBusinessClient();
                LoadIndividualClient();
            }
        }
    }
}