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
using Logic.ContractMaintenance;
using Logic.CustomExceptions;

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmContractMaintenance : Form
    {
        //Create gobal Service logic and service list  objects
        List<Service> List_Of_Services_Ob = new List<Service>();
        ServiceLogic Sl = new ServiceLogic();
        
        List<ServiceLevelAgreement> List_Of_Sla_Ob = new List<ServiceLevelAgreement>();
        SLALogic SLAL = new SLALogic();

        List<Package> List_OF_Package_Ob = new List<Package>();
        PackageLogic P_L = new PackageLogic();

        List<ServiceContract> List_Of_Service_Contract_OB = new List<ServiceContract>();
        SCLogic SC_L = new SCLogic();

        Agent agentLoggedIn;

        public frmContractMaintenance(Agent agentLoggedIn)
        {
            this.agentLoggedIn = agentLoggedIn;
            InitializeComponent();
        }

        private void frmServiceContract_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadSLA();
            LoadPackage();
            LoadServiceContract();
        }//View list of services on load  

        ///  Service///////////////////////////////////////////////////////////////////////////////////////Service Content     
       
        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            //Call the add service form
            frmAddService form = new frmAddService();
            form.ShowDialog();
            LoadServices();
        }//Show the add service form 

        public void LoadServices()
        {
            List_Of_Services_Ob = Sl.GetServices();

            foreach (Service i in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
                {
                    i.Id.ToString(),
                    i.Description,
                    i.ExpectedDuration.ToString()
                });
                lst.Tag = i;
                lstServiceView.Items.Add(lst);
            }

        }//Load the Services into the list view when form loads

        private void btnServiceEdit_Click(object sender, EventArgs e)
        {
            if (lstServiceView.SelectedItems.Count > 0)
            {
                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to edit this Service?", "WARNING: Edit Service",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {
                    //Hide this form and dispay the Dialog for the Service Contract Manu

                    Service serv = lstServiceView.SelectedItems[0].Tag as Service;
                    frmEditService form = new frmEditService(serv);
                    form.ShowDialog();
                    LoadServices();
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Edit a selected Service

        /// Service ////////////////////////////////////////////////////////////////////////////////////////Service Content   

        /// SLA  ////////////////////////////////////////////////////////////////////////////////////////SLA Content
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewSLA form = new frmNewSLA();
            form.ShowDialog();
            LoadServices();
        

        }//Show the new SLA form 

        public void LoadSLA()
        {
            SLALogic Sl = new SLALogic();
            List_Of_Sla_Ob = Sl.ViewSLA();

            foreach (ServiceLevelAgreement S in List_Of_Sla_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    S.Id.ToString(),
                    S.Description,

               });
                lst.Tag = S;
                lstSLA.Items.Add(lst);
            }
        }//Load the SLA into the list view when form loads

        private void btnEdit_Click(object sender, EventArgs e)
        {
     
            if (lstSLA.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to edit this SLA?", "WARNING: Edit SLA",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation
                if (deleteI == DialogResult.Yes)
                {
                    //Hide this form and dispay the Dialog for the Service Contract Manu

                    ServiceLevelAgreement sla = lstSLA.SelectedItems[0].Tag as ServiceLevelAgreement;
                    frmEditSLA form = new frmEditSLA(sla);
                    form.ShowDialog();
                    LoadServices();
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }//Edit the SLA

        /// SLA  ////////////////////////////////////////////////////////////////////////////////////////SLA Colntent

        /// Package ////////////////////////////////////////////////////////////////////////////////////////Package Content

        private void button1_Click(object sender, EventArgs e)
        {

        }//Remove a package //

        public void LoadPackage()
        {
            listPackage.Items.Clear();
            List_OF_Package_Ob = P_L.ViewPackage();

            foreach (Package P in List_OF_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    P.Id.ToString(),
                    P.Service.Description,
                    P.Sla.Description,
                    P.Name,
                    P.Description,
                    P.Category.Name
               });

                lst.Tag = P;
                listPackage.Items.Add(lst);
            }
        }//Load the Packages 

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddPackage form = new frmAddPackage();
            form.ShowDialog();
            LoadPackage();

        } //Add a Package 

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            if (listPackage.SelectedItems.Count > 0)
            {
                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to Edit this Package?", "WARNING: EDIT Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteI == DialogResult.Yes)
                {
                    Package Pack = listPackage.SelectedItems[0].Tag as Package;

                    frmEditPackages form = new frmEditPackages(Pack);
                    DialogResult res = form.ShowDialog();
                    LoadPackage();

                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } //Edit a Package

        /// Package ////////////////////////////////////////////////////////////////////////////////////////Package Content

        /// Service Contract ////////////////////////////////////////////////////////////////////////////////////////Service Contract
        private void btnAddServiceContract_Click(object sender, EventArgs e)
        {
            frmAddServiceContract form = new frmAddServiceContract();
            form.ShowDialog();

            LoadServiceContract();

        }//Add Service Contract

        public void LoadServiceContract()
        {
            SCLogic SC_L = new SCLogic();
            List_Of_Service_Contract_OB = SC_L.ViewServiceContrac();

            foreach (ServiceContract i in List_Of_Service_Contract_OB)
            {
                if (i.Status == "Active")
                {
                    ListViewItem lst = new ListViewItem(new string[]
                    {
                        i.Id.ToString(),
                        i.Description,
                        i.DateFinalised.ToString(),
                        i.DateTerminated.ToString(),
                        i.Cost.ToString(),
                        i.Status,
                        i.identifier
                    });

                    lst.Tag = i;
                    lstServiceContract.Items.Add(lst);
                }
            }
        }//Load the Service Contract

        private void btnRemoveServiceContract_Click(object sender, EventArgs e)
        {
            if (lstServiceContract.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Service Contract?", "WARNING: DELETE Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation

                if (deleteI == DialogResult.Yes)
                {
                    ServiceContract RSC = lstServiceContract.SelectedItems[0].Tag as ServiceContract;
                    SC_L.DeleteServiceContract(RSC);
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditServiceContract_Click(object sender, EventArgs e)
        {
            if (lstServiceContract.SelectedItems.Count > 0)
            {
                //Ask user for conformation
                DialogResult EditI = MessageBox.Show("Are you sure you want to Edit this Service Contrcat ?", "WARNING: EDIT Service Contract",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (EditI == DialogResult.Yes)
                {

                    ServiceContract SC = lstServiceContract.SelectedItems[0].Tag as ServiceContract;

              
                    frmEditServiceCon form = new frmEditServiceCon(SC);

                    DialogResult res = form.ShowDialog();
                    LoadPackage();
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// Service Contract ////////////////////////////////////////////////////////////////////////////////////////Service Contract
    }

}
