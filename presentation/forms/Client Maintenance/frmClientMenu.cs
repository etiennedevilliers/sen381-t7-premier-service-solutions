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
using Logic;
using Presentation.Forms.Agents;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmClientMenu : Form
    {
        List<IndividualClient> individualClients = new List<IndividualClient>();
        IndividualClientController ictr = new IndividualClientController();

        List<BusinessClient> businessClients = new List<BusinessClient>();
        BusinessClientController bctr = new BusinessClientController();


        public frmClientMenu()
        {
            InitializeComponent();
        }

        private void frmClientMenu_Load(object sender, EventArgs e)
        {
            LoadIndividualClient();
            LoadBusinessClient();
            LoadServiceContractRequests();
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
                            newClientRequest.ContactNum
                        }
                    );

                    lstI.Tag = newClientRequest;

                    lvNewClientRequests.Items.Add(lstI);
                }
                

                
            }
        }

        void LoadServiceContractRequests() 
        {
            lvServiceContractRequests.Items.Clear();
            NewContractRequestController newContractRequestController = new NewContractRequestController();

            foreach (NewContractRequest newContractRequest in newContractRequestController.Read())
            {
                if (newContractRequest.Status != "Open") continue;
                
                
                Client client = newContractRequest.Client;

                if (client is IndividualClient)
                {
                    IndividualClient iClient = client as IndividualClient;

                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        String.Format("{0} {1}", iClient.Name, iClient.Surname),
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

        void LoadIndividualClient()
        {
            //lstClientsI.Clear();
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

        
        public static Boolean Individual;

        private void btnAddI_Click(object sender, EventArgs e)
        {
            Individual = true;

            Hide();
            frmNewClient form = new frmNewClient();
            form.ShowDialog();
            


        }

        private void btnEditI_Click(object sender, EventArgs e)
        {
            //Individual = true;

            //Hide();
            //frmEditClient form = new frmEditClient();
            //form.ShowDialog();

            if (lstClientsI.SelectedItems.Count > 0)
            {
                IndividualClient client = lstClientsI.SelectedItems[0].Tag as IndividualClient;


                frmEditIndividualClient editFrm = new frmEditIndividualClient(client);
                editFrm.ShowDialog();
                LoadIndividualClient();
            }
        }

        public static Boolean Business;

        private void btnAddB_Click(object sender, EventArgs e)
        {
            Business = true;

            Hide();
            frmNewBusinessClient form = new frmNewBusinessClient();
            form.ShowDialog();
            

        }

        private void btnEditB_Click(object sender, EventArgs e)
        {
            //Business = true;

            //Hide();
            //frmEditBusinessClient form = new fr();
            //form.ShowDialog();
            if (lstClientsB.SelectedItems.Count > 0)
            {
                BusinessClient client = lstClientsB.SelectedItems[0].Tag as BusinessClient;
                frmEditBusinessClient editFrmB = new frmEditBusinessClient(client);
                editFrmB.ShowDialog();
                LoadBusinessClient();
            }
            else
            {
                MessageBox.Show("Please select a field to edit", "SELECT A FIELD",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteI == DialogResult.Yes)
            {
                if (lstClientsI.SelectedItems.Count > 0) {
                    //MessageBox.Show((lstClientsI.SelectedItems[0].Tag as Client).ToString());
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
                //MessageBox.Show(this.ToString() + client.ToString());

                frmViewIndividual viewContrFrm = new frmViewIndividual(client);
                viewContrFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a field to view", "SELECT A FIELD",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnViewB_Click(object sender, EventArgs e)
        {
            if (lstClientsB.SelectedItems.Count > 0)
            {
                BusinessClient client = lstClientsB.SelectedItems[0].Tag as BusinessClient;
                //MessageBox.Show(this.ToString() + client.ToString());

                frmViewBusiness viewBusinessContrFrm = new frmViewBusiness(client);
                viewBusinessContrFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a field to view", "SELECT A FIELD",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAssignEmployeeB_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCallClient_Click(object sender, EventArgs e)
        {

            if (lvServiceContractRequests.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Service Contract request first!");
                return;
            }

            frmAddServiceContractToClient.FullfillNewContractRequest(
                lvServiceContractRequests.SelectedItems[0].Tag as NewContractRequest
            );

            LoadServiceContractRequests();



        }

        private void btnResolveNewClientRequest_Click(object sender, EventArgs e)
        {
            if (lvNewClientRequests.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select number first!");
                return;
            }

            NewClientRequest newClientRequest = lvNewClientRequests.SelectedItems[0].Tag as NewClientRequest;
            frmNewClientCreation frm = new frmNewClientCreation();
            Agent agent = frmSelectAgent.GetAgent();

            if (agent == null) return;

            CallLog callLog = new CallLog(DateTime.Now, false);
            callLog.Representative = agent;

            frm.ShowDialog();
            newClientRequest.Status = "Resolve";
            new NewClientRequestController().Update(newClientRequest);
            callLog.TimeEnded = DateTime.Now;
            new CallLogController().Create(callLog);

            LoadNewClientRequests();
        }
    }
}
  