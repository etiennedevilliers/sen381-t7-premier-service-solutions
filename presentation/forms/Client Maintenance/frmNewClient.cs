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
using Logic.ClientMaintenance;

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmNewClient : Form
    {
        bool Ind;
        ClientLogic clientLogic = new ClientLogic();
        public Client newClient;

        public frmNewClient(bool Ind)
        {
            InitializeComponent();

            this.Ind = Ind;
        }

        private void frmNewBusinessClient_Load(object sender, EventArgs e)
        {
            txtID.Text = clientLogic.GenerateUniqueClientID();

            if (Ind)
            {
                lblName.Text = "Name:";
                lblSurname.Visible = true;
                txtSurname.Visible = true;

                tabNewClient.TabPages.Remove(tpgEmployee);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Ind)
            {
                newClient = new IndividualClient(txtName.Text, txtSurname.Text, txtContactNum.Text, txtID.Text);
            }
            else
            {
                BusinessClient bus = new BusinessClient(txtName.Text, txtContactNum.Text, txtID.Text);

                foreach (ListViewItem i in lstEmployee.Items)
                {
                    bus.Employees.Add((Employee) i.Tag);
                }

                newClient = bus;
            }

            foreach (ListViewItem i in lstAddress.Items)
            {
                newClient.Addresses.Add((Address) i.Tag);
            }

            foreach (ListViewItem i in lstEquipment.Items)
            {
                newClient.Equipment.Add((Equipment) i.Tag);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            txtID.Text = clientLogic.GenerateUniqueClientID();
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
    }
}
