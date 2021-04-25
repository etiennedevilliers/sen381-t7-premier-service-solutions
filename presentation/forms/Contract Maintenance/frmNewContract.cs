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

namespace Presentation.Forms.Contract_Maintenance
{
    public partial class frmNewContract : Form
    {
        public frmNewContract()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Description = textBox2.Text;
            int Duration = int.Parse(textBox3.Text);

            Service newService = new Service(Description,Duration);

            ServiceController Servicectr = new ServiceController();

            Servicectr.Create(newService);


        }

        private void frmNewContract_Load(object sender, EventArgs e)
        {
            gbrxServiceLevelAgreement.Visible = false;
            gbxService.Visible = false;

            ServiceLevelAgreementController SLACTR = new ServiceLevelAgreementController();
            ServiceController SCTR = new ServiceController();

            foreach (Service i in SCTR.Read())
            {
                comboBox1.Items.Add(i);
            }

            foreach (ServiceLevelAgreement i in SLACTR.Read())
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {

            PackageController PCtr = new PackageController();
            
            string Name = textBox5.Text;
            string Dis = textBox6.Text;

            Service s = comboBox1.SelectedItem as Service;

            ServiceLevelAgreement sla = comboBox2.SelectedItem as ServiceLevelAgreement;

            Package P = new Package(Name,Dis,s,sla);
            PCtr.Create(P);

        }

        private void btnAddContracts_Click(object sender, EventArgs e)
        {
           
        }

        private void btnService_Click(object sender, EventArgs e)
        {

            //Service Object list and Controler

            List<Service> List_Of_Services_Ob = new List<Service>();

            ServiceController S_ctr = new ServiceController();

            string Service_Description = txtServiceDescription.Text; //Get the Description 

            int Service_Duration = int.Parse(txtServiceDuration.Text); //Get the Duration

            Service newService = new Service(Service_Description, Service_Duration);

            S_ctr.Create(newService);

            //Update the ListView 
            //View By Services
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("Service ID");
            lstViewItems.Columns.Add("Service Description");
            lstViewItems.Columns.Add("Duration");

            List_Of_Services_Ob = S_ctr.Read();

            foreach (Service S in List_Of_Services_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]
                {
                    S.Id.ToString(),
                    S.Description,
                    S.ExpectedDuration.ToString()
                });

                lstViewItems.Items.Add(lst);
            }
        }// Inserting New Service Fucntionality (Done)

        private void btnAddService_Click(object sender, EventArgs e)
        {
            gbxService.Visible = true;
        }//Add Service Group Box Visibility (Done)

        private void btnAddSLA_Click(object sender, EventArgs e)
        {
            gbrxServiceLevelAgreement.Visible = true;
        }//Add SLA Group Box Visibility (Done)

        private void btnServiceDone_Click(object sender, EventArgs e)
        {
            gbxService.Visible = false;
            lstViewItems.Clear();
        }// Service Done Button Functionality (Done)

        private void button6_Click(object sender, EventArgs e)
        {
            gbrxServiceLevelAgreement.Visible = false;
            lstViewItems.Items.Clear();


        }// SLA Done Button Functionality (Done)

        private void btnAddServiceLevelAgreement_Click(object sender, EventArgs e)
        {
            string Description = txtSLADescription.Text;
            ServiceLevelAgreement SLA = new ServiceLevelAgreement(Description);
            ServiceLevelAgreementController SLA_ctr = new ServiceLevelAgreementController();
            SLA_ctr.Create(SLA);




            //Service Level Agreement Object List 
            List<ServiceLevelAgreement> List_Of_SLA_Ob = new List<ServiceLevelAgreement>();

            //View by SLA 
            lstViewItems.Columns.Clear();
            lstViewItems.Columns.Add("SLA ID");
            lstViewItems.Columns.Add("Description");


            List_Of_SLA_Ob = SLA_ctr.Read();

            foreach (ServiceLevelAgreement sla in List_Of_SLA_Ob)
            {
                ListViewItem lst = new ListViewItem(new string[]{
                sla.Id.ToString(),
                sla.Description
               });

                lstViewItems.Items.Add(lst);
            }






        }//Add Service Level Agreement Functionality (Done)
    }
}
