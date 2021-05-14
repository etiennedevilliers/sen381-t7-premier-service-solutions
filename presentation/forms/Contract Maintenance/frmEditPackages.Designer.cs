namespace Presentation.Forms.ContractMaintenance
{
    partial class frmEditPackages
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
            this.txtPDiscript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPSLA = new System.Windows.Forms.ComboBox();
            this.cmbPService = new System.Windows.Forms.ComboBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPDiscript
            // 
            this.txtPDiscript.Location = new System.Drawing.Point(328, 173);
            this.txtPDiscript.Name = "txtPDiscript";
            this.txtPDiscript.Size = new System.Drawing.Size(427, 31);
            this.txtPDiscript.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Service Level Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Service";
            // 
            // cmbPSLA
            // 
            this.cmbPSLA.FormattingEnabled = true;
            this.cmbPSLA.Location = new System.Drawing.Point(328, 322);
            this.cmbPSLA.Name = "cmbPSLA";
            this.cmbPSLA.Size = new System.Drawing.Size(427, 33);
            this.cmbPSLA.TabIndex = 17;
            // 
            // cmbPService
            // 
            this.cmbPService.FormattingEnabled = true;
            this.cmbPService.Location = new System.Drawing.Point(328, 252);
            this.cmbPService.Name = "cmbPService";
            this.cmbPService.Size = new System.Drawing.Size(427, 33);
            this.cmbPService.TabIndex = 16;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(328, 95);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(427, 31);
            this.txtPName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(629, 380);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(126, 47);
            this.btnEditPackage.TabIndex = 22;
            this.btnEditPackage.Text = "Edit";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // frmEditPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.txtPDiscript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPSLA);
            this.Controls.Add(this.cmbPService);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label1);
            this.Name = "frmEditPackages";
            this.Text = "frmEditPackages";
            this.Load += new System.EventHandler(this.frmEditPackages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPDiscript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPSLA;
        private System.Windows.Forms.ComboBox cmbPService;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditPackage;
    }
}