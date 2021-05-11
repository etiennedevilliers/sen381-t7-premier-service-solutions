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
using Logic;

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmEditServiceCon : Form
    {

        List<ServiceContract> List_Of_Service_Contract_OB = new List<ServiceContract>(); //Create a list of Service Contracts

        List<Package> NewPackagesListForSC = new List<Package>();//List of packages 

        private SCLogic SC_L = new SCLogic();//Instance of  SC logic 

        private List<Package> Place_Holer_Package_List = new List<Package>();//List of pl=placeholder packages

        private PackageLogic P_L = new PackageLogic();//Package logic

        private ServiceContract sc;//Service contract that we get form the perlvious form 


        public frmEditServiceCon(ServiceContract SC)
        {
            InitializeComponent();
            this.sc = SC;
        }

        private void frmEditServiceCon_Load(object sender, EventArgs e)
        {
             Loadpackage();
            //Populate the Service Contacts 

            Place_Holer_Package_List = P_L.ViewPackage();//Old Package list  This list wil have the OG package list 

            foreach (Package P in P_L.ViewPackage())
            {
                cmbPackage.Items.Add("Package ID : " + "  " + P.Id + "   Package Name :  " + P.Name);
            }

            txtDescription.Text = sc.Description;
            txtStat.Text = sc.Status;
            txtCost.Text = sc.Cost.ToString();
            dtDateFinal.Value = sc.DateFinalised;
            dtDateTer.Value = sc.DateTerminated;
        }  

        public void Loadpackage()
        {
            foreach (Package P in sc.Packages)
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
        }//Load all the packages of the specific Service Contract to the LIst view

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            if (cmbPackage.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Package", "EMPTY VALUE!!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Package NewPackage = Place_Holer_Package_List[cmbPackage.SelectedIndex];//Selected package item  and add that spicific item into the list view 

                ListViewItem lst = new ListViewItem(new string[]
                {
                    NewPackage.Id.ToString(),
                    NewPackage.Service.Description.ToString(),
                    NewPackage.Sla.Description.ToString(),
                    NewPackage.Name,
                    NewPackage.Description
                });

                NewPackagesListForSC.Add(NewPackage);
                listPackage.Items.Add(lst);
            }
        }//Add the package to the SC 

        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            if (listPackage.SelectedItems.Count > 0)
            {
                //Ask user for conformation
                DialogResult EditI = MessageBox.Show("Are you sure you want to Remove Package from the service contract ?", "WARNING: Remove Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (EditI == DialogResult.Yes)
                {
                    int number = listPackage.SelectedIndices[0];
                    listPackage.Items.RemoveAt(number);//Remove from listview 

                    //must remove from necly created list 
                    int index = listPackage.FocusedItem.Index;
                    Package NewPackage = Place_Holer_Package_List[index];

                    NewPackagesListForSC.Remove(NewPackage);
                }
            }
            else
            {
                MessageBox.Show("No Record was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }//Remove Package from Sc

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
            if (txtStat.Text.Equals(""))
            {
                MessageBox.Show("Please enter Service Contract status", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add the package to the specific service contract
                foreach (Package P in NewPackagesListForSC)
                {
                    SC_L.AddPackage(P,sc);
                }

                //Add the values to the specific service contract
                sc.Cost = Convert.ToDouble(txtCost.Text);
                sc.DateFinalised = dtDateFinal.Value;
                sc.DateTerminated = dtDateFinal.Value;
                sc.Description = txtDescription.Text;
                sc.Status = txtDescription.Text;

                //Edit the actual SC on the Database 


                SC_L.EditServiceContract(sc);

                //Change forms 
                frmServiceContract form = new frmServiceContract();
                DialogResult res = form.ShowDialog();

            }
        }//Submit changes
    }
}
