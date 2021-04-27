﻿using System;
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
            Individual = true;

            Hide();
            frmEditClient form = new frmEditClient();
            form.ShowDialog();
            
        }

        public static Boolean Business;

        private void btnAddB_Click(object sender, EventArgs e)
        {
            Business = true;

            Hide();
            frmNewClient form = new frmNewClient();
            form.ShowDialog();
            

        }

        private void btnEditB_Click(object sender, EventArgs e)
        {
            Business = true;

            Hide();
            frmEditClient form = new frmEditClient();
            form.ShowDialog();
            
        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Client?", "WARNING: DELETE CLIENT",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteI == DialogResult.Yes)
            {
                MessageBox.Show("Client successfully deleted", "CLIENT DELETED",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                /*(if (Individual)
                {
                    IndividualClientController individualClientController = new IndividualClientController();
                    IndividualClient individualClient = new IndividualClient(
                        
                        );
                    individualClientController.Delete(individualClient);
                }
                if (Business)
                {
                    BusinessClientController businessClientController = new BusinessClientController();
                    BusinessClient businessClient = new BusinessClient(
                        
                        
                        );
                    BusinessClientController.Delete(businessClient);
                }
                */
                MessageBox.Show("Client successfully deleted", "CLIENT DELETED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Client NOT deleted", "CLIENT UNCHANGED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnViewContractI_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewContract form = new frmViewContract();
            form.ShowDialog();
            
        }

        private void btnViewContractB_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewContract form = new frmViewContract();
            form.ShowDialog();
            
        }

        private void btnAssignEmployeeB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee assigned to client", "EMPLOYEE ASSIGNED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
