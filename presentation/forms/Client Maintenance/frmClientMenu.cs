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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
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
        }

        void LoadIndividualClient()
        {
            //lstClientsI.Clear();
            IndividualClientController individualClientController = new IndividualClientController();

            foreach (IndividualClient client in individualClientController.Read())
            {
                ListViewItem lstI = new ListViewItem(
                    new string[] {
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

            foreach (BusinessClient client in businessClientController.Read())
            {
                ListViewItem lstB = new ListViewItem(
                    new string[]
                    {
                        client.Name,
                        client.ContactNum
                    }
                 );

                lstB.Tag = client;
                lstClientsB.Items.Add(lstB);

                AgentController agentController = new AgentController();

                foreach (Agent agent in agentController.Read())
                {
                    cbEmployeesB.Items.Add(agent);
                }
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
                MessageBox.Show(this.ToString() + client.ToString());

                frmEditBusinessClient editFrmB = new frmEditBusinessClient(client);
                editFrmB.ShowDialog();
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

        private void btnViewContractI_Click(object sender, EventArgs e)
        {
            if (lstClientsI.SelectedItems.Count > 0)
            {
                IndividualClient client = lstClientsI.SelectedItems[0].Tag as IndividualClient;
                //MessageBox.Show(this.ToString() + client.ToString());

                frmViewContract viewContrFrm = new frmViewContract(client);
                viewContrFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a field to view", "SELECT A FIELD",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnViewContractB_Click(object sender, EventArgs e)
        {
            if (lstClientsB.SelectedItems.Count > 0)
            {
                BusinessClient client = lstClientsB.SelectedItems[0].Tag as BusinessClient;
                //MessageBox.Show(this.ToString() + client.ToString());

                frmViewBusinessContract viewBusinessContrFrm = new frmViewBusinessContract(client);
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
            if (cbEmployeesB.SelectedIndex > 0)
            {
                //Employeee = cbEmployeesB.SelectedItem as Agent;
            }
            else
            {
                MessageBox.Show("Employee assigned to client", "EMPLOYEE ASSIGNED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
