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
    public partial class frmAddService : Form
    {

        //Create gobal Service logic and service list  objects
        List<Service> List_Of_Services_Ob = new List<Service>();
        private ServiceLogic Sl = new ServiceLogic();
    

        private Service newService;
        private string description;
        private int duration;
        

        public frmAddService()
        {
            InitializeComponent();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        { 
            loadList();

        }//Populate the list of Service objects
        

        private void btnAddService_Click(object sender, EventArgs e)
        {
            //Here we call from the Service Contract logic

            if (txtSDescript.Text.Equals(""))
            {
                MessageBox.Show("Please enter service description details", "EMPTY FIELDS!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data validation
            if (txtSDuration.Text.Equals(""))//Data Validation
            {
                MessageBox.Show("Please enter service duration details", "EMPTY FIELDS!!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Data Validation
            else
            {
                description = txtSDescript.Text;
                duration = int.Parse(txtSDuration.Text);
                newService = new Service(description, duration);

                Sl.AddService(newService);
                MessageBox.Show("Service successfully Added", " ADD",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Perform Fom transition
                Hide();
                frmServiceContract form = new frmServiceContract();
                form.ShowDialog();

            }//Add the Service
       }//Validate inputs and add service

     
        void loadList()
        {
           // Display the services
           List_Of_Services_Ob = Sl.ViewServices();

           foreach (Service S in List_Of_Services_Ob)
           {
               ListViewItem lst = new ListViewItem(new string[]
              {
                   S.Id.ToString(),
                   S.Description,
                   S.ExpectedDuration.ToString()
              });

              lst.Tag = S;
           }
        }//Load the services from Service logic

     
    }

   
}

