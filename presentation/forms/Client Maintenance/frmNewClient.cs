using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            InitializeComponent();
        }


        
        private void frmNewClient_Load(object sender, EventArgs e)
        {
            DBAccess dBAccess = new DBAccess();

            Boolean isIndividual = frmClientMenu.Individual;
            Boolean isBusiness = frmClientMenu.Business;

            if (isIndividual)
            {
                TabPage tab = tpcNewClient.TabPages[0];
                //tpcNewClient.SelectTab(tab);
                tpcNewClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 0;
                //tpgIndividualNew.Show();
                //tpgBusinessNew.Hide();
            }
            else
            {
                TabPage tab = tpcNewClient.TabPages[1];
                //tpcNewClient.SelectTab(tab);
                tpcNewClient.SelectedTab = tab;

                //tpcNewClient.SelectedIndex = 1;
                //tpgBusinessNew.Show();
                //tpgIndividualNew.Hide();
            }
        }

        public static string newclientname;
        public static string newclientsurname;

        private void btnIndividualNew_Click(object sender, EventArgs e)
        {
            newclientname = txtNameNewI.Text;
            newclientsurname = txtSurnameNewI.Text;

            DBAccess objdbAccess = new DBAccess();


            if (newclientname.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newclientsurname.Equals(""))
            {
                MessageBox.Show("Please enter a client name", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO IndividualClient(name,surname)" +
                                                           "VALUES(@newclientname,@newclientsurname)");
                insertCommand.Parameters.AddWithValue("@newclientname", newclientname);
                insertCommand.Parameters.AddWithValue("@newclientsurname", newclientsurname);

                objdbAccess.executeQuery(insertCommand);


                MessageBox.Show("Individual Client add successful, returning to Client Menu", "INDIVIDUAL CLIENT ADDED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }


        }

        public static string newbusinessclient;

        private void btnNewBusiness_Click(object sender, EventArgs e)
        {
            newbusinessclient = txtBusinessNameNew.Text;

            DBAccess objdbAccess = new DBAccess();

            if (newbusinessclient.Equals(""))
            {
                MessageBox.Show("Please enter a business client name", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO IndividualClient(name)" +
                                                           "VALUES(@newbusinessclient)");
                insertCommand.Parameters.AddWithValue("@newbusinessclient", newbusinessclient);
                
                objdbAccess.executeQuery(insertCommand);

                MessageBox.Show("Business Client add successful, returning to Client Menu", " BUSINESS CLIENT ADDED",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmClientMenu form = new frmClientMenu();
                form.ShowDialog();
                Show();
            }
            
        }
    }
}
