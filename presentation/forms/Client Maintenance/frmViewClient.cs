using Data.Layer.Objects;
using Logic.ClientMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmViewClient : Form
    {
        bool edit;
        ClientLogic clientLogic = new ClientLogic();
        Client oldClient;

        public frmViewClient(Client oldClient)
        {
            InitializeComponent();

            this.oldClient = oldClient;
        }

        private void frmViewClient_Load(object sender, EventArgs e)
        {
            if (oldClient is IndividualClient)
            {
                lblName.Text = "Name:";
                lblSurname.Visible = true;
                txtSurname.Visible = true;

                IndividualClient ind = (IndividualClient) oldClient;
                txtName.Text = ind.Name;
                txtSurname.Text = ind.Surname;

                tabViewClient.TabPages.Remove(tpgEmployees);
            }
            else
            {
                BusinessClient bus = (BusinessClient) oldClient;
                txtName.Text = bus.Name;

                foreach (Employee i in bus.Employees)
                {
                    ListViewItem lst = new ListViewItem(new string[] {
                        i.Name, i.Surname, i.Role, i.ContactNum
                    });
                    lst.Tag = i;

                    lstEmployee.Items.Add(lst);
                }
            }

            txtContactNum.Text = oldClient.ContactNum;
            txtID.Text = oldClient.ClientIdentifier;

            foreach (Address i in oldClient.Addresses)
            {
                ListViewItem lst = new ListViewItem(new string[] {
                        i.Country, i.Province, i.District, i.Locality, i.PostalCode, i.StreetAddress, i.Premise
                    });
                lst.Tag = i;

                lstAddress.Items.Add(lst);
            }

            foreach (Equipment i in oldClient.Equipment)
            {
                ListViewItem lst = new ListViewItem(new string[] {
                        i.SerialNumber, i.Manufacturer, i.Category.Name
                    });
                lst.Tag = i;

                lstEquipment.Items.Add(lst);
            }

            foreach (ClientServiceContract i in oldClient.Contracts)
            {
                ListViewItem lst = new ListViewItem(new string[] {
                        i.Description, i.StartDate.Value.ToShortDateString(), i.EndDate.Value.ToShortDateString()
                    });
                lst.Tag = i;

                lstContracts.Items.Add(lst);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                Close();
                return;
            }

            Client client;

            if (oldClient is IndividualClient)
            {
                client = new IndividualClient(txtName.Text, txtSurname.Text, txtContactNum.Text, txtID.Text);
            }
            else
            {
                BusinessClient bus = new BusinessClient(txtName.Text, txtContactNum.Text, txtID.Text);

                bus.Employees = new List<Employee>();

                foreach (ListViewItem i in lstEmployee.Items)
                {
                    bus.Employees.Add((Employee) i.Tag);
                }

                client = bus;
            }

            client.Id = oldClient.Id;

            client.Addresses = new List<Address>();
            client.Equipment = new List<Equipment>();

            foreach (ListViewItem i in lstAddress.Items)
            {
                client.Addresses.Add((Address) i.Tag);
            }

            foreach (ListViewItem i in lstEquipment.Items)
            {
                client.Equipment.Add((Equipment) i.Tag);
            }

            if (oldClient is IndividualClient)
            {
                clientLogic.UpdateIndClient(client, oldClient.Equipment, oldClient.Addresses);
            }
            else
            {
                BusinessClient bus = (BusinessClient) oldClient;

                clientLogic.UpdateBusClient(client, oldClient.Equipment, oldClient.Addresses, bus.Employees);
            }

            btnEdit_Click(sender, e);
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            frmNewAddress form = new frmNewAddress();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                Address address = form.newAddress;

                ListViewItem lst = new ListViewItem(new string[] { address.Country, address.Province, address.District, address.Locality, address.PostalCode, address.StreetAddress, address.Premise });
                lst.Tag = address;
                lstAddress.Items.Add(lst);
            }
        }

        private void btnRemoveAddress_Click(object sender, EventArgs e)
        {
            lstAddress.Items.RemoveAt(lstAddress.SelectedIndices[0]);
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            frmNewEquipment form = new frmNewEquipment();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                Equipment equipment = form.newEquipment;

                ListViewItem lst = new ListViewItem(new string[] { equipment.SerialNumber, equipment.Manufacturer, equipment.Category.Name });
                lst.Tag = equipment;
                lstEquipment.Items.Add(lst);
            }
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            lstEquipment.Items.RemoveAt(lstEquipment.SelectedIndices[0]);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee form = new frmNewEmployee();
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK)
            {
                Employee employee = form.newEmployee;

                ListViewItem lst = new ListViewItem(new string[] { employee.Name, employee.Surname, employee.Role, employee.ContactNum });
                lst.Tag = employee;
                lstEmployee.Items.Add(lst);
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndices[0]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                btnOK.Text = "Save";
                btnEdit.Visible = false;

                txtName.ReadOnly = false;
                txtSurname.ReadOnly = false;
                txtContactNum.ReadOnly = false;

                btnAddAddress.Visible = true;
                btnAddEmployee.Visible = true;
                btnAddEquipment.Visible = true;
                btnRemoveAddress.Visible = true;
                btnRemoveEmployee.Visible = true;
                btnRemoveEquipment.Visible = true;

                edit = !edit;
            }
            else
            {
                btnOK.Text = "OK";
                btnEdit.Visible = true;

                txtName.ReadOnly = true;
                txtSurname.ReadOnly = true;
                txtContactNum.ReadOnly = true;

                btnAddAddress.Visible = false;
                btnAddEmployee.Visible = false;
                btnAddEquipment.Visible = false;
                btnRemoveAddress.Visible = false;
                btnRemoveEmployee.Visible = false;
                btnRemoveEquipment.Visible = false;

                edit = !edit;
            }
        }
    }
}
