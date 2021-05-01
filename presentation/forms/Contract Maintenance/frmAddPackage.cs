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
using Logic;

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmAddPackage : Form
    {

        List<Package> List_Of_Package_Ob = new List<Package>();
        private PackageLogic P_L = new PackageLogic();


        private Package newPacage;

        private string description;
        private string Name;

        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void txtPDiscript_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPackage1_Click(object sender, EventArgs e)
        {

        }

        void loadList()
        {
            // Display the services
            List_Of_Package_Ob = P_L.ViewPackage();

            foreach (Package P in List_Of_Package_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
               {
                    P.Id.ToString(),
                    P.Service.ToString(),
                    P.Sla.ToString(),
                    P.Name,
                    P.Description
               });

                lst.Tag = P;
            }


        }//Load the Packages 
    }
}
