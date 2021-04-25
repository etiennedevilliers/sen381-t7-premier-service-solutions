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

namespace Presentation.Forms.CallCentre
{
    public partial class FrmNewRequest : Form
    {
        private CallLog callLog;
        public FrmNewRequest(CallLog callLog)
        {
            InitializeComponent();
            this.callLog = callLog;

            IndividualClientController individualClientController = new IndividualClientController();
            BusinessClientController businessClientController = new BusinessClientController();

            foreach (IndividualClient client in individualClientController.Read())
            {
                cbExistingClient.Items.Add(client);
            }

            foreach (BusinessClient client in businessClientController.Read())
            {
                cbExistingClient.Items.Add(client);
            }
        }

        private void frmNewRequest_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewClientRequest_Click(object sender, EventArgs e)
        {
            endCall();

            NewClientRequestController newClientRequestController = new NewClientRequestController();

            NewClientRequest newClientRequest = new NewClientRequest(DateTime.Now, null, callLog);

            newClientRequestController.Create(newClientRequest);
           
        }

        private void endCall()
        {
            CallLogController callLogController = new CallLogController();
            callLog.TimeEnded = DateTime.Now;
            callLogController.Create(callLog);

            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
