namespace sen381_t7_premier_service_solutions.presentation.forms.Contract_Maintenance
{
    partial class frmServiceContractMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SCTabPage = new System.Windows.Forms.TabPage();
            this.PackageTabPage = new System.Windows.Forms.TabPage();
            this.SLATabPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ServiceTabPage = new System.Windows.Forms.TabPage();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnCreateService = new System.Windows.Forms.Button();
            this.lstContractView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.SLATabPage.SuspendLayout();
            this.ServiceTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SCTabPage);
            this.tabControl1.Controls.Add(this.PackageTabPage);
            this.tabControl1.Controls.Add(this.SLATabPage);
            this.tabControl1.Controls.Add(this.ServiceTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2556, 1107);
            this.tabControl1.TabIndex = 0;
            // 
            // SCTabPage
            // 
            this.SCTabPage.Location = new System.Drawing.Point(8, 39);
            this.SCTabPage.Name = "SCTabPage";
            this.SCTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SCTabPage.Size = new System.Drawing.Size(2540, 1060);
            this.SCTabPage.TabIndex = 0;
            this.SCTabPage.Text = "Service Contract";
            this.SCTabPage.UseVisualStyleBackColor = true;
            // 
            // PackageTabPage
            // 
            this.PackageTabPage.Location = new System.Drawing.Point(8, 39);
            this.PackageTabPage.Name = "PackageTabPage";
            this.PackageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PackageTabPage.Size = new System.Drawing.Size(2540, 1060);
            this.PackageTabPage.TabIndex = 1;
            this.PackageTabPage.Text = "Package";
            this.PackageTabPage.UseVisualStyleBackColor = true;
            // 
            // SLATabPage
            // 
            this.SLATabPage.Controls.Add(this.button2);
            this.SLATabPage.Location = new System.Drawing.Point(8, 39);
            this.SLATabPage.Name = "SLATabPage";
            this.SLATabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SLATabPage.Size = new System.Drawing.Size(2540, 1060);
            this.SLATabPage.TabIndex = 2;
            this.SLATabPage.Text = "Service Level Agreement";
            this.SLATabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1855, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ServiceTabPage
            // 
            this.ServiceTabPage.Controls.Add(this.btnRemoveService);
            this.ServiceTabPage.Controls.Add(this.btnEditService);
            this.ServiceTabPage.Controls.Add(this.btnCreateService);
            this.ServiceTabPage.Controls.Add(this.lstContractView);
            this.ServiceTabPage.Location = new System.Drawing.Point(8, 39);
            this.ServiceTabPage.Name = "ServiceTabPage";
            this.ServiceTabPage.Size = new System.Drawing.Size(2540, 1060);
            this.ServiceTabPage.TabIndex = 3;
            this.ServiceTabPage.Text = "Service";
            this.ServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Location = new System.Drawing.Point(2327, 17);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(198, 45);
            this.btnRemoveService.TabIndex = 3;
            this.btnRemoveService.Text = "Remove";
            this.btnRemoveService.UseVisualStyleBackColor = true;
            // 
            // btnEditService
            // 
            this.btnEditService.Location = new System.Drawing.Point(2114, 17);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(198, 45);
            this.btnEditService.TabIndex = 2;
            this.btnEditService.Text = "Edit";
            this.btnEditService.UseVisualStyleBackColor = true;
            // 
            // btnCreateService
            // 
            this.btnCreateService.Location = new System.Drawing.Point(1899, 17);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(198, 45);
            this.btnCreateService.TabIndex = 1;
            this.btnCreateService.Text = "Create";
            this.btnCreateService.UseVisualStyleBackColor = true;
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // lstContractView
            // 
            this.lstContractView.HideSelection = false;
            this.lstContractView.Location = new System.Drawing.Point(0, 83);
            this.lstContractView.Name = "lstContractView";
            this.lstContractView.Size = new System.Drawing.Size(2534, 979);
            this.lstContractView.TabIndex = 0;
            this.lstContractView.UseCompatibleStateImageBehavior = false;
            // 
            // frmServiceContractMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2580, 1131);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmServiceContractMenu";
            this.Text = "frmServiceContractMenu";
            this.tabControl1.ResumeLayout(false);
            this.SLATabPage.ResumeLayout(false);
            this.ServiceTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SCTabPage;
        private System.Windows.Forms.TabPage PackageTabPage;
        private System.Windows.Forms.TabPage SLATabPage;
        private System.Windows.Forms.TabPage ServiceTabPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnCreateService;
        private System.Windows.Forms.ListView lstContractView;
    }
}