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
    public partial class frmAddServiceContract : Form
    {
        List<ServiceContract> List_Of_Service_Contract_OB = new List<ServiceContract>();
        List<Package> NewPackagesForSC = new List<Package>();
        private  SCLogic SC_L = new SCLogic();
        private  List<Package> Place_Holer_Package_List = new List<Package>();
        private  PackageLogic P_L = new PackageLogic();
        private string Identtifier = "";

        public frmAddServiceContract()
        {
            InitializeComponent();
        }

        private void frmAddServiceContract_Load(object sender, EventArgs e)
        {
            LoadServiceContract();

            //Populate Combo Boxes
            Place_Holer_Package_List = P_L.ViewPackage();

            foreach (Package P in P_L.ViewPackage())
            {
                cmbPackage.Items.Add( "Package ID : " +"  " + P.Id + "   Package Name :  " + P.Name);
            }

        }//Populate the Combobox and load list 

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
            }
        }//Load the list of service contracts

        private void btnAddPackage_Click(object sender, EventArgs e)
        {


            if (cmbPackage.SelectedIndex < 0 )
            {
                MessageBox.Show("Please Select a Package", "EMPTY VALUE!!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Package NewPackage = Place_Holer_Package_List[cmbPackage.SelectedIndex];

                ListViewItem lst = new ListViewItem(new string[]
                {
                    NewPackage.Id.ToString(),
                    NewPackage.Service.Id.ToString(),
                    NewPackage.Sla.Id.ToString(),
                    NewPackage.Name,
                    NewPackage.Description
                });

                NewPackagesForSC.Add(Place_Holer_Package_List[cmbPackage.SelectedIndex]);
                listPackage.Items.Add(lst);
            }
  
        }//Add Package to SC

        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            listPackage.Items.RemoveAt(listPackage.SelectedIndices[0]);
            int index = listPackage.FocusedItem.Index;
            NewPackagesForSC.RemoveAt(index);
     
        }//Remove Package form CS 

        private void btnSCOk_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Please enter Service Contract description ", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCost.Text.Equals(""))
            {
                MessageBox.Show("Please enter Service Contract cost ", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Identtifier.Equals(""))
            {
                MessageBox.Show("Please generate a Identifier", "EMPTY FIELDS!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add the packages , add the identifiers ,Create SC

                ServiceContract SC = new ServiceContract
                    (
                        txtDescription.Text,
                        double.Parse(txtCost.Text),
                        dtDateFinal.Value,
                        dtDateTer.Value,
                        "Active",
                        Identtifier
                    );

                SC_L.CreateServiceContract(SC);

                foreach (Package p in NewPackagesForSC)
                {
                    SC_L.AddPackage(p,SC);
                }

                MessageBox.Show("Service successfully Service Contract", " ADD",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            //get the Dtae 
            //get the Level of importance 

            //Buuild the Identifier 

            //Display on Tetxt box 

            if (cmbImportance.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a level of importance", "EMPTY FIELDS!!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Identtifier = SC_L.GenerateIDentifier(dtDateFinal.Value,cmbImportance.SelectedItem.ToString());
                txtIdentifier.Text = Identtifier;
            }
        }
    }
}
