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

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmEditSLA : Form
    {
        private ServiceLevelAgreement sla;

        List<ServiceLevelAgreement> List_Of_SLA_Ob = new List<ServiceLevelAgreement>();
        SLALogic SLA_L = new SLALogic();

        public frmEditSLA(ServiceLevelAgreement sla)
        {
            InitializeComponent();

            this.sla = sla;
            txtSLaDescription.Text = sla.Description;
        }//Construct the SLA FROm and arse a cliet from frmservice Contract 

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSLaDescription.Text.Equals(""))
            {
                MessageBox.Show("Please enter updated SLA description details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data validation
            else
            {


                this.sla.Description = txtSLaDescription.Text;
                SLA_L.UpdateSla(this.sla);
                MessageBox.Show("SLA successfully Updated", " Edit",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }//End of Else
        }//UPdate and validate the SLa

        private void frmEditSLA_Load(object sender, EventArgs e)
        {
            loadList();

        }//Load List

        void loadList()
        {
            // Display the services
            List_Of_SLA_Ob = SLA_L.ViewSLA();

            foreach (ServiceLevelAgreement S in List_Of_SLA_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                   S.Id.ToString(),
                   S.Description,
               });

                lst.Tag = S;
            }
        }//Load the SLA from SLA logic
    }
}
