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

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmViewIndividual : Form
    {
        private IndividualClient indivClient; 

        public frmViewIndividual(IndividualClient indivClient)
        {
            InitializeComponent();

            this.indivClient = indivClient;

            tbIndivName.Text = indivClient.Name;
            tbIndivSurname.Text = indivClient.Surname;
            tbIndivContact.Text = indivClient.ContactNum;
        }

        private void frmViewContract_Load(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();

            List<ServiceContract> servContr = new List<ServiceContract>();

            

            foreach(ClientServiceContract cServiceContract in clientController.serviceContract.ReadChildren(this.indivClient))
            {
                ListViewItem lstViewIndivI = new ListViewItem(
                    new string[] {
                            cServiceContract.Description,
                            cServiceContract.StartDate.ToString(),
                            cServiceContract.EndDate.ToString(),
                    }
                ) ;

                lstViewIndiv.Items.Add(lstViewIndivI);
            }


            LoadLstvEquipment();

            LoadLstvAddress();
        }

        private void btnApply_Click(object sender, EventArgs e)
{
            this.indivClient.Name = tbIndivName.Text;
            this.indivClient.Surname = tbIndivSurname.Text;
            this.indivClient.ContactNum = tbIndivContact.Text;

            (new IndividualClientController()).Update(this.indivClient);

            Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LoadLstvEquipment()
        {
            ClientController clientController = new ClientController();

            lstvEquipment.Items.Clear();

            foreach (Equipment equipment in clientController.equipment.ReadChildren(this.indivClient))
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


        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment = frmNewEquipment.CreateNewEquipment();

            if (equipment != null)
            {
                ClientMaintenanceLogic.AddEquipmentToClient(this.indivClient, equipment);
                LoadLstvEquipment();
            }
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            if (lstvEquipment.SelectedItems.Count > 0)
            {
                DialogResult deleteE = MessageBox.Show("Are you sure you want to delete this equipment?", "WARNING: DELETE EQUIPMENT",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteE == DialogResult.Yes)
                {
                    Equipment equipment = (lstvEquipment.SelectedItems[0].Tag) as Equipment;

                    ClientMaintenanceLogic.RemoveEquipmentFromClient(this.indivClient, equipment);

                    LoadLstvEquipment();
                }
                else
                {
                    MessageBox.Show("Unsaved Changes - Equipment not deleted", "EQUIPMENT NOT DELETED ",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            else
            {
                MessageBox.Show("Select equipment first");
            }

        }

        private void LoadLstvAddress()
        {
            ClientController clientController = new ClientController();

            lstAddressI.Items.Clear();

            foreach (Address address in clientController.address.ReadChildren(this.indivClient))
            {
                ListViewItem listViewItem = new ListViewItem(
                    new string[]
                    {
                        address.StreetAddress,
                        address.Province,
                        address.Country,
                        address.District,
                        address.Locality,
                        address.Premise,
                        address.PostalCode
                    }
                );

                listViewItem.Tag = address;

                lstAddressI.Items.Add(listViewItem);
            }
        }

        private void btnAddAddressAI_Click(object sender, EventArgs e)
        {
            Address adr = frmNewAddress.GetAddress();

            if (adr != null)
            {
                new ClientController().address.Add(adr, this.indivClient);

                LoadLstvAddress();
            }

        }

        private void btnRemoveAddressAI_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();

            if (lstAddressI.SelectedItems.Count > 0)
            {
                DialogResult deleteA = MessageBox.Show("Are you sure you want to delete this Address?", "WARNING: DELETE Address",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteA == DialogResult.Yes)
                {

                    Address address = (lstAddressI.SelectedItems[0].Tag) as Address;
                    clientController.address.Remove(address, this.indivClient);

                    LoadLstvAddress();
                }
                else
                {
                    MessageBox.Show("Unsaved Changes - Address not deleted", "ADDRESS NOT DELETED ",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select address first");
            }

        }
    }
}
