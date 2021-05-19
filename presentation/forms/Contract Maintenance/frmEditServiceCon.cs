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
using Logic.ContractMaintenance;

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmEditServiceCon : Form
    {
        
        private ServiceContract sc;//Service contract that we get form the perlvious form 
        private List<Package> SelectEd_Service_Contract_packages = new List<Package>();//Contains the packages of a specific service contract  aka old list 
        private List<Package> LisPack = new List<Package>();
        private SCLogic SC_L = new SCLogic();
        private PackageLogic P_L = new PackageLogic();
        private List<Package> AllPckages = new List<Package>();
      
        public frmEditServiceCon(ServiceContract SC)
        {
            InitializeComponent();
            this.sc = SC;
            this.SelectEd_Service_Contract_packages = sc.Packages;
            this.LisPack.AddRange(SC_L.ReadChildren(sc));//Read all of the children packages 
        }

        private void frmEditServiceCon_Load(object sender, EventArgs e)
        {
            Loadpackage();
            //Load the Combo box 

            AllPckages = P_L.ViewPackage();
            foreach (Package P in P_L.ViewPackage())
            {
                cmbPackage.Items.Add(P.Description);
            }

            txtCost.Text = sc.Cost.ToString();
            txtDescription.Text = sc.Description;
            dtDateFinal.Value = sc.DateFinalised;
            dtDateTer.Value = sc.DateTerminated;

        }  //populate the combobox 

        public void Loadpackage()
        {

            foreach (Package P in SelectEd_Service_Contract_packages)
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
            Package P = AllPckages[cmbPackage.SelectedIndex];
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
            SC_L.AddPackage(P,sc);


        }//Add the package to the SC 

        private void btnRemovePackage_Click(object sender, EventArgs e)
        {
            if (listPackage.SelectedItems.Count > 0)
            {
                //Ask user for conformation
                DialogResult EditI = MessageBox.Show("Are you sure you want to Remove this Service Contrcat Package ?", "WARNING: Remove Service Contract Package",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (EditI == DialogResult.Yes)
                {

                    Package Pack = listPackage.SelectedItems[0].Tag as Package;
                  
                    SC_L.RemovePackage(Pack,sc);
                    listPackage.Items.RemoveAt(listPackage.SelectedIndices[0]);
                }
            }
            else
            {
                MessageBox.Show("No Package was selected", "SELECTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Remove Package from Sc

        private void btnSCOk_Click(object sender, EventArgs e)
        {

            sc.Cost = double.Parse(txtCost.Text);
            sc.DateFinalised = dtDateFinal.Value;
            sc.DateFinalised = dtDateTer.Value;
            sc.Description = txtDescription.Text;

            SC_L.EditServiceContract(sc);

            Close();
        }//Submit changes
    }
}
