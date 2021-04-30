namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmAddServiceContractToClient
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblServiceContract = new System.Windows.Forms.Label();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(462, 94);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(396, 31);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(462, 144);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(396, 31);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(26, 17);
            this.lblClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(70, 25);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "label3";
            // 
            // lblServiceContract
            // 
            this.lblServiceContract.AutoSize = true;
            this.lblServiceContract.Location = new System.Drawing.Point(26, 60);
            this.lblServiceContract.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServiceContract.Name = "lblServiceContract";
            this.lblServiceContract.Size = new System.Drawing.Size(70, 25);
            this.lblServiceContract.TabIndex = 5;
            this.lblServiceContract.Text = "label3";
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(440, 631);
            this.btnEndCall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(422, 44);
            this.btnEndCall.TabIndex = 6;
            this.btnEndCall.Text = "End Call and Add Service Contract";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(26, 198);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(110, 25);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "errorLabel";
            // 
            // frmAddServiceContractToClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 698);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.lblServiceContract);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAddServiceContractToClient";
            this.Text = "frmAddServiceContractToClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblServiceContract;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label errorLabel;
    }
}