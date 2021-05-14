
namespace Presentation.Forms.ClientMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbusicontact
            // 
            this.lblbusicontact.AutoSize = true;
            this.lblbusicontact.Location = new System.Drawing.Point(26, 28);
            this.lblbusicontact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbusicontact.Name = "lblbusicontact";
            this.lblbusicontact.Size = new System.Drawing.Size(79, 13);
            this.lblbusicontact.TabIndex = 21;
            this.lblbusicontact.Text = "Contact Details";
            // 
            // txtnewbusicontact
            // 
            this.txtnewbusicontact.Location = new System.Drawing.Point(114, 26);
            this.txtnewbusicontact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnewbusicontact.Name = "txtnewbusicontact";
            this.txtnewbusicontact.Size = new System.Drawing.Size(120, 20);
            this.txtnewbusicontact.TabIndex = 20;
            // 
            // btnNewBusiness
            // 
            this.btnNewBusiness.Location = new System.Drawing.Point(178, 174);
            this.btnNewBusiness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewBusiness.Name = "btnNewBusiness";
            this.btnNewBusiness.Size = new System.Drawing.Size(56, 19);
            this.btnNewBusiness.TabIndex = 19;
            this.btnNewBusiness.Text = "Add";
            this.btnNewBusiness.UseVisualStyleBackColor = true;
            this.btnNewBusiness.Click += new System.EventHandler(this.btnNewBusiness_Click);
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(26, 51);
            this.lblBusinessName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(80, 13);
            this.lblBusinessName.TabIndex = 18;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessNameNew
            // 
            this.txtBusinessNameNew.Location = new System.Drawing.Point(114, 49);
            this.txtBusinessNameNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusinessNameNew.Name = "txtBusinessNameNew";
            this.txtBusinessNameNew.Size = new System.Drawing.Size(120, 20);
            this.txtBusinessNameNew.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client ID";
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(114, 81);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.ReadOnly = true;
            this.tbClientID.Size = new System.Drawing.Size(125, 20);
            this.tbClientID.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Regenerate ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNewBusinessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbusicontact);
            this.Controls.Add(this.txtnewbusicontact);
            this.Controls.Add(this.btnNewBusiness);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.txtBusinessNameNew);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Button button1;
    }
}