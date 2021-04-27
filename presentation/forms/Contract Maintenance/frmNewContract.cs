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

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmNewContract : Form
    {

        private ServiceContract Service_Contract;
        public frmNewContract()
        {
            InitializeComponent();
        }


        private void frmNewContract_Load(object sender, EventArgs e)
        {

            //Populate Package Combo Boxes with service and service level agreement Objects
            gbrxServiceLevelAgreement.Visible = false;
            gbxService.Visible = false;
            gbPackage.Visible = false;
            grbxServiceContracts.Visible = false;
           

            ServiceLevelAgreementController SLACTR = new ServiceLevelAgreementController();
            ServiceController SCTR = new ServiceController();
            PackageController P_CTR = new PackageController();

            //Populate the Combo box with Services
            foreach (Service i in SCTR.Read())
            {
                cmbxService.Items.Add(i);
            }

            //Populate the Combo box with SLA's
            foreach (ServiceLevelAgreement i in SLACTR.Read())
            {
                cmbxSla.Items.Add(i);
            }

            foreach (Package P in P_CTR.Read())
            {
                cmbAddPackage.Items.Add(P);
            }
        }// (On form load functionality)

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// (Ignore )

        private void btnAddContracts_Click(object sender, EventArgs e)
        {
            grbxServiceContracts.Visible = true;

        }//Add Cervice Contract Visibiliity (Done)

        private void btnService_Click(object sender, EventArgs e)
        {

            //Service Object list and Controler

            List<Service> List_Of_Services_Ob = new List<Service>();

            ServiceController S_ctr = new ServiceController();

            string Service_Description = txtServiceDescription.Text; //Get the Description 

            int Service_Duration = int.Parse(txtServiceDuration.Text); //Get the Duration

            Service newService = new Service(Service_Description, Service_Duration);

            S_ctr.Create(newService);

            //Update the ListView 
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
        }// Inserting New Service Fucntionality (Done)

        private void btnAddService_Click(object sender, EventArgs e)
        {
            gbxService.Visible = true;
        }//Add Service Group Box Visibility (Done)

        private void btnAddSLA_Click(object sender, EventArgs e)
        {
            gbrxServiceLevelAgreement.Visible = true;
        }//Add SLA Group Box Visibility (Done)

        private void btnServiceDone_Click(object sender, EventArgs e)
        {
            gbxService.Visible = false;
            lstViewItems.Clear();
        }// Service Done Button Functionality (Done)

        private void button6_Click(object sender, EventArgs e)
        {
            gbrxServiceLevelAgreement.Visible = false;
            lstViewItems.Items.Clear();


        }// SLA Done Button Functionality (Done)

        private void btnAddServiceLevelAgreement_Click(object sender, EventArgs e)
        {
            string Description = txtSLADescription.Text;
            ServiceLevelAgreement SLA = new ServiceLevelAgreement(Description);
            ServiceLevelAgreementController SLA_ctr = new ServiceLevelAgreementController();
            SLA_ctr.Create(SLA);

            //Service Level Agreement Object List 
            List<ServiceLevelAgreement> List_Of_SLA_Ob = new List<ServiceLevelAgreement>();

            //View by SLA 
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("SLA ID");
            lstViewItems.Columns.Add("Description");

            List_Of_SLA_Ob = SLA_ctr.Read();

            foreach (ServiceLevelAgreement sla in List_Of_SLA_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                sla.Id.ToString(),
                sla.Description
               });

                lstViewItems.Items.Add(lst);
            }

        }//Add Service Level Agreement Functionality (Done)

        private void button7_Click(object sender, EventArgs e)
        {
            lstViewItems.Items.Clear();
            gbPackage.Visible = false;

        }// Package Done Button Fucntionlality (Done)

        private void button8_Click(object sender, EventArgs e)
        {

            //Package Object list and Controler
            List<Package> List_Of_Package_Ob = new List<Package>();
            PackageController P_ctr = new PackageController();

            

            string Name = txtPname.Text;
            string Dis = txtPDis.Text;

            Service s = cmbxService.SelectedItem as Service;

            ServiceLevelAgreement sla = cmbxSla.SelectedItem as ServiceLevelAgreement;

            Package P = new Package(Name, Dis, s, sla);

            P_ctr.Create(P);

            //Update list view
            //View by Package 
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("Package ID");
            lstViewItems.Columns.Add("Service ID");
            lstViewItems.Columns.Add("Service Level Agreement");
            lstViewItems.Columns.Add("Package Name");
            lstViewItems.Columns.Add("Package Description");

            List_Of_Package_Ob = P_ctr.Read();

            foreach (Package p in List_Of_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                  p.Id.ToString(),
                  p.Service.ToString(),
                  p.Sla.ToString(),
                  p.Name,
                  p.Description
               });

                lstViewItems.Items.Add(lst);
            }
        }// Add Package Functionality(Done)

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            gbPackage.Visible = true;
        }//Add Pcakge Group Box Visibility (Done)

        private void btnSCDone_Click(object sender, EventArgs e)
        {
            grbxServiceContracts.Visible = false;
        }//Remove SC Group box visibility

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            List<ServiceContract> List_of_Service_Contrcat_Ob = new List<ServiceContract>();

            ServiceContractController SC_Ctr = new ServiceContractController();

            string Description = txtPDis.Text;
            double cost = double.Parse(txtCost.Text);
            string status = txtStatus.Text;
            DateTime DateFinal = dtpDateFianal.Value;
            DateTime DateTerm = dtpDateTer.Value;

            ServiceContract SC = new ServiceContract(Description,cost,DateFinal,DateTerm,status,"A1234560000");
            Service_Contract = SC;
            Package Pack = cmbAddPackage.SelectedItem as Package;

            SC_Ctr.Create(SC);
            SC_Ctr.Add(Pack, SC);

            //View the Service Contracts
            lstViewItems.Clear();
            lstViewItems.Columns.Add("Service Contract ID");
            lstViewItems.Columns.Add("Description");
            lstViewItems.Columns.Add("Date Finilized");
            lstViewItems.Columns.Add("Date Terminiated");
            lstViewItems.Columns.Add("Cost");
            lstViewItems.Columns.Add("Status");
            lstViewItems.Columns.Add("Identifier");

            List_of_Service_Contrcat_Ob = SC_Ctr.Read();

            foreach (ServiceContract sc in List_of_Service_Contrcat_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                    sc.Id.ToString(),
                    sc.Id.ToString(),
                    sc.Description,
                    sc.DateFinalised.ToString(),
                    sc.Cost.ToString(),
                    sc.Status,
                    SC.identifier
               });

                lstViewItems.Items.Add(lst);
            }

        }//Add Service Contract Functionality

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAddAnotherPack_Click(object sender, EventArgs e)
        {


          

        }
    }
}//Code By Ruben 
