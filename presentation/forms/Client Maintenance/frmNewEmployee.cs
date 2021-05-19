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

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmNewEmployee : Form
    {
        public Employee newEmployee;

        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("")) 
            {
                MessageBox.Show("Please enter employee name");
            }
            else if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter employee surname");
            }
            else if (txtRole.Text.Equals(""))
            {
                MessageBox.Show("Please enter employee role");
            }
            else if (txtContactNum.Text.Equals(""))
            {
                MessageBox.Show("Please enter employee contact number");
            }
            else
            {
                newEmployee = new Employee(
                        txtName.Text,
                        txtSurname.Text,
                        txtRole.Text,
                        txtContactNum.Text
                    );

                DialogResult = DialogResult.OK;
            }
        }
    }
}
