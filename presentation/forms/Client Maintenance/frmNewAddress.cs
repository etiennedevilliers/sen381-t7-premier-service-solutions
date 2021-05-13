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
    public partial class frmNewAddress : Form
    {
        public Address addRes = null;

        public frmNewAddress()
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

            ClientController clientcontrol = new ClientController();

            Address address = new Address(
                newcountry,
                newprovince,
                newdistrict,
                newlocality,
                newpostal,
                newstreet,
                newpremise
              );

            if (newcountry.Equals(""))
            {
                MessageBox.Show("Please enter country", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newprovince.Equals("")) 
            { 
                MessageBox.Show("Please enter a province", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return; 
            }
            if (newdistrict.Equals(""))
            {
                MessageBox.Show("Please enter a district", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newlocality.Equals(""))
            {
                MessageBox.Show("Please enter a locality", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newpostal.Equals(""))
            {
                MessageBox.Show("Please enter postal code", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (newstreet.Equals(""))
            {
                MessageBox.Show("Please enter a street address", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return; 
            }
            if (newpremise.Equals(""))
            {
                MessageBox.Show("Please enter premise", "EMPTY FIELDS!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //clientcontrol.address();

                MessageBox.Show("Address add successful, returning to View", "ADDRESS ADDED",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frmNewAddress form = new frmNewAddress();
                form.ShowDialog();
  
            }





            Close();
        }
    }
}
