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

            string Description = textBox4.Text;
            ServiceLevelAgreement SLA = new ServiceLevelAgreement(Description);

            ServiceLevelAgreementController SLActr = new ServiceLevelAgreementController();

            SLActr.Create(SLA);

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
            gbxService.Visible = true;
        }

        private void btnService_Click(object sender, EventArgs e)
        {

            //Service Object list and Controler
            List<Service> List_Of_Services_Ob = new List<Service>();
            ServiceController S_ctr = new ServiceController();

            string Service_Description = txtServiceDescription.Text;

            int Service_Duration = int.Parse(txtServiceDuration.Text);

            Service newService = new Service(Service_Description, Service_Duration);

            ServiceController Servicectr = new ServiceController();

            //Construct a message to notify the user  of any Changes     

        }// Inserting New Service Fucntionality (Done)
    }
}
