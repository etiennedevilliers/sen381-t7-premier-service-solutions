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

            Hide();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
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
                Equipment equipment = (lstvEquipment.SelectedItems[0].Tag) as Equipment;

                ClientMaintenanceLogic.RemoveEquipmentFromClient(this.indivClient, equipment);

                LoadLstvEquipment();
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
            //Address address = frmNewAddress.CreateNewAddress();

            //if (address != null)
            {
                //(this.businessClient, address);
                LoadLstvAddress();
            }
            
        }

        private void btnRemoveAddressAI_Click(object sender, EventArgs e)
        {
            LoadLstvAddress();

        }
    }
}
