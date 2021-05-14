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

namespace Presentation.Forms.ContractMaintenance
{
    public partial class frmNewSLA : Form
    {
        //Create gobal Service logic and service list  objects
        List<ServiceLevelAgreement> List_Of_SLA_Ob = new List<ServiceLevelAgreement>();
        private SLALogic Sl = new SLALogic();

        private  ServiceLevelAgreement NewSla;
        private  string SlaDescription;  

        public frmNewSLA()
        {
            InitializeComponent();
        }

        private void frmNewSLA_Load(object sender, EventArgs e)
        {
            loadList();
        }

        void loadList()
        {
            // Display the services
            List_Of_SLA_Ob = Sl.ViewSLA();

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

        private void btnAddSLA_Click(object sender, EventArgs e)
        {
            //Here we call from the SLA Contract logic

            if (txtSLADescript.Text.Equals(""))
            {
                MessageBox.Show("Please enter Service Level Agreement description details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data validation
            else
            {
                SlaDescription = txtSLADescript.Text;
                NewSla = new ServiceLevelAgreement(SlaDescription);

                Sl.AddSLA(NewSla);
                MessageBox.Show("Service successfully Added", " ADD",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                frmServiceContract form = new frmServiceContract();
                form.ShowDialog();
            }//Add the SLA
        }//Validate inputs and add SLA
    }
}
