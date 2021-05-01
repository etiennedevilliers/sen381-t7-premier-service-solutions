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
    public partial class frmAddServiceContract : Form
    {
        List<ServiceContract> List_Of_Service_Contract_OB = new List<ServiceContract>();
        private  SCLogic SC_L = new SCLogic();
        private  List<Package> Place_Holer_Package_List = new List<Package>();
        private PackageLogic P_L = new PackageLogic();

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
                MessageBox.Show("Please Select a Service", "EMPTY VALUE!!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Package NewPackage;

                NewPackage = Place_Holer_Package_List[cmbPackage.SelectedIndex];

                ListViewItem lst = new ListViewItem(new string[]
                {
                    NewPackage.Id.ToString(),
                    NewPackage.Service.Id.ToString(),
                    NewPackage.Sla.Id.ToString(),
                    NewPackage.Name,
                    NewPackage.Description
                });

                listPackage.Items.Add(lst);
                //Also add to the Service Contract

            }
  
        }
    }
}
