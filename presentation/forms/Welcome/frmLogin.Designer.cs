namespace Presentation.Forms.Welcome
{
    partial class frmLogin
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
            this.btnServiceDep = new System.Windows.Forms.Button();
            this.btnContractMain = new System.Windows.Forms.Button();
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnClientSatis = new System.Windows.Forms.Button();
            this.btnClientMain = new System.Windows.Forms.Button();
            this.btnTechnician = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServiceDep
            // 
            this.btnServiceDep.Location = new System.Drawing.Point(584, 23);
            this.btnServiceDep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnServiceDep.Name = "btnServiceDep";
            this.btnServiceDep.Size = new System.Drawing.Size(388, 127);
            this.btnServiceDep.TabIndex = 0;
            this.btnServiceDep.Text = "Service Department";
            this.btnServiceDep.UseVisualStyleBackColor = true;
            this.btnServiceDep.Click += new System.EventHandler(this.btnServiceDep_Click);
            // 
            // btnContractMain
            // 
            this.btnContractMain.Location = new System.Drawing.Point(584, 162);
            this.btnContractMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnContractMain.Name = "btnContractMain";
            this.btnContractMain.Size = new System.Drawing.Size(388, 127);
            this.btnContractMain.TabIndex = 1;
            this.btnContractMain.Text = "Contract Maintenance";
            this.btnContractMain.UseVisualStyleBackColor = true;
            this.btnContractMain.Click += new System.EventHandler(this.btnContractMain_Click);
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(584, 300);
            this.btnCallCentre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(388, 127);
            this.btnCallCentre.TabIndex = 2;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // btnClientSatis
            // 
            this.btnClientSatis.Location = new System.Drawing.Point(584, 438);
            this.btnClientSatis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClientSatis.Name = "btnClientSatis";
            this.btnClientSatis.Size = new System.Drawing.Size(388, 127);
            this.btnClientSatis.TabIndex = 3;
            this.btnClientSatis.Text = "Client Satisfaction";
            this.btnClientSatis.UseVisualStyleBackColor = true;
            // 
            // btnClientMain
            // 
            this.btnClientMain.Location = new System.Drawing.Point(584, 577);
            this.btnClientMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClientMain.Name = "btnClientMain";
            this.btnClientMain.Size = new System.Drawing.Size(388, 127);
            this.btnClientMain.TabIndex = 4;
            this.btnClientMain.Text = "Client Maintenance";
            this.btnClientMain.UseVisualStyleBackColor = true;
            this.btnClientMain.Click += new System.EventHandler(this.btnClientMain_Click);
            // 
            // btnTechnician
            // 
            this.btnTechnician.Location = new System.Drawing.Point(584, 715);
            this.btnTechnician.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTechnician.Name = "btnTechnician";
            this.btnTechnician.Size = new System.Drawing.Size(388, 127);
            this.btnTechnician.TabIndex = 5;
            this.btnTechnician.Text = "Technician";
            this.btnTechnician.UseVisualStyleBackColor = true;
            this.btnTechnician.Click += new System.EventHandler(this.btnTechnician_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnTechnician);
            this.Controls.Add(this.btnClientMain);
            this.Controls.Add(this.btnClientSatis);
            this.Controls.Add(this.btnCallCentre);
            this.Controls.Add(this.btnContractMain);
            this.Controls.Add(this.btnServiceDep);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServiceDep;
        private System.Windows.Forms.Button btnContractMain;
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btnClientSatis;
        private System.Windows.Forms.Button btnClientMain;
        private System.Windows.Forms.Button btnTechnician;
    }
}

