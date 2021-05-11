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


namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmEditBusinessClient : Form
    {
        private BusinessClient businessClient;

        public frmEditBusinessClient(BusinessClient businessClient)
        {
            InitializeComponent();

            //MessageBox.Show(businessClient.ToString());

            this.businessClient = businessClient;

            tbNameBusiness.Text = businessClient.Name;
            tbContactBusiness.Text = businessClient.ContactNum;
            tbClientID.Text = businessClient.ClientIdentifier;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.businessClient.Name = tbNameBusiness.Text;
            this.businessClient.ContactNum = tbContactBusiness.Text;
            this.businessClient.ClientIdentifier = tbClientID.Text;

            (new BusinessClientController()).Update(this.businessClient);

            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbClientID.Text = ClientMaintenanceLogic.GenerateUniqueClientID();
        }
    }
}
