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
    public partial class frmAddPackage : Form
    {

        List<Package> List_Of_Package_Ob = new List<Package>();

        private List<ServiceLevelAgreement> Placeholder_SLA_List = new List<ServiceLevelAgreement>();
        private List<Service> Placeholder_Service_List = new List<Service>();
        private List<EquipmentCategory> Placeholder_EQC_List = new List<EquipmentCategory>();

        private PackageLogic P_L = new PackageLogic();
        private ServiceLogic S_L = new ServiceLogic();
        private SLALogic SLA_L = new SLALogic();
        private EquipmentCategoryLogic EQC_L = new EquipmentCategoryLogic();


        private Package newPackage;

        private string Description;
        private string Name;
        private Service service;
        private ServiceLevelAgreement sla;
        private EquipmentCategory EQC;


        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void txtPDiscript_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPackage1_Click(object sender, EventArgs e)
        {
            //Here we call from the Service Contract logic
            if (txtPDiscript.Text.Equals(""))
            {
                MessageBox.Show("Please enter Package description details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data validation
            if (txtPName.Text.Equals(""))
            {
                MessageBox.Show("Please enter package name details", "EMPTY FIELDS!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data Validation
            if (cmbPService.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Service", "EMPTY VALUE!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbPSLA.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Service Level Agreemnt", "EMPTY VALUE!!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Description = txtPDiscript.Text;
                Name = txtPName.Text;

                service = Placeholder_Service_List[cmbPService.SelectedIndex];
                sla = Placeholder_SLA_List[cmbPSLA.SelectedIndex];
                EQC = Placeholder_EQC_List[cbxEquitptmentCatagory.SelectedIndex];

                newPackage = new Package(Name, Description, service, sla,EQC);

                P_L.Addpackage(newPackage);

                MessageBox.Show("Service successfully Added", " ADD",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Perform Fom transition
                Hide();
                frmServiceContract form = new frmServiceContract();
                form.ShowDialog();
            }

        }//Add a Package

        void loadList()
        {
            // Display the services
            List_Of_Package_Ob = P_L.ViewPackage();

            foreach (Package P in List_Of_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    P.Id.ToString(),
                    P.Service.ToString(),
                    P.Sla.ToString(),
                    P.Name,
                    P.Description
               });

                lst.Tag = P;
            }


        }//Load the Packages 

        private void frmAddPackage_Load(object sender, EventArgs e)
        {
            loadList();

            //Populate the comboboxes
            Placeholder_Service_List = S_L.ViewServices();
            Placeholder_SLA_List = SLA_L.ViewSLA();
            Placeholder_EQC_List = EQC_L.viewEquiptmentCatagory();


            foreach (Service S in S_L.ViewServices())
            {
                cmbPService.Items.Add("Service ID: " + S.Id.ToString() + "  " + S.Description);
            }

            foreach (ServiceLevelAgreement S in SLA_L.ViewSLA())
            {
                cmbPSLA.Items.Add("SLA ID: " + S.Id.ToString() + " " + S.Description);
            }

            foreach (EquipmentCategory EC in EQC_L.viewEquiptmentCatagory())
            {
                cbxEquitptmentCatagory.Items.Add("EQC Name: " + EC.Name);
            }

          

        }//Load the listof packages
    }
}
