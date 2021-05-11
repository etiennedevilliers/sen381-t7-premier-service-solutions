using Data.Layer.Controller;
using Data.Layer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.ServiceDepartment
{
    public partial class frmAddTechnician : Form
    {
        public Technician newTech;
        public List<Service> newSkills = new List<Service>();

        public frmAddTechnician()
        {
            InitializeComponent();
        }

        private void frmAddTechnician_Load(object sender, EventArgs e)
        {
            ServiceController serCtr = new ServiceController();
            List<Service> skills = serCtr.Read();

            foreach (Service i in skills)
            {
                cbxServices.Items.Add(i);
            }

            cbxServices.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            newTech = new Technician(txtName.Text, txtContactNum.Text, "Open", "Technician");

            foreach (ListViewItem i in lstSkills.Items)
            {
                newSkills.Add((Service) i.Tag);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Service skill = (Service) cbxServices.SelectedItem;

            ListViewItem lst = new ListViewItem(new string[] { skill.Description, skill.ExpectedDuration.ToString() });
            lst.Tag = skill;

            lstSkills.Items.Add(lst);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstSkills.Items.RemoveAt(lstSkills.SelectedIndices[0]);
        }
    }
}