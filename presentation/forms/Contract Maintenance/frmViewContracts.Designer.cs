
namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmViewContracts
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Contract ID");
            this.gbView = new System.Windows.Forms.GroupBox();
            this.btnViewSLA = new System.Windows.Forms.Button();
            this.btnViewPacages = new System.Windows.Forms.Button();
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstViewItems = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPackageBySC = new System.Windows.Forms.Button();
            this.gbxSelectServiceContract = new System.Windows.Forms.GroupBox();
            this.cmbxNewpackage = new System.Windows.Forms.ComboBox();
            this.btnViewPackagesBySC = new System.Windows.Forms.Button();
            this.gbView.SuspendLayout();
            this.gbxSelectServiceContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbView
            // 
            this.gbView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbView.Controls.Add(this.btnPackageBySC);
            this.gbView.Controls.Add(this.btnViewSLA);
            this.gbView.Controls.Add(this.btnViewPacages);
            this.gbView.Controls.Add(this.btnViewContracts);
            this.gbView.Controls.Add(this.btnViewServices);
            this.gbView.Location = new System.Drawing.Point(12, 12);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(640, 526);
            this.gbView.TabIndex = 0;
            this.gbView.TabStop = false;
            this.gbView.Text = "View List";
            // 
            // btnViewSLA
            // 
            this.btnViewSLA.Location = new System.Drawing.Point(106, 352);
            this.btnViewSLA.Name = "btnViewSLA";
            this.btnViewSLA.Size = new System.Drawing.Size(418, 47);
            this.btnViewSLA.TabIndex = 4;
            this.btnViewSLA.Text = "View All Service Level Agreements";
            this.btnViewSLA.UseVisualStyleBackColor = true;
            this.btnViewSLA.Click += new System.EventHandler(this.btnViewSLA_Click_1);
            // 
            // btnViewPacages
            // 
            this.btnViewPacages.Location = new System.Drawing.Point(106, 270);
            this.btnViewPacages.Name = "btnViewPacages";
            this.btnViewPacages.Size = new System.Drawing.Size(418, 47);
            this.btnViewPacages.TabIndex = 3;
            this.btnViewPacages.Text = "View All Packages";
            this.btnViewPacages.UseVisualStyleBackColor = true;
            this.btnViewPacages.Click += new System.EventHandler(this.btnViewPacages_Click);
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.Location = new System.Drawing.Point(106, 183);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(418, 47);
            this.btnViewContracts.TabIndex = 2;
            this.btnViewContracts.Text = "View All Contracts";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.btnViewContracts_Click);
            // 
            // btnViewServices
            // 
            this.btnViewServices.Location = new System.Drawing.Point(106, 87);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(418, 47);
            this.btnViewServices.TabIndex = 1;
            this.btnViewServices.Text = "View All Services";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 544);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstViewItems
            // 
            this.lstViewItems.BackColor = System.Drawing.SystemColors.MenuText;
            this.lstViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chDis,
            this.chDateFinal,
            this.chCost,
            this.chStatus});
            this.lstViewItems.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstViewItems.HideSelection = false;
            this.lstViewItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstViewItems.Location = new System.Drawing.Point(658, 12);
            this.lstViewItems.Name = "lstViewItems";
            this.lstViewItems.Size = new System.Drawing.Size(1384, 454);
            this.lstViewItems.TabIndex = 3;
            this.lstViewItems.UseCompatibleStateImageBehavior = false;
            this.lstViewItems.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "Description";
            this.chID.Width = 127;
            // 
            // chDis
            // 
            this.chDis.Text = "Description";
            this.chDis.Width = 176;
            // 
            // chDateFinal
            // 
            this.chDateFinal.Text = "Date Finalized";
            this.chDateFinal.Width = 190;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.Width = 90;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 111;
            // 
            // btnPackageBySC
            // 
            this.btnPackageBySC.Location = new System.Drawing.Point(106, 435);
            this.btnPackageBySC.Name = "btnPackageBySC";
            this.btnPackageBySC.Size = new System.Drawing.Size(418, 47);
            this.btnPackageBySC.TabIndex = 5;
            this.btnPackageBySC.Text = "View Packages by Service Contract";
            this.btnPackageBySC.UseVisualStyleBackColor = true;
            this.btnPackageBySC.Click += new System.EventHandler(this.btnPackageBySC_Click);
            // 
            // gbxSelectServiceContract
            // 
            this.gbxSelectServiceContract.Controls.Add(this.btnViewPackagesBySC);
            this.gbxSelectServiceContract.Controls.Add(this.cmbxNewpackage);
            this.gbxSelectServiceContract.Location = new System.Drawing.Point(658, 472);
            this.gbxSelectServiceContract.Name = "gbxSelectServiceContract";
            this.gbxSelectServiceContract.Size = new System.Drawing.Size(570, 190);
            this.gbxSelectServiceContract.TabIndex = 4;
            this.gbxSelectServiceContract.TabStop = false;
            this.gbxSelectServiceContract.Text = "Select Service Contrct";
            // 
            // cmbxNewpackage
            // 
            this.cmbxNewpackage.FormattingEnabled = true;
            this.cmbxNewpackage.Location = new System.Drawing.Point(32, 57);
            this.cmbxNewpackage.Name = "cmbxNewpackage";
            this.cmbxNewpackage.Size = new System.Drawing.Size(532, 33);
            this.cmbxNewpackage.TabIndex = 0;
            // 
            // btnViewPackagesBySC
            // 
            this.btnViewPackagesBySC.Location = new System.Drawing.Point(32, 120);
            this.btnViewPackagesBySC.Name = "btnViewPackagesBySC";
            this.btnViewPackagesBySC.Size = new System.Drawing.Size(280, 45);
            this.btnViewPackagesBySC.TabIndex = 5;
            this.btnViewPackagesBySC.Text = "View";
            this.btnViewPackagesBySC.UseVisualStyleBackColor = true;
            this.btnViewPackagesBySC.Click += new System.EventHandler(this.btnViewPackagesBySC_Click);
            // 
            // frmViewContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2054, 920);
            this.Controls.Add(this.gbxSelectServiceContract);
            this.Controls.Add(this.lstViewItems);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewContracts";
            this.Text = "ViewContracts";
            this.Load += new System.EventHandler(this.frmViewContracts_Load);
            this.gbView.ResumeLayout(false);
            this.gbxSelectServiceContract.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Button btnViewContracts;
        private System.Windows.Forms.Button btnViewSLA;
        private System.Windows.Forms.Button btnViewPacages;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lstViewItems;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDis;
        private System.Windows.Forms.ColumnHeader chDateFinal;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Button btnPackageBySC;
        private System.Windows.Forms.GroupBox gbxSelectServiceContract;
        private System.Windows.Forms.Button btnViewPackagesBySC;
        private System.Windows.Forms.ComboBox cmbxNewpackage;
    }
}