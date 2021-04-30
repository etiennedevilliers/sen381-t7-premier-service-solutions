
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
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExistingClient = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewClientRequest = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComplaintDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbComplaintServiceContract = new System.Windows.Forms.ComboBox();
            this.btnComplaintRequest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNewContractRequestServiceContract = new System.Windows.Forms.ComboBox();
            this.btnNewContractRequest = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tbServiceRequestDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbServiceRequestServiceContract = new System.Windows.Forms.ComboBox();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(17, 70);
            this.tbContactNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(502, 31);
            this.tbContactNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Existing Cient(Leave blank for new)";
            // 
            // cbExistingClient
            // 
            this.cbExistingClient.FormattingEnabled = true;
            this.cbExistingClient.Location = new System.Drawing.Point(384, 25);
            this.cbExistingClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbExistingClient.Name = "cbExistingClient";
            this.cbExistingClient.Size = new System.Drawing.Size(502, 33);
            this.cbExistingClient.TabIndex = 0;
            this.cbExistingClient.SelectedIndexChanged += new System.EventHandler(this.cbExistingClient_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 782);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbContactNumber);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnNewClientRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(889, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Client Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(782, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter Client number, the Client Maintenance Department will contact this person.";
            // 
            // btnNewClientRequest
            // 
            this.btnNewClientRequest.Location = new System.Drawing.Point(594, 677);
            this.btnNewClientRequest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewClientRequest.Name = "btnNewClientRequest";
            this.btnNewClientRequest.Size = new System.Drawing.Size(242, 44);
            this.btnNewClientRequest.TabIndex = 0;
            this.btnNewClientRequest.Text = "Create New Client";
            this.btnNewClientRequest.UseVisualStyleBackColor = true;
            this.btnNewClientRequest.Click += new System.EventHandler(this.btnNewClientRequest_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbComplaintDescription);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbComplaintServiceContract);
            this.tabPage2.Controls.Add(this.btnComplaintRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(889, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // tbComplaintDescription
            // 
            this.tbComplaintDescription.Location = new System.Drawing.Point(18, 146);
            this.tbComplaintDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbComplaintDescription.Multiline = true;
            this.tbComplaintDescription.Name = "tbComplaintDescription";
            this.tbComplaintDescription.Size = new System.Drawing.Size(859, 516);
            this.tbComplaintDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Problematic Service Contract from Client";
            // 
            // cbComplaintServiceContract
            // 
            this.cbComplaintServiceContract.FormattingEnabled = true;
            this.cbComplaintServiceContract.Location = new System.Drawing.Point(18, 50);
            this.cbComplaintServiceContract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbComplaintServiceContract.Name = "cbComplaintServiceContract";
            this.cbComplaintServiceContract.Size = new System.Drawing.Size(810, 33);
            this.cbComplaintServiceContract.TabIndex = 1;
            // 
            // btnComplaintRequest
            // 
            this.btnComplaintRequest.Location = new System.Drawing.Point(578, 677);
            this.btnComplaintRequest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnComplaintRequest.Name = "btnComplaintRequest";
            this.btnComplaintRequest.Size = new System.Drawing.Size(256, 44);
            this.btnComplaintRequest.TabIndex = 0;
            this.btnComplaintRequest.Text = "Create Complaint";
            this.btnComplaintRequest.UseVisualStyleBackColor = true;
            this.btnComplaintRequest.Click += new System.EventHandler(this.btnComplaintRequest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cbNewContractRequestServiceContract);
            this.tabPage3.Controls.Add(this.btnNewContractRequest);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(889, 741);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "New Contract Request";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Service Contract";
            // 
            // cbNewContractRequestServiceContract
            // 
            this.cbNewContractRequestServiceContract.FormattingEnabled = true;
            this.cbNewContractRequestServiceContract.Location = new System.Drawing.Point(8, 50);
            this.cbNewContractRequestServiceContract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbNewContractRequestServiceContract.Name = "cbNewContractRequestServiceContract";
            this.cbNewContractRequestServiceContract.Size = new System.Drawing.Size(822, 33);
            this.cbNewContractRequestServiceContract.TabIndex = 1;
            // 
            // btnNewContractRequest
            // 
            this.btnNewContractRequest.Location = new System.Drawing.Point(492, 683);
            this.btnNewContractRequest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewContractRequest.Name = "btnNewContractRequest";
            this.btnNewContractRequest.Size = new System.Drawing.Size(350, 44);
            this.btnNewContractRequest.TabIndex = 0;
            this.btnNewContractRequest.Text = "Create New Contract Request";
            this.btnNewContractRequest.UseVisualStyleBackColor = true;
            this.btnNewContractRequest.Click += new System.EventHandler(this.btnNewContractRequest_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbServiceRequestDescription);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.cbServiceRequestServiceContract);
            this.tabPage4.Controls.Add(this.btnServiceRequest);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(889, 741);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Service Request";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Service Request description";
            // 
            // tbServiceRequestDescription
            // 
            this.tbServiceRequestDescription.Location = new System.Drawing.Point(8, 140);
            this.tbServiceRequestDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbServiceRequestDescription.Multiline = true;
            this.tbServiceRequestDescription.Name = "tbServiceRequestDescription";
            this.tbServiceRequestDescription.Size = new System.Drawing.Size(875, 527);
            this.tbServiceRequestDescription.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Service Contract From Client";
            // 
            // cbServiceRequestServiceContract
            // 
            this.cbServiceRequestServiceContract.FormattingEnabled = true;
            this.cbServiceRequestServiceContract.Location = new System.Drawing.Point(20, 46);
            this.cbServiceRequestServiceContract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbServiceRequestServiceContract.Name = "cbServiceRequestServiceContract";
            this.cbServiceRequestServiceContract.Size = new System.Drawing.Size(822, 33);
            this.cbServiceRequestServiceContract.TabIndex = 1;
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Location = new System.Drawing.Point(526, 683);
            this.btnServiceRequest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Size = new System.Drawing.Size(308, 44);
            this.btnServiceRequest.TabIndex = 0;
            this.btnServiceRequest.Text = "Create Service Request";
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            this.btnServiceRequest.Click += new System.EventHandler(this.btnServiceRequest_Click);
            // 
            // FrmNewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 864);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbExistingClient);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmNewRequest";
            this.Text = "NewRequest";
            this.Load += new System.EventHandler(this.frmNewRequest_Load);
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
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExistingClient;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbServiceRequestDescription;
    }
}