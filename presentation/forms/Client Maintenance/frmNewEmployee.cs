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
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    

    public partial class frmNewEmployee : Form
    {
        public Employee empl = null;

        public frmNewEmployee()
        {
            BusinessClientController businessClientController = new BusinessClientController();
            InitializeComponent();
        }

        public static Employee AddEmployee()
        {
            frmNewEmployee form = new frmNewEmployee();
            form.ShowDialog();
            return form.empl;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (tbEmpName.Equals("")) 
            {
                MessageBox.Show("Please enter employee name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            else if (tbEmpSurname.Equals(""))
            {
                MessageBox.Show("Please enter employee surname", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbEmpRole.Equals(""))
            {
                MessageBox.Show("Please enter employee role", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbEmpContact.Equals(""))
            {
                MessageBox.Show("Please enter employee contact number", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.empl = new Employee(
                    tbEmpName.Text,
                    tbEmpSurname.Text,
                    tbEmpRole.Text,
                    tbEmpContact.Text
            );
                Close();
            }


            
        }
    }
}
