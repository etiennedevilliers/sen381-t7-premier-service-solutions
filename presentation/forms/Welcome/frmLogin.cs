using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Controller;
using Data.Layer.Objects;
using Presentation.Forms.ServiceDepartment;
using Presentation.Forms.CallCentre;
using Presentation.Forms.ClientMaintenance;
using Presentation.Forms.ContractMaintenance;

namespace Presentation.Forms.Welcome
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool LoggedIn = false;

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            } else if(txtPassword.Text == "") {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                AgentController agentCtr = new AgentController();

                foreach (Agent i in agentCtr.Read())
                {
                    if (txtUsername.Text == i.Username && txtPassword.Text == i.Password)
                    {
                        LoggedIn = true;

                        txtUsername.Clear();
                        txtPassword.Clear();

                        switch (i.EmployeeType)
                        {
                            case "Call Operator":
                                frmCallCentre call = new frmCallCentre(i);
                                call.ShowDialog();
                                break;

                            case "Technician":
                                frmTechnician tech = new frmTechnician(i);
                                tech.ShowDialog();
                                break;

                            case "Service Manager":
                                frmServiceManager ser = new frmServiceManager(i);
                                ser.ShowDialog();
                                break;

                            case "Contract Manager":
                                frmContractMaintenance con = new frmContractMaintenance(i);
                                con.ShowDialog();
                                break;

                            case "Client Manager":
                                frmClientMaintenance client = new frmClientMaintenance(i);
                                client.ShowDialog();
                                break;
                        }

                        break;
                    }
                }

                if (!LoggedIn)
                {
                    MessageBox.Show("Username or Password Incorrect");
                }
            }
        }
    }
}
