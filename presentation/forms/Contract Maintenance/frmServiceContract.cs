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
using Logic;
using Logic.CustomExceptions;


namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmServiceContract : Form
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

        public frmServiceContract()
        {
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
            DialogResult res = form.ShowDialog();
            LoadServices();

        }//Show the add service form 

        public void LoadServices()
        {
            List_Of_Services_Ob = Sl.ViewServices();

            foreach (Service S in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    S.Id.ToString(),
                    S.Description,
                    S.ExpectedDuration.ToString()
               });
                lst.Tag = S;
                lstServiceView.Items.Add(lst);
            }

        }//Load the Services into the list view when form loads 

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {
            bool Valid = true;


            //If a item is selected in the list view perform delete 
            if (lstServiceView.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Service?", "WARNING: DELETE Service",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation


                if (deleteI == DialogResult.Yes)
                {

                    Service RService = lstServiceView.SelectedItems[0].Tag as Service;

                    //Parse the object to the Service logic to perform action

                    try
                    {
                        Sl.ServiceInPckage(RService);

                    }
                    catch (ServiceExistsException ex)
                    {

                        MessageBox.Show(string.Format("DELETION ANOMOLY {0}", ex));
                        
                        Valid = false;
                        
                    }
                    if (Valid == true)
                    {
                        Sl.Removeservice(RService);
                        MessageBox.Show("Service successfully deleted", " DELETED",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstServiceView.Clear();

                    }

                    //Hide this form and dispay the Dialog for the Service Contract Manu
                    Hide();
                    frmServiceContract form = new frmServiceContract();
                    form.ShowDialog();
                    LoadServices();
                }

            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove a service With Custom Exception

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
                    DialogResult res = form.ShowDialog();
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
            DialogResult res = form.ShowDialog();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //If a item is selected in the list view perform delete 

            bool Valid = true;

            //If a item is selected in the list view perform delete 
            if (lstSLA.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this SLA?", "WARNING: DELETE Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation


                if (deleteI == DialogResult.Yes)
                {
                    ServiceLevelAgreement RSLA = lstSLA.SelectedItems[0].Tag as ServiceLevelAgreement;

                    //Parse the object to the Service logic to perform action

                    try
                    {
                        SLAL.SLAInPackage(RSLA);



                    }
                    catch (SLAExistsException ex)
                    {

                        MessageBox.Show(string.Format("DELETION ANOMOLY {0}", ex));

                        Valid = false;
                        
                    }
                    if (Valid == true)
                    {
                        SLAL.DeleteSLA(RSLA);

                        MessageBox.Show("SLA successfully deleted", " DELETED",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstSLA.Clear();
                    }

                    frmServiceContract form = new frmServiceContract();
                    DialogResult res = form.ShowDialog();
                    LoadServices();

                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove SLA

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
                    DialogResult res = form.ShowDialog();
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
            bool Valid = false;

            if (listPackage.SelectedItems.Count > 0)
            {

                //Ask user for conformation
                DialogResult deleteI = MessageBox.Show("Are you sure you want to delete this Package?", "WARNING: DELETE Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Get user for conformation


                if (deleteI == DialogResult.Yes)
                {
                    Package RP = listPackage.SelectedItems[0].Tag as Package;

                    //Parse the object to the Service logic to perform action

                    try
                    {
                        
                        P_L.SLA_and_Service_In_Package(RP);
                    }
                    catch (PackageExictsException ex)
                    {

                        MessageBox.Show(string.Format("DELETION ANOMOLY {0}", ex));
                        Valid = true;
                    }

                    if (Valid == false)
                    {
                        P_L.RemovePackage(RP);
                        MessageBox.Show("Package successfully deleted", " DELETED",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstSLA.Clear();
                    }

                    frmServiceContract form = new frmServiceContract();
                    form.ShowDialog();
                    LoadServices();

                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove a package // (Still Not Done)

        public void LoadPackage()
        {

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

               });

                lst.Tag = P;
                listPackage.Items.Add(lst);
            }
        }//Load the Packages 

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddPackage form = new frmAddPackage();
            DialogResult res = form.ShowDialog();
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

        private void btnAddServiceContract_Click(object sender, EventArgs e)
        {
            frmAddServiceContract form = new frmAddServiceContract();
            DialogResult res = form.ShowDialog();
            LoadServiceContract();

        }//Add Service Contract

        public void LoadServiceContract()
        {
            SCLogic SC_L = new SCLogic();
            List_Of_Service_Contract_OB = SC_L.ViewServiceContrac();
            foreach (ServiceContract SC in List_Of_Service_Contract_OB)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                 SC.Id.ToString(),
                 SC.Description,
                 SC.DateFinalised.ToString(),
                 SC.DateTerminated.ToString(),
                 SC.Cost.ToString(),
                 SC.Status,
                 SC.identifier
               });

                lst.Tag = SC;
                lstServiceContract.Items.Add(lst);
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

    }

}
