namespace Presentation.Forms.ContractMaintenance
{
    partial class frmAddPackage
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
            this.btnAddPackage1 = new System.Windows.Forms.Button();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPDiscript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPSLA = new System.Windows.Forms.ComboBox();
            this.cbxEquitptmentCatagory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPackage1
            // 
            this.btnAddPackage1.Location = new System.Drawing.Point(632, 467);
            this.btnAddPackage1.Name = "btnAddPackage1";
            this.btnAddPackage1.Size = new System.Drawing.Size(126, 47);
            this.btnAddPackage1.TabIndex = 2;
            this.btnAddPackage1.Text = "Add";
            this.btnAddPackage1.UseVisualStyleBackColor = true;
            this.btnAddPackage1.Click += new System.EventHandler(this.btnAddPackage1_Click);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(331, 105);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(427, 31);
            this.txtPName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // cmbPService
            // 
            this.cmbPService.FormattingEnabled = true;
            this.cmbPService.Location = new System.Drawing.Point(331, 262);
            this.cmbPService.Name = "cmbPService";
            this.cmbPService.Size = new System.Drawing.Size(427, 33);
            this.cmbPService.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Service Level Description";
            // 
            // txtPDiscript
            // 
            this.txtPDiscript.Location = new System.Drawing.Point(331, 183);
            this.txtPDiscript.Name = "txtPDiscript";
            this.txtPDiscript.Size = new System.Drawing.Size(427, 31);
            this.txtPDiscript.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // cmbPSLA
            // 
            this.cmbPSLA.FormattingEnabled = true;
            this.cmbPSLA.Location = new System.Drawing.Point(331, 332);
            this.cmbPSLA.Name = "cmbPSLA";
            this.cmbPSLA.Size = new System.Drawing.Size(427, 33);
            this.cmbPSLA.TabIndex = 8;
            // 
            // cbxEquitptmentCatagory
            // 
            this.cbxEquitptmentCatagory.FormattingEnabled = true;
            this.cbxEquitptmentCatagory.Location = new System.Drawing.Point(331, 403);
            this.cbxEquitptmentCatagory.Name = "cbxEquitptmentCatagory";
            this.cbxEquitptmentCatagory.Size = new System.Drawing.Size(427, 33);
            this.cbxEquitptmentCatagory.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Equiptemt Catagory";
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 637);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxEquitptmentCatagory);
            this.Controls.Add(this.txtPDiscript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPSLA);
            this.Controls.Add(this.cmbPService);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPackage1);
            this.Name = "frmAddPackage";
            this.Text = "frmAddPackage";
            this.Load += new System.EventHandler(this.frmAddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPackage1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPDiscript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPSLA;
        private System.Windows.Forms.ComboBox cbxEquitptmentCatagory;
        private System.Windows.Forms.Label label5;
    }
}