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
    public partial class frmViewContract : Form
    {
        private IndividualClient indivClient; 

        public frmViewContract(IndividualClient indivClient)
        {
            InitializeComponent();

            this.indivClient = indivClient;

            tbIndivName.Text = indivClient.Name;
            tbIndivSurname.Text = indivClient.Surname;
            tbIndivContact.Text = indivClient.ContactNum;
        }

        private void frmViewContract_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.indivClient.Name = tbIndivName.Text;
            this.indivClient.Surname = tbIndivSurname.Text;
            this.indivClient.ContactNum = tbIndivContact.Text;

            (new IndividualClientController()).Update(this.indivClient);

            Hide();

        }
    }
}
