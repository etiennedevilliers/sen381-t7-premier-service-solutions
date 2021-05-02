
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmNewBusinessClient
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
            this.lblbusicontact = new System.Windows.Forms.Label();
            this.txtnewbusicontact = new System.Windows.Forms.TextBox();
            this.btnNewBusiness = new System.Windows.Forms.Button();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.txtBusinessNameNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbusicontact
            // 
            this.lblbusicontact.AutoSize = true;
            this.lblbusicontact.Location = new System.Drawing.Point(34, 35);
            this.lblbusicontact.Name = "lblbusicontact";
            this.lblbusicontact.Size = new System.Drawing.Size(103, 17);
            this.lblbusicontact.TabIndex = 21;
            this.lblbusicontact.Text = "Contact Details";
            // 
            // txtnewbusicontact
            // 
            this.txtnewbusicontact.Location = new System.Drawing.Point(152, 32);
            this.txtnewbusicontact.Name = "txtnewbusicontact";
            this.txtnewbusicontact.Size = new System.Drawing.Size(159, 22);
            this.txtnewbusicontact.TabIndex = 20;
            // 
            // btnNewBusiness
            // 
            this.btnNewBusiness.Location = new System.Drawing.Point(236, 116);
            this.btnNewBusiness.Name = "btnNewBusiness";
            this.btnNewBusiness.Size = new System.Drawing.Size(75, 23);
            this.btnNewBusiness.TabIndex = 19;
            this.btnNewBusiness.Text = "Add";
            this.btnNewBusiness.UseVisualStyleBackColor = true;
            this.btnNewBusiness.Click += new System.EventHandler(this.btnNewBusiness_Click);
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(34, 63);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(106, 17);
            this.lblBusinessName.TabIndex = 18;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessNameNew
            // 
            this.txtBusinessNameNew.Location = new System.Drawing.Point(152, 60);
            this.txtBusinessNameNew.Name = "txtBusinessNameNew";
            this.txtBusinessNameNew.Size = new System.Drawing.Size(159, 22);
            this.txtBusinessNameNew.TabIndex = 17;
            // 
            // frmNewBusinessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 264);
            this.Controls.Add(this.lblbusicontact);
            this.Controls.Add(this.txtnewbusicontact);
            this.Controls.Add(this.btnNewBusiness);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.txtBusinessNameNew);
            this.Name = "frmNewBusinessClient";
            this.Text = "frmNewBusinessClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbusicontact;
        private System.Windows.Forms.TextBox txtnewbusicontact;
        private System.Windows.Forms.Button btnNewBusiness;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txtBusinessNameNew;
    }
}