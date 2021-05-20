namespace Presentation.Forms.ContractMaintenance
{
    partial class frmContractMaintenance
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
            this.tabServiceContract = new System.Windows.Forms.TabPage();
            this.lstServiceContract = new System.Windows.Forms.ListView();
            this.SCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateFinilized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTerm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChIDent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditServiceContract = new System.Windows.Forms.Button();
            this.btnAddServiceContract = new System.Windows.Forms.Button();
            this.tabPackage = new System.Windows.Forms.TabPage();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.listPackage = new System.Windows.Forms.ListView();
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSLA = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstSLA = new System.Windows.Forms.ListView();
            this.chSLAID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSLAdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabService = new System.Windows.Forms.TabPage();
            this.btnServiceEdit = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.lstServiceView = new System.Windows.Forms.ListView();
            this.chServiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpectedDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabServiceContract.SuspendLayout();
            this.tabPackage.SuspendLayout();
            this.tabSLA.SuspendLayout();
            this.tabService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabServiceContract);
            this.tabControl1.Controls.Add(this.tabPackage);
            this.tabControl1.Controls.Add(this.tabSLA);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabServiceContract
            // 
            this.tabServiceContract.Controls.Add(this.lstServiceContract);
            this.tabServiceContract.Controls.Add(this.btnEditServiceContract);
            this.tabServiceContract.Controls.Add(this.btnAddServiceContract);
            this.tabServiceContract.Location = new System.Drawing.Point(4, 22);
            this.tabServiceContract.Margin = new System.Windows.Forms.Padding(2);
            this.tabServiceContract.Name = "tabServiceContract";
            this.tabServiceContract.Padding = new System.Windows.Forms.Padding(2);
            this.tabServiceContract.Size = new System.Drawing.Size(1076, 465);
            this.tabServiceContract.TabIndex = 0;
            this.tabServiceContract.Text = "Service Contract";
            this.tabServiceContract.UseVisualStyleBackColor = true;
            // 
            // lstServiceContract
            // 
            this.lstServiceContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SCID,
            this.chDescrip,
            this.chDateFinilized,
            this.chDateTerm,
            this.chCost,
            this.chStatus,
            this.ChIDent});
            this.lstServiceContract.FullRowSelect = true;
            this.lstServiceContract.HideSelection = false;
            this.lstServiceContract.Location = new System.Drawing.Point(7, 48);
            this.lstServiceContract.Margin = new System.Windows.Forms.Padding(2);
            this.lstServiceContract.MultiSelect = false;
            this.lstServiceContract.Name = "lstServiceContract";
            this.lstServiceContract.Size = new System.Drawing.Size(943, 407);
            this.lstServiceContract.TabIndex = 10;
            this.lstServiceContract.UseCompatibleStateImageBehavior = false;
            this.lstServiceContract.View = System.Windows.Forms.View.Details;
            // 
            // SCID
            // 
            this.SCID.Text = "Service Contract ID";
            this.SCID.Width = 121;
            // 
            // chDescrip
            // 
            this.chDescrip.Text = "Description";
            this.chDescrip.Width = 124;
            // 
            // chDateFinilized
            // 
            this.chDateFinilized.Text = "Date Finalised";
            this.chDateFinilized.Width = 144;
            // 
            // chDateTerm
            // 
            this.chDateTerm.Text = "Date Terminiated";
            this.chDateTerm.Width = 133;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.Width = 124;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 113;
            // 
            // ChIDent
            // 
            this.ChIDent.Text = "Identifier";
            this.ChIDent.Width = 275;
            // 
            // btnEditServiceContract
            // 
            this.btnEditServiceContract.Location = new System.Drawing.Point(951, 94);
            this.btnEditServiceContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditServiceContract.Name = "btnEditServiceContract";
            this.btnEditServiceContract.Size = new System.Drawing.Size(104, 30);
            this.btnEditServiceContract.TabIndex = 8;
            this.btnEditServiceContract.Text = "Edit";
            this.btnEditServiceContract.UseVisualStyleBackColor = true;
            this.btnEditServiceContract.Click += new System.EventHandler(this.btnEditServiceContract_Click);
            // 
            // btnAddServiceContract
            // 
            this.btnAddServiceContract.Location = new System.Drawing.Point(951, 48);
            this.btnAddServiceContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddServiceContract.Name = "btnAddServiceContract";
            this.btnAddServiceContract.Size = new System.Drawing.Size(104, 30);
            this.btnAddServiceContract.TabIndex = 7;
            this.btnAddServiceContract.Text = "Add";
            this.btnAddServiceContract.UseVisualStyleBackColor = true;
            this.btnAddServiceContract.Click += new System.EventHandler(this.btnAddServiceContract_Click);
            // 
            // tabPackage
            // 
            this.tabPackage.Controls.Add(this.btnEditPackage);
            this.tabPackage.Controls.Add(this.btnAddPackage);
            this.tabPackage.Controls.Add(this.listPackage);
            this.tabPackage.Location = new System.Drawing.Point(4, 22);
            this.tabPackage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Windows.Forms.Padding(2);
            this.tabPackage.Size = new System.Drawing.Size(1076, 465);
            this.tabPackage.TabIndex = 1;
            this.tabPackage.Text = "Package";
            this.tabPackage.UseVisualStyleBackColor = true;
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(898, 94);
            this.btnEditPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(104, 30);
            this.btnEditPackage.TabIndex = 5;
            this.btnEditPackage.Text = "Edit";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(898, 48);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(104, 30);
            this.btnAddPackage.TabIndex = 4;
            this.btnAddPackage.Text = "Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // listPackage
            // 
            this.listPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPID,
            this.chSID,
            this.slaId,
            this.chPName,
            this.chPDis,
            this.columnHeader1});
            this.listPackage.FullRowSelect = true;
            this.listPackage.HideSelection = false;
            this.listPackage.Location = new System.Drawing.Point(3, 48);
            this.listPackage.Margin = new System.Windows.Forms.Padding(2);
            this.listPackage.MultiSelect = false;
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(883, 402);
            this.listPackage.TabIndex = 2;
            this.listPackage.UseCompatibleStateImageBehavior = false;
            this.listPackage.View = System.Windows.Forms.View.Details;
            // 
            // chPID
            // 
            this.chPID.Text = "Package ID";
            this.chPID.Width = 163;
            // 
            // chSID
            // 
            this.chSID.Text = "ServiceID";
            this.chSID.Width = 140;
            // 
            // slaId
            // 
            this.slaId.Text = "SLA ID";
            this.slaId.Width = 95;
            // 
            // chPName
            // 
            this.chPName.Text = "Package Name";
            this.chPName.Width = 224;
            // 
            // chPDis
            // 
            this.chPDis.Text = "Package Description";
            this.chPDis.Width = 221;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Equiptment";
            this.columnHeader1.Width = 144;
            // 
            // tabSLA
            // 
            this.tabSLA.Controls.Add(this.btnEdit);
            this.tabSLA.Controls.Add(this.btnAdd);
            this.tabSLA.Controls.Add(this.lstSLA);
            this.tabSLA.Location = new System.Drawing.Point(4, 22);
            this.tabSLA.Margin = new System.Windows.Forms.Padding(2);
            this.tabSLA.Name = "tabSLA";
            this.tabSLA.Size = new System.Drawing.Size(1076, 465);
            this.tabSLA.TabIndex = 2;
            this.tabSLA.Text = "Service Level Agreement";
            this.tabSLA.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(981, 90);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(981, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstSLA
            // 
            this.lstSLA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSLAID,
            this.chSLAdescription});
            this.lstSLA.FullRowSelect = true;
            this.lstSLA.HideSelection = false;
            this.lstSLA.Location = new System.Drawing.Point(8, 45);
            this.lstSLA.Margin = new System.Windows.Forms.Padding(2);
            this.lstSLA.MultiSelect = false;
            this.lstSLA.Name = "lstSLA";
            this.lstSLA.Size = new System.Drawing.Size(969, 404);
            this.lstSLA.TabIndex = 1;
            this.lstSLA.UseCompatibleStateImageBehavior = false;
            this.lstSLA.View = System.Windows.Forms.View.Details;
            // 
            // chSLAID
            // 
            this.chSLAID.Text = "Service Level Agreement ID";
            this.chSLAID.Width = 302;
            // 
            // chSLAdescription
            // 
            this.chSLAdescription.Text = "SLADescription";
            this.chSLAdescription.Width = 237;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.btnServiceEdit);
            this.tabService.Controls.Add(this.btnServiceAdd);
            this.tabService.Controls.Add(this.lstServiceView);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Margin = new System.Windows.Forms.Padding(2);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(1076, 465);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // btnServiceEdit
            // 
            this.btnServiceEdit.Location = new System.Drawing.Point(550, 100);
            this.btnServiceEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceEdit.Name = "btnServiceEdit";
            this.btnServiceEdit.Size = new System.Drawing.Size(104, 30);
            this.btnServiceEdit.TabIndex = 2;
            this.btnServiceEdit.Text = "Edit";
            this.btnServiceEdit.UseVisualStyleBackColor = true;
            this.btnServiceEdit.Click += new System.EventHandler(this.btnServiceEdit_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(550, 51);
            this.btnServiceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(104, 30);
            this.btnServiceAdd.TabIndex = 1;
            this.btnServiceAdd.Text = "Add";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // lstServiceView
            // 
            this.lstServiceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chServiceID,
            this.chDescription,
            this.chExpectedDuration});
            this.lstServiceView.FullRowSelect = true;
            this.lstServiceView.HideSelection = false;
            this.lstServiceView.Location = new System.Drawing.Point(12, 51);
            this.lstServiceView.Margin = new System.Windows.Forms.Padding(2);
            this.lstServiceView.MultiSelect = false;
            this.lstServiceView.Name = "lstServiceView";
            this.lstServiceView.Size = new System.Drawing.Size(526, 379);
            this.lstServiceView.TabIndex = 0;
            this.lstServiceView.UseCompatibleStateImageBehavior = false;
            this.lstServiceView.View = System.Windows.Forms.View.Details;
            // 
            // chServiceID
            // 
            this.chServiceID.Text = "Service ID";
            this.chServiceID.Width = 123;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 145;
            // 
            // chExpectedDuration
            // 
            this.chExpectedDuration.Text = "ExpectedDuration";
            this.chExpectedDuration.Width = 199;
            // 
            // frmContractMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 503);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmContractMaintenance";
            this.Text = "frmServiceContract";
            this.Load += new System.EventHandler(this.frmServiceContract_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabServiceContract.ResumeLayout(false);
            this.tabPackage.ResumeLayout(false);
            this.tabSLA.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabServiceContract;
        private System.Windows.Forms.TabPage tabPackage;
        private System.Windows.Forms.TabPage tabSLA;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.ListView lstServiceView;
        private System.Windows.Forms.Button btnServiceEdit;
        private System.Windows.Forms.ColumnHeader chServiceID;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chExpectedDuration;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstSLA;
        private System.Windows.Forms.ColumnHeader chSLAID;
        private System.Windows.Forms.ColumnHeader chSLAdescription;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chSID;
        private System.Windows.Forms.ColumnHeader slaId;
        private System.Windows.Forms.ColumnHeader chPName;
        private System.Windows.Forms.ColumnHeader chPDis;
        private System.Windows.Forms.ListView lstServiceContract;
        private System.Windows.Forms.ColumnHeader SCID;
        private System.Windows.Forms.ColumnHeader chDescrip;
        private System.Windows.Forms.ColumnHeader chDateFinilized;
        private System.Windows.Forms.ColumnHeader chDateTerm;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.Button btnEditServiceContract;
        private System.Windows.Forms.Button btnAddServiceContract;
        private System.Windows.Forms.ColumnHeader ChIDent;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}