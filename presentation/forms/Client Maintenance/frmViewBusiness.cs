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
    public partial class frmViewBusiness : Form
    {
        private BusinessClient businessClient;

        public frmViewBusiness(BusinessClient businessClient)
        {
            InitializeComponent();

            this.businessClient = businessClient;

            tbBusiName.Text = businessClient.Name;
            tbBusContact.Text = businessClient.ContactNum;

            AgentController agentController = new AgentController();


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

            LoadLstvAddress();

            LoadLstvEmployee();
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

            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            frmClientMenu frm = new frmClientMenu();
            frm.ShowDialog();
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
                DialogResult deleteE = MessageBox.Show("Are you sure you want to delete this equipment?", "WARNING: DELETE EQUIPMENT",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteE == DialogResult.Yes)
                {
                    Equipment equipment = (lstvEquipment.SelectedItems[0].Tag) as Equipment;

                    ClientMaintenanceLogic.RemoveEquipmentFromClient(this.businessClient, equipment);

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

            lstAddressB.Items.Clear();

            foreach (Address address in clientController.address.ReadChildren(this.businessClient))
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

                lstAddressB.Items.Add(listViewItem);
            }
        }

        private void btnAddAddressAB_Click(object sender, EventArgs e)
        {
            Address adr = frmNewAddress.GetAddress();

            if (adr != null)
            {
                new ClientController().address.Add(adr, this.businessClient);
                LoadLstvAddress();
            }
        }


        private void btnRemoveAddressAB_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();

            if (lstAddressB.SelectedItems.Count > 0)
            {
                DialogResult deleteA = MessageBox.Show("Are you sure you want to delete this Address?", "WARNING: DELETE Address",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteA == DialogResult.Yes)
                {

                    Address address = (lstAddressB.SelectedItems[0].Tag) as Address;
                    clientController.address.Remove(address, this.businessClient);

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

        private void LoadLstvEmployee()
        {
            BusinessClientController businessclientController = new BusinessClientController();

            lstEmployee.Items.Clear();

            foreach (Employee employee in businessclientController.ReadChildren(this.businessClient))
            {
                ListViewItem listViewItem = new ListViewItem(
                    new string[]
                    {
                        employee.Name,
                        employee.Surname,
                        employee.Role,
                        employee.ContactNum
                    }
                );

                listViewItem.Tag = employee;

                lstEmployee.Items.Add(listViewItem);
            }
        }

        private void btnAddEmpl_Click(object sender, EventArgs e)
        {
            Employee empl = frmNewEmployee.AddEmployee();

            if (empl != null)
            {
                new BusinessClientController().Add(empl,this.businessClient);
                LoadLstvEmployee();
            }

        }

        private void btnRemoveEmpl_Click(object sender, EventArgs e)
        {
            

            if (lstEmployee.SelectedItems.Count > 0)
            {
                DialogResult deleteA = MessageBox.Show("Are you sure you want to delete this Employee?", "WARNING: DELETE EMPLOYEE",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteA == DialogResult.Yes)
                {

                    BusinessClientController busicont = new BusinessClientController();
                    Employee employee = (lstEmployee.SelectedItems[0].Tag) as Employee;
                    busicont.Remove(employee, this.businessClient);

                    LoadLstvAddress();
                }
                else
                {
                    MessageBox.Show("Unsaved Changes - Employee not deleted", "EMPLOYEE NOT DELETED ",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select employee first");
            }

        }
    }
}
