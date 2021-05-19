using Data.Layer.Objects;
using Data.Layer.Controller;
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
    public partial class frmEditTechnician : Form
    {
        public Technician tech;
        public List<Service> skills = new List<Service>();

        public frmEditTechnician(Technician tech, List<Service> skills)
        {
            this.tech = tech;
            this.skills.AddRange(skills);

            InitializeComponent();
        }

        private void frmEditTechnician_Load(object sender, EventArgs e)
        {
            ServiceController serCtr = new ServiceController();
            List<Service> skillsAll = serCtr.Read();

            foreach (Service i in skillsAll)
            {
                cbxServices.Items.Add(i);
            }

            cbxServices.SelectedIndex = 0;

            txtName.Text = tech.Name;
            txtContactNum.Text = tech.ContactNum;

            foreach (Service i in skills)
            {
                ListViewItem lst = new ListViewItem(new string[] { i.Description, i.ExpectedDuration.ToString() });
                lst.Tag = i;
                lstSkills.Items.Add(lst);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            skills.Clear();
            tech.Name = txtName.Text;
            tech.ContactNum = txtContactNum.Text;

            foreach (ListViewItem i in lstSkills.Items)
            {
                skills.Add((Service) i.Tag);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Service skill = (Service)cbxServices.SelectedItem;

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
