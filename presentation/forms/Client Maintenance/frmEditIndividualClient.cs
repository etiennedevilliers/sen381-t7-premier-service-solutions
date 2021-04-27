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

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmEditIndividualClient : Form
    {
        private IndividualClient individualClient;
        public frmEditIndividualClient(IndividualClient individualClient)
        {
            InitializeComponent();
            this.individualClient = individualClient;



            tbName.Text = individualClient.Name;
            tbSurname.Text = individualClient.Surname;
            tbContactDetails.Text = individualClient.ContactNum;


            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.individualClient.Name = tbName.Text;
            this.individualClient.Surname = tbSurname.Text;
            this.individualClient.ContactNum = tbContactDetails.Text;

            (new IndividualClientController()).Update(this.individualClient);

            Hide();
            
        }

        
    }
}
