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

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmNewAddress : Form
    {
        public Address newAddress;

        public frmNewAddress()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text.Equals(""))
            {
                MessageBox.Show("Please enter country", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if (txtProvince.Text.Equals(""))
            { 
                MessageBox.Show("Please enter a province");
            }
            else if (txtDistrict.Text.Equals(""))
            {
                MessageBox.Show("Please enter a district");
            }
            else if (txtLocality.Text.Equals(""))
            {
                MessageBox.Show("Please enter a locality");
            }
            else if (txtPostal.Text.Equals(""))
            {
                MessageBox.Show("Please enter postal code");
            }
            else if (txtStreetAddress.Text.Equals(""))
            {
                MessageBox.Show("Please enter a street address");
            }
            else if (txtPremise.Text.Equals(""))
            {
                MessageBox.Show("Please enter premise");
            }
            else
            {
                newAddress = new Address(
                       txtCountry.Text,
                       txtProvince.Text,
                       txtDistrict.Text,
                       txtLocality.Text,
                       txtPostal.Text,
                       txtStreetAddress.Text,
                       txtPremise.Text
                     );

                DialogResult = DialogResult.OK;
            }
        }
    }
}
