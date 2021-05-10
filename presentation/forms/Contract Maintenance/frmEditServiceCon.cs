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

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmEditServiceCon : Form
    {

        private ServiceContract sc;
        private string SCDescription;
        private string Status;
        private double SCCost;



        public frmEditServiceCon(ServiceContract SC)
        {
            InitializeComponent();
            this.sc = SC;
        }

        private void frmEditServiceCon_Load(object sender, EventArgs e)
        {

        }
    }
}
