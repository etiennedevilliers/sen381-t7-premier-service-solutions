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

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmViewContracts : Form
    {
        //Service Contract Object List and Controller
        List<ServiceContract> List_Of_ServiceContracts_Ob = new List<ServiceContract>();
        ServiceContractController SC_ctr = new ServiceContractController();

        //Service Level Agreement Object List 
        List<ServiceLevelAgreement> List_Of_SLA_Ob = new List<ServiceLevelAgreement>();
        ServiceLevelAgreementController SLA_ctr = new ServiceLevelAgreementController();

        //Service Object list and Controler
        List<Service> List_Of_Services_Ob = new List<Service>();
        ServiceController S_ctr = new ServiceController();

        //Package Object list and Controler
        List<Package> List_Of_Package_Ob = new List<Package>();
        PackageController P_ctr = new PackageController();


        public frmViewContracts()
        {
            InitializeComponent();
        }
        private void frmViewContracts_Load(object sender, EventArgs e)
        {
            gbxSelectServiceContract.Visible = false;
        }//Ignore

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click_1(object sender, EventArgs e)
        {
            //View By Services
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("Service ID");
            lstViewItems.Columns.Add("Service Description");
            lstViewItems.Columns.Add("Duration");

            List_Of_Services_Ob = S_ctr.Read();

            foreach (Service S in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
                {
                    S.Id.ToString(),
                    S.Description,
                    S.ExpectedDuration.ToString()
                });

                lstViewItems.Items.Add(lst);
            }

        }//View By Service Functionality (Done)

        private void btnViewContracts_Click(object sender, EventArgs e)
        {
            //View By Service Contracts 

            lstViewItems.Clear();
            lstViewItems.Columns.Add("Service Contract ID");
            lstViewItems.Columns.Add("Description");
            lstViewItems.Columns.Add("Date Finilized");
            lstViewItems.Columns.Add("Date Terminiated");
            lstViewItems.Columns.Add("Cost");
            lstViewItems.Columns.Add("Status");
            List_Of_ServiceContracts_Ob = SC_ctr.Read();

            foreach (ServiceContract SC in List_Of_ServiceContracts_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                    SC.Id.ToString(),
                    SC.Id.ToString(),
                    SC.Description,
                    SC.DateFinalised.ToString(),
                    SC.Cost.ToString(),
                    SC.Status
               });

                lstViewItems.Items.Add(lst);
            }

        }//View By Contract Functinality  (Done)

        private void btnViewPacages_Click(object sender, EventArgs e)
        {
            //View by Package 
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("Package ID");
            lstViewItems.Columns.Add("Service ID");
            lstViewItems.Columns.Add("Service Level Agreement");
            lstViewItems.Columns.Add("Package Name");
            lstViewItems.Columns.Add("Package Description");

            List_Of_Package_Ob = P_ctr.Read();

            foreach (Package P in List_Of_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                  P.Id.ToString(),
                  P.Service.ToString(),
                  P.Sla.ToString(),
                  P.Name,
                  P.Description
               });

                lstViewItems.Items.Add(lst);
            }
        }//View By Package Functionality (Done)

        private void btnViewSLA_Click_1(object sender, EventArgs e)
        {
            //View by SLA 
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("SLA ID");
            lstViewItems.Columns.Add("Description");


            List_Of_SLA_Ob = SLA_ctr.Read();

            foreach (ServiceLevelAgreement SLA in List_Of_SLA_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                SLA.Id.ToString(),
                SLA.Description
               });

                lstViewItems.Items.Add(lst);
            }


        }//View By SLA Functionality (Done)

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmContractMenu form = new frmContractMenu();
            form.ShowDialog();
            form.Show();

        }//Back Button Functionality (Done) 

        private void btnPackageBySC_Click(object sender, EventArgs e)
        {
            //View the packages by the Service Contracts
            gbxSelectServiceContract.Visible = true;

            //Load the Data into the combo box

            foreach (ServiceContract SC in SC_ctr.Read())
            {
                cmbxNewpackage.Items.Add(SC);
            }
        }

        private void btnViewPackagesBySC_Click(object sender, EventArgs e)
        {
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("Package ID");
            lstViewItems.Columns.Add("Service ID");
            lstViewItems.Columns.Add("Service Level Agreement");
            lstViewItems.Columns.Add("Package Name");
            lstViewItems.Columns.Add("Package Description");

            ServiceContractController SC_Ctr = new ServiceContractController();

            ServiceContract SC_CT = cmbxNewpackage.SelectedItem as ServiceContract;

            List_Of_Package_Ob = SC_Ctr.ReadChildren(SC_CT);

            foreach (Package P in List_Of_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                  P.Id.ToString(),
                  P.Service.ToString(),
                  P.Sla.ToString(),
                  P.Name,
                  P.Description
               });

                lstViewItems.Items.Add(lst);


            }
        }

        //Code By Ruben / Etienne 
    }
}
