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

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmEditServiceCon : Form
    {

        List<ServiceContract> List_Of_Service_Contract_OB = new List<ServiceContract>();

        List<Package> NewPackagesForSC = new List<Package>();

        private SCLogic SC_L = new SCLogic();

        private List<Package> Place_Holer_Package_List = new List<Package>();

        private PackageLogic P_L = new PackageLogic();

        private ServiceContract sc;


        public frmEditServiceCon(ServiceContract SC)
        {
            InitializeComponent();
            this.sc = SC;
        }

        private void frmEditServiceCon_Load(object sender, EventArgs e)
        {
             Loadpackage();
            //Populate the Service Contacts 

            Place_Holer_Package_List = P_L.ViewPackage();

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
        }
    }
}
