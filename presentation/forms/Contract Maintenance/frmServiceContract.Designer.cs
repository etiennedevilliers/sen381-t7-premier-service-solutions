namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmServiceContract
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
            this.tabPackage = new System.Windows.Forms.TabPage();
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.listPackage = new System.Windows.Forms.ListView();
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSLA = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstSLA = new System.Windows.Forms.ListView();
            this.chSLAID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSLAdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabService = new System.Windows.Forms.TabPage();
            this.btnServiceRemove = new System.Windows.Forms.Button();
            this.btnServiceEdit = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.lstServiceView = new System.Windows.Forms.ListView();
            this.chServiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpectedDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2037, 872);
            this.tabControl1.TabIndex = 0;
            // 
            // tabServiceContract
            // 
            this.tabServiceContract.Location = new System.Drawing.Point(8, 39);
            this.tabServiceContract.Name = "tabServiceContract";
            this.tabServiceContract.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceContract.Size = new System.Drawing.Size(2021, 825);
            this.tabServiceContract.TabIndex = 0;
            this.tabServiceContract.Text = "Service Contract";
            this.tabServiceContract.UseVisualStyleBackColor = true;
            // 
            // tabPackage
            // 
            this.tabPackage.Controls.Add(this.btnRemovePackage);
            this.tabPackage.Controls.Add(this.btnEditPackage);
            this.tabPackage.Controls.Add(this.btnAddPackage);
            this.tabPackage.Controls.Add(this.listPackage);
            this.tabPackage.Location = new System.Drawing.Point(8, 39);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackage.Size = new System.Drawing.Size(2021, 825);
            this.tabPackage.TabIndex = 1;
            this.tabPackage.Text = "Package";
            this.tabPackage.UseVisualStyleBackColor = true;
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(1795, 279);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(208, 57);
            this.btnRemovePackage.TabIndex = 6;
            this.btnRemovePackage.Text = "Remove";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(1795, 180);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(208, 57);
            this.btnEditPackage.TabIndex = 5;
            this.btnEditPackage.Text = "Edit";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(1795, 93);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(208, 57);
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
            this.chPDis});
            this.listPackage.HideSelection = false;
            this.listPackage.Location = new System.Drawing.Point(6, 93);
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(1762, 726);
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
            // tabSLA
            // 
            this.tabSLA.Controls.Add(this.btnRemove);
            this.tabSLA.Controls.Add(this.btnEdit);
            this.tabSLA.Controls.Add(this.btnAdd);
            this.tabSLA.Controls.Add(this.lstSLA);
            this.tabSLA.Location = new System.Drawing.Point(8, 39);
            this.tabSLA.Name = "tabSLA";
            this.tabSLA.Size = new System.Drawing.Size(2021, 825);
            this.tabSLA.TabIndex = 2;
            this.tabSLA.Text = "Service Level Agreement";
            this.tabSLA.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1009, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 54);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1009, 174);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 54);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1009, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 54);
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
            this.lstSLA.HideSelection = false;
            this.lstSLA.Location = new System.Drawing.Point(14, 86);
            this.lstSLA.Name = "lstSLA";
            this.lstSLA.Size = new System.Drawing.Size(969, 726);
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
            this.tabService.Controls.Add(this.btnServiceRemove);
            this.tabService.Controls.Add(this.btnServiceEdit);
            this.tabService.Controls.Add(this.btnServiceAdd);
            this.tabService.Controls.Add(this.lstServiceView);
            this.tabService.Location = new System.Drawing.Point(8, 39);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(2021, 825);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // btnServiceRemove
            // 
            this.btnServiceRemove.Location = new System.Drawing.Point(1101, 283);
            this.btnServiceRemove.Name = "btnServiceRemove";
            this.btnServiceRemove.Size = new System.Drawing.Size(208, 57);
            this.btnServiceRemove.TabIndex = 3;
            this.btnServiceRemove.Text = "Remove";
            this.btnServiceRemove.UseVisualStyleBackColor = true;
            this.btnServiceRemove.Click += new System.EventHandler(this.btnServiceRemove_Click);
            // 
            // btnServiceEdit
            // 
            this.btnServiceEdit.Location = new System.Drawing.Point(1101, 193);
            this.btnServiceEdit.Name = "btnServiceEdit";
            this.btnServiceEdit.Size = new System.Drawing.Size(208, 57);
            this.btnServiceEdit.TabIndex = 2;
            this.btnServiceEdit.Text = "Edit";
            this.btnServiceEdit.UseVisualStyleBackColor = true;
            this.btnServiceEdit.Click += new System.EventHandler(this.btnServiceEdit_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(1101, 98);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(208, 57);
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
            this.lstServiceView.HideSelection = false;
            this.lstServiceView.Location = new System.Drawing.Point(23, 98);
            this.lstServiceView.Name = "lstServiceView";
            this.lstServiceView.Size = new System.Drawing.Size(1047, 726);
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
            // frmServiceContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 1049);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmServiceContract";
            this.Text = "frmServiceContract";
            this.Load += new System.EventHandler(this.frmServiceContract_Load);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnServiceRemove;
        private System.Windows.Forms.Button btnServiceEdit;
        private System.Windows.Forms.ColumnHeader chServiceID;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chExpectedDuration;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstSLA;
        private System.Windows.Forms.ColumnHeader chSLAID;
        private System.Windows.Forms.ColumnHeader chSLAdescription;
        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chSID;
        private System.Windows.Forms.ColumnHeader slaId;
        private System.Windows.Forms.ColumnHeader chPName;
        private System.Windows.Forms.ColumnHeader chPDis;
    }
}