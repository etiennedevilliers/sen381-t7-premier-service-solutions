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
    public partial class frmEditPackages : Form
    {
        private List<Package> List_Of_Package_Ob = new List<Package>();

        private List<ServiceLevelAgreement> Placeholder_SLA_List = new List<ServiceLevelAgreement>();
        private List<Service> Placeholder_Service_List = new List<Service>();

        private Package ParsedPackage ;
        private PackageLogic P_L = new PackageLogic();
        private ServiceLogic S_L = new ServiceLogic();
        private SLALogic SLA_L = new SLALogic();

        public frmEditPackages(Package Pack)
        {
            InitializeComponent();

            ParsedPackage = Pack;
            txtPDiscript.Text = Pack.Description;
            txtPName.Text = Pack.Name;
        }


        void loadPackages()
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
        }//load packages

        private void frmEditPackages_Load(object sender, EventArgs e)
        {
            loadPackages();

            //populate the comboboxes
            Placeholder_Service_List = S_L.GetServices();
            Placeholder_SLA_List = SLA_L.ViewSLA();

            foreach (Service S in S_L.GetServices())
            {
                cmbPService.Items.Add(S_L);
            }

            foreach (ServiceLevelAgreement S in SLA_L.ViewSLA())
            {
                cmbPSLA.Items.Add(S);
            }

            cmbPService.SelectedIndex = cmbPService.Items.IndexOf(ParsedPackage.Service);
            cmbPSLA.SelectedIndex = cmbPSLA.Items.IndexOf(ParsedPackage.Sla);
        }//Populate Combo boxes and load list of packages

        private void btnEditPackage_Click(object sender, EventArgs e)
        {

            if (txtPDiscript.Text.Equals(""))
            {
                MessageBox.Show("Please enter Package Description", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPName.Text.Equals(""))
            {
                MessageBox.Show("Please enter package Name", "EMPTY FIELDS!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                this.ParsedPackage.Description = txtPDiscript.Text;
                this.ParsedPackage.Name = txtPName.Text;

                this.ParsedPackage.Service = Placeholder_Service_List[cmbPService.SelectedIndex];
                this.ParsedPackage.Sla = Placeholder_SLA_List[cmbPSLA.SelectedIndex];        

                P_L.EditPackage(this.ParsedPackage);

                MessageBox.Show("Service successfully Updated", " ADD",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }//Edit the Package
    }
}
