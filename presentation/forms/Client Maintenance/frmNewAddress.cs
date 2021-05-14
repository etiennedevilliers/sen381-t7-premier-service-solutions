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
        public Address addRes = null;

        public static Address GetAddress()
        {
            frmNewAddress frm = new frmNewAddress();
            frm.ShowDialog();
            return frm.addRes;
           
        }

        private frmNewAddress()
        {
            InitializeComponent();
        }


        public static string newcountry;
        public static string newprovince;
        public static string newdistrict;
        public static string newlocality;
        public static string newpostal;
        public static string newstreet;
        public static string newpremise;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newcountry = tbCountry.Text;
            newprovince = tbProvince.Text;
            newdistrict = tbDistrict.Text;
            newlocality = tbLocality.Text;
            newpostal = tbPostal.Text;
            newstreet = tbStreet.Text;
            newpremise = tbPremise.Text;



            if (newcountry.Equals(""))
            {
                MessageBox.Show("Please enter country", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if (newprovince.Equals("")) 
            { 
                MessageBox.Show("Please enter a province", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return; 
            }
            else if (newdistrict.Equals(""))
            {
                MessageBox.Show("Please enter a district", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newlocality.Equals(""))
            {
                MessageBox.Show("Please enter a locality", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newpostal.Equals(""))
            {
                MessageBox.Show("Please enter postal code", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newstreet.Equals(""))
            {
                MessageBox.Show("Please enter a street address", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return; 
            }
            else if (newpremise.Equals(""))
            {
                MessageBox.Show("Please enter premise", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //clientcontrol.address();

                this.addRes = new Address(
                       newcountry,
                       newprovince,
                       newdistrict,
                       newlocality,
                       newpostal,
                       newstreet,
                       newpremise
                     );


                Close();
  
            }
        }
    }
}
