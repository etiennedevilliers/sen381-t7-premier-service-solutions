namespace Presentation.Forms.ContractMaintenance
{
    partial class frmAddService
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
            this.lblAddServices = new System.Windows.Forms.Label();
            this.lblExpectedDuration = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtSDuration = new System.Windows.Forms.TextBox();
            this.txtSDescript = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddServices
            // 
            this.lblAddServices.AutoSize = true;
            this.lblAddServices.Location = new System.Drawing.Point(25, 49);
            this.lblAddServices.Name = "lblAddServices";
            this.lblAddServices.Size = new System.Drawing.Size(198, 25);
            this.lblAddServices.TabIndex = 0;
            this.lblAddServices.Text = "Service Description";
            // 
            // lblExpectedDuration
            // 
            this.lblExpectedDuration.AutoSize = true;
            this.lblExpectedDuration.Location = new System.Drawing.Point(25, 115);
            this.lblExpectedDuration.Name = "lblExpectedDuration";
            this.lblExpectedDuration.Size = new System.Drawing.Size(201, 25);
            this.lblExpectedDuration.TabIndex = 1;
            this.lblExpectedDuration.Text = "Expected Dureation";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(361, 166);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(193, 48);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtSDuration
            // 
            this.txtSDuration.Location = new System.Drawing.Point(250, 109);
            this.txtSDuration.Name = "txtSDuration";
            this.txtSDuration.Size = new System.Drawing.Size(304, 31);
            this.txtSDuration.TabIndex = 6;
            // 
            // txtSDescript
            // 
            this.txtSDescript.Location = new System.Drawing.Point(250, 49);
            this.txtSDescript.Name = "txtSDescript";
            this.txtSDescript.Size = new System.Drawing.Size(304, 31);
            this.txtSDescript.TabIndex = 7;
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 268);
            this.Controls.Add(this.txtSDescript);
            this.Controls.Add(this.txtSDuration);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lblExpectedDuration);
            this.Controls.Add(this.lblAddServices);
            this.Name = "frmAddService";
            this.Text = "frmAddService";
            this.Load += new System.EventHandler(this.frmAddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddServices;
        private System.Windows.Forms.Label lblExpectedDuration;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtSDuration;
        private System.Windows.Forms.TextBox txtSDescript;
    }
}