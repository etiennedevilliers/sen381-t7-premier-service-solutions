using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Data.Layer.Controller;
using Data.Layer.Objects;

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmAddServiceContractToClient : Form
    {
        private CallCentreLogic serviceRequestLogic;

        public frmAddServiceContractToClient(CallCentreLogic serviceRequestLogic)
        {
            InitializeComponent();

            this.serviceRequestLogic = serviceRequestLogic;
        }
    }
}
