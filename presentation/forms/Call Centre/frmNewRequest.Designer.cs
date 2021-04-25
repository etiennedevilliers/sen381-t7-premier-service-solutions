
namespace Presentation.Forms.CallCentre
{
    partial class FrmNewRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbExistingClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnNewClientRequest = new System.Windows.Forms.Button();
            this.btnComplaintRequest = new System.Windows.Forms.Button();
            this.btnNewContractRequest = new System.Windows.Forms.Button();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.cbComplaintServiceContract = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComplaintDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNewContractRequestServiceContract = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbServiceRequestServiceContract = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbExistingClient);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // cbExistingClient
            // 
            this.cbExistingClient.FormattingEnabled = true;
            this.cbExistingClient.Location = new System.Drawing.Point(6, 47);
            this.cbExistingClient.Name = "cbExistingClient";
            this.cbExistingClient.Size = new System.Drawing.Size(253, 21);
            this.cbExistingClient.TabIndex = 0;
            this.cbExistingClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Existing Cient(Leave blank for new)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Service Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(287, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 410);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnNewClientRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Client Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbComplaintDescription);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbComplaintServiceContract);
            this.tabPage2.Controls.Add(this.btnComplaintRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cbNewContractRequestServiceContract);
            this.tabPage3.Controls.Add(this.btnNewContractRequest);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(424, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "New Contract Request";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.cbServiceRequestServiceContract);
            this.tabPage4.Controls.Add(this.btnServiceRequest);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(424, 381);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Service Request";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnNewClientRequest
            // 
            this.btnNewClientRequest.Location = new System.Drawing.Point(297, 352);
            this.btnNewClientRequest.Name = "btnNewClientRequest";
            this.btnNewClientRequest.Size = new System.Drawing.Size(121, 23);
            this.btnNewClientRequest.TabIndex = 0;
            this.btnNewClientRequest.Text = "Create New Client";
            this.btnNewClientRequest.UseVisualStyleBackColor = true;
            this.btnNewClientRequest.Click += new System.EventHandler(this.btnNewClientRequest_Click);
            // 
            // btnComplaintRequest
            // 
            this.btnComplaintRequest.Location = new System.Drawing.Point(289, 352);
            this.btnComplaintRequest.Name = "btnComplaintRequest";
            this.btnComplaintRequest.Size = new System.Drawing.Size(128, 23);
            this.btnComplaintRequest.TabIndex = 0;
            this.btnComplaintRequest.Text = "Create Complaint";
            this.btnComplaintRequest.UseVisualStyleBackColor = true;
            // 
            // btnNewContractRequest
            // 
            this.btnNewContractRequest.Location = new System.Drawing.Point(302, 355);
            this.btnNewContractRequest.Name = "btnNewContractRequest";
            this.btnNewContractRequest.Size = new System.Drawing.Size(119, 23);
            this.btnNewContractRequest.TabIndex = 0;
            this.btnNewContractRequest.Text = "Create New Contract Request";
            this.btnNewContractRequest.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Location = new System.Drawing.Point(263, 355);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Size = new System.Drawing.Size(154, 23);
            this.btnServiceRequest.TabIndex = 0;
            this.btnServiceRequest.Text = "Create Service Request";
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            // 
            // cbComplaintServiceContract
            // 
            this.cbComplaintServiceContract.FormattingEnabled = true;
            this.cbComplaintServiceContract.Location = new System.Drawing.Point(9, 26);
            this.cbComplaintServiceContract.Name = "cbComplaintServiceContract";
            this.cbComplaintServiceContract.Size = new System.Drawing.Size(407, 21);
            this.cbComplaintServiceContract.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Service Contract from Client";
            // 
            // tbComplaintDescription
            // 
            this.tbComplaintDescription.Location = new System.Drawing.Point(9, 76);
            this.tbComplaintDescription.Multiline = true;
            this.tbComplaintDescription.Name = "tbComplaintDescription";
            this.tbComplaintDescription.Size = new System.Drawing.Size(407, 270);
            this.tbComplaintDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // cbNewContractRequestServiceContract
            // 
            this.cbNewContractRequestServiceContract.FormattingEnabled = true;
            this.cbNewContractRequestServiceContract.Location = new System.Drawing.Point(4, 26);
            this.cbNewContractRequestServiceContract.Name = "cbNewContractRequestServiceContract";
            this.cbNewContractRequestServiceContract.Size = new System.Drawing.Size(413, 21);
            this.cbNewContractRequestServiceContract.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Service Contract";
            // 
            // cbServiceRequestServiceContract
            // 
            this.cbServiceRequestServiceContract.FormattingEnabled = true;
            this.cbServiceRequestServiceContract.Location = new System.Drawing.Point(4, 24);
            this.cbServiceRequestServiceContract.Name = "cbServiceRequestServiceContract";
            this.cbServiceRequestServiceContract.Size = new System.Drawing.Size(413, 21);
            this.cbServiceRequestServiceContract.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Service Contract From Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter Client number, the Client Maintenance Department will contact this person.";
            // 
            // FrmNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNewRequest";
            this.Text = "NewRequest";
            this.Load += new System.EventHandler(this.frmNewRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExistingClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNewClientRequest;
        private System.Windows.Forms.Button btnComplaintRequest;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnNewContractRequest;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbComplaintServiceContract;
        private System.Windows.Forms.Button btnServiceRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComplaintDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNewContractRequestServiceContract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbServiceRequestServiceContract;
        private System.Windows.Forms.Label label8;
    }
}