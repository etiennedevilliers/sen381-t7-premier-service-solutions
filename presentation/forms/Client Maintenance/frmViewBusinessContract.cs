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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmViewBusinessContract : Form
    {
        private BusinessClient businessClient;

        public frmViewBusinessContract(BusinessClient businessClient)
        {
            InitializeComponent();

            this.businessClient = businessClient;

            tbBusiName.Text = businessClient.Name;
            tbBusContact.Text = businessClient.ContactNum;
        }

        private void frmViewBusinessContract_Load(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();

            List<ServiceContract> servContr = new List<ServiceContract>();
            foreach (ClientServiceContract cServiceContract in clientController.serviceContract.ReadChildren(this.businessClient))
            {
                ListViewItem lstViewIndivB = new ListViewItem(
                    new string[] {
                            cServiceContract.Description,
                            cServiceContract.StartDate.ToString(),
                            cServiceContract.EndDate.ToString(),
                    }
                );

                lstViewBusi.Items.Add(lstViewIndivB);
            }

            LoadLstvEquipment();
        }

        private void LoadLstvEquipment()
        {
            ClientController clientController = new ClientController();

            lstvEquipment.Items.Clear();

            foreach (Equipment equipment in clientController.equipment.ReadChildren(this.businessClient))
            {
                ListViewItem listViewItem = new ListViewItem(
                    new string[]
                    {
                        equipment.SerialNumber,
                        equipment.Manufacturer,
                        equipment.Category.ToString(),
                    }
                );

                listViewItem.Tag = equipment;

                lstvEquipment.Items.Add(listViewItem);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.businessClient.Name = tbBusiName.Text;
            this.businessClient.ContactNum = tbBusContact.Text;

            (new BusinessClientController()).Update(this.businessClient);

            Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment = frmNewEquipment.CreateNewEquipment();

            if (equipment != null)
            {
                ClientMaintenanceLogic.AddEquipmentToClient(this.businessClient, equipment);
                LoadLstvEquipment();
            }
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            if (lstvEquipment.SelectedItems.Count > 0)
            {
                Equipment equipment = (lstvEquipment.SelectedItems[0].Tag) as Equipment;

                ClientMaintenanceLogic.RemoveEquipmentFromClient(this.businessClient, equipment);

                LoadLstvEquipment();
            }
            else
            {
                MessageBox.Show("Select equipment first");
            }
            
        }
    }
}
