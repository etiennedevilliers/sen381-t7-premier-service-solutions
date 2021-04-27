
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmNewClient
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
            this.tpcNewClient = new System.Windows.Forms.TabControl();
            this.tpgIndividualNew = new System.Windows.Forms.TabPage();
            this.btnIndividualNew = new System.Windows.Forms.Button();
            this.lblSurnameI = new System.Windows.Forms.Label();
            this.txtSurnameNewI = new System.Windows.Forms.TextBox();
            this.lblNameI = new System.Windows.Forms.Label();
            this.txtNameNewI = new System.Windows.Forms.TextBox();
            this.tpgBusinessNew = new System.Windows.Forms.TabPage();
            this.btnNewBusiness = new System.Windows.Forms.Button();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.txtBusinessNameNew = new System.Windows.Forms.TextBox();
            this.tpcNewClient.SuspendLayout();
            this.tpgIndividualNew.SuspendLayout();
            this.tpgBusinessNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpcNewClient
            // 
            this.tpcNewClient.Controls.Add(this.tpgIndividualNew);
            this.tpcNewClient.Controls.Add(this.tpgBusinessNew);
            this.tpcNewClient.Location = new System.Drawing.Point(12, 12);
            this.tpcNewClient.Name = "tpcNewClient";
            this.tpcNewClient.SelectedIndex = 0;
            this.tpcNewClient.Size = new System.Drawing.Size(615, 325);
            this.tpcNewClient.TabIndex = 0;
            // 
            // tpgIndividualNew
            // 
            this.tpgIndividualNew.Controls.Add(this.btnIndividualNew);
            this.tpgIndividualNew.Controls.Add(this.lblSurnameI);
            this.tpgIndividualNew.Controls.Add(this.txtSurnameNewI);
            this.tpgIndividualNew.Controls.Add(this.lblNameI);
            this.tpgIndividualNew.Controls.Add(this.txtNameNewI);
            this.tpgIndividualNew.Location = new System.Drawing.Point(4, 25);
            this.tpgIndividualNew.Name = "tpgIndividualNew";
            this.tpgIndividualNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpgIndividualNew.Size = new System.Drawing.Size(607, 296);
            this.tpgIndividualNew.TabIndex = 0;
            this.tpgIndividualNew.Text = "Individual";
            this.tpgIndividualNew.UseVisualStyleBackColor = true;
            // 
            // btnIndividualNew
            // 
            this.btnIndividualNew.Location = new System.Drawing.Point(130, 87);
            this.btnIndividualNew.Name = "btnIndividualNew";
            this.btnIndividualNew.Size = new System.Drawing.Size(75, 23);
            this.btnIndividualNew.TabIndex = 13;
            this.btnIndividualNew.Text = "Add";
            this.btnIndividualNew.UseVisualStyleBackColor = true;
            this.btnIndividualNew.Click += new System.EventHandler(this.btnIndividualNew_Click);
            // 
            // lblSurnameI
            // 
            this.lblSurnameI.AutoSize = true;
            this.lblSurnameI.Location = new System.Drawing.Point(6, 37);
            this.lblSurnameI.Name = "lblSurnameI";
            this.lblSurnameI.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameI.TabIndex = 12;
            this.lblSurnameI.Text = "Surname";
            // 
            // txtSurnameNewI
            // 
            this.txtSurnameNewI.Location = new System.Drawing.Point(105, 34);
            this.txtSurnameNewI.Name = "txtSurnameNewI";
            this.txtSurnameNewI.Size = new System.Drawing.Size(100, 22);
            this.txtSurnameNewI.TabIndex = 11;
            // 
            // lblNameI
            // 
            this.lblNameI.AutoSize = true;
            this.lblNameI.Location = new System.Drawing.Point(6, 9);
            this.lblNameI.Name = "lblNameI";
            this.lblNameI.Size = new System.Drawing.Size(45, 17);
            this.lblNameI.TabIndex = 10;
            this.lblNameI.Text = "Name";
            // 
            // txtNameNewI
            // 
            this.txtNameNewI.Location = new System.Drawing.Point(105, 6);
            this.txtNameNewI.Name = "txtNameNewI";
            this.txtNameNewI.Size = new System.Drawing.Size(100, 22);
            this.txtNameNewI.TabIndex = 9;
            // 
            // tpgBusinessNew
            // 
            this.tpgBusinessNew.Controls.Add(this.btnNewBusiness);
            this.tpgBusinessNew.Controls.Add(this.lblBusinessName);
            this.tpgBusinessNew.Controls.Add(this.txtBusinessNameNew);
            this.tpgBusinessNew.Location = new System.Drawing.Point(4, 25);
            this.tpgBusinessNew.Name = "tpgBusinessNew";
            this.tpgBusinessNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBusinessNew.Size = new System.Drawing.Size(607, 296);
            this.tpgBusinessNew.TabIndex = 1;
            this.tpgBusinessNew.Text = "Business";
            this.tpgBusinessNew.UseVisualStyleBackColor = true;
            // 
            // btnNewBusiness
            // 
            this.btnNewBusiness.Location = new System.Drawing.Point(149, 52);
            this.btnNewBusiness.Name = "btnNewBusiness";
            this.btnNewBusiness.Size = new System.Drawing.Size(75, 23);
            this.btnNewBusiness.TabIndex = 14;
            this.btnNewBusiness.Text = "Add";
            this.btnNewBusiness.UseVisualStyleBackColor = true;
            this.btnNewBusiness.Click += new System.EventHandler(this.btnNewBusiness_Click);
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(6, 9);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(106, 17);
            this.lblBusinessName.TabIndex = 10;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessNameNew
            // 
            this.txtBusinessNameNew.Location = new System.Drawing.Point(124, 6);
            this.txtBusinessNameNew.Name = "txtBusinessNameNew";
            this.txtBusinessNameNew.Size = new System.Drawing.Size(100, 22);
            this.txtBusinessNameNew.TabIndex = 9;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 434);
            this.Controls.Add(this.tpcNewClient);
            this.Name = "frmNewClient";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.frmNewClient_Load);
            this.tpcNewClient.ResumeLayout(false);
            this.tpgIndividualNew.ResumeLayout(false);
            this.tpgIndividualNew.PerformLayout();
            this.tpgBusinessNew.ResumeLayout(false);
            this.tpgBusinessNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpcNewClient;
        private System.Windows.Forms.TabPage tpgIndividualNew;
        private System.Windows.Forms.Button btnIndividualNew;
        private System.Windows.Forms.Label lblSurnameI;
        private System.Windows.Forms.TextBox txtSurnameNewI;
        private System.Windows.Forms.Label lblNameI;
        private System.Windows.Forms.TextBox txtNameNewI;
        private System.Windows.Forms.TabPage tpgBusinessNew;
        private System.Windows.Forms.Button btnNewBusiness;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txtBusinessNameNew;
    }
}