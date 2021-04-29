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
            Service skill;

            foreach (ListViewItem i in lstSkills.Items)
            {
                skill = new Service(i.SubItems[1].Text, int.Parse(i.SubItems[2].Text));
                skill.Id = int.Parse(i.SubItems[0].Text);

                newSkills.Add(skill);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Service skill = (Service) cbxServices.SelectedItem;

            ListViewItem lst = new ListViewItem(new string[] { skill.Id.ToString(), skill.Description, skill.ExpectedDuration.ToString() });

            lstSkills.Items.Add(lst);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstSkills.Items.RemoveAt(lstSkills.SelectedIndices[0]);
        }
    }
}