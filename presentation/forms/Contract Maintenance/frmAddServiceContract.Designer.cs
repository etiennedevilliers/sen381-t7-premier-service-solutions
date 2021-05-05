namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmAddServiceContract
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
            this.btnSCOk = new System.Windows.Forms.Button();
            this.lblSCDescript = new System.Windows.Forms.Label();
            this.lblDateFinalized = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSCDateTer = new System.Windows.Forms.Label();
            this.lblIDent = new System.Windows.Forms.Label();
            this.lblscStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.dtDateFinal = new System.Windows.Forms.DateTimePicker();
            this.dtDateTer = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.listPackage = new System.Windows.Forms.ListView();
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.cmbImportance = new System.Windows.Forms.ComboBox();
            this.lblImportance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSCOk
            // 
            this.btnSCOk.Location = new System.Drawing.Point(1314, 1145);
            this.btnSCOk.Name = "btnSCOk";
            this.btnSCOk.Size = new System.Drawing.Size(172, 53);
            this.btnSCOk.TabIndex = 0;
            this.btnSCOk.Text = "OK";
            this.btnSCOk.UseVisualStyleBackColor = true;
            this.btnSCOk.Click += new System.EventHandler(this.btnSCOk_Click);
            // 
            // lblSCDescript
            // 
            this.lblSCDescript.AutoSize = true;
            this.lblSCDescript.Location = new System.Drawing.Point(51, 42);
            this.lblSCDescript.Name = "lblSCDescript";
            this.lblSCDescript.Size = new System.Drawing.Size(120, 25);
            this.lblSCDescript.TabIndex = 1;
            this.lblSCDescript.Text = "Description";
            // 
            // lblDateFinalized
            // 
            this.lblDateFinalized.AutoSize = true;
            this.lblDateFinalized.Location = new System.Drawing.Point(51, 101);
            this.lblDateFinalized.Name = "lblDateFinalized";
            this.lblDateFinalized.Size = new System.Drawing.Size(150, 25);
            this.lblDateFinalized.TabIndex = 2;
            this.lblDateFinalized.Text = "Date Finalized";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(875, 42);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(56, 25);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // lblSCDateTer
            // 
            this.lblSCDateTer.AutoSize = true;
            this.lblSCDateTer.Location = new System.Drawing.Point(51, 161);
            this.lblSCDateTer.Name = "lblSCDateTer";
            this.lblSCDateTer.Size = new System.Drawing.Size(171, 25);
            this.lblSCDateTer.TabIndex = 3;
            this.lblSCDateTer.Text = "Date Terminated";
            // 
            // lblIDent
            // 
            this.lblIDent.AutoSize = true;
            this.lblIDent.Location = new System.Drawing.Point(135, 277);
            this.lblIDent.Name = "lblIDent";
            this.lblIDent.Size = new System.Drawing.Size(94, 25);
            this.lblIDent.TabIndex = 6;
            this.lblIDent.Text = "Identifier";
            // 
            // lblscStatus
            // 
            this.lblscStatus.AutoSize = true;
            this.lblscStatus.Location = new System.Drawing.Point(875, 101);
            this.lblscStatus.Name = "lblscStatus";
            this.lblscStatus.Size = new System.Drawing.Size(73, 25);
            this.lblscStatus.TabIndex = 5;
            this.lblscStatus.Text = "Status";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(273, 36);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(397, 31);
            this.txtDescription.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(1089, 36);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(397, 31);
            this.txtCost.TabIndex = 8;
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(1089, 95);
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(397, 31);
            this.txtStat.TabIndex = 9;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(273, 271);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(397, 31);
            this.txtIdentifier.TabIndex = 10;
            // 
            // dtDateFinal
            // 
            this.dtDateFinal.Location = new System.Drawing.Point(273, 95);
            this.dtDateFinal.Name = "dtDateFinal";
            this.dtDateFinal.Size = new System.Drawing.Size(397, 31);
            this.dtDateFinal.TabIndex = 11;
            // 
            // dtDateTer
            // 
            this.dtDateTer.Location = new System.Drawing.Point(273, 155);
            this.dtDateTer.Name = "dtDateTer";
            this.dtDateTer.Size = new System.Drawing.Size(397, 31);
            this.dtDateTer.TabIndex = 12;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(1492, 400);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(187, 53);
            this.btnAddPackage.TabIndex = 13;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(1492, 459);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(187, 53);
            this.btnRemovePackage.TabIndex = 14;
            this.btnRemovePackage.Text = "Remove package";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(133, 354);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(96, 25);
            this.lblPackage.TabIndex = 16;
            this.lblPackage.Text = "Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(273, 351);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(1213, 33);
            this.cmbPackage.TabIndex = 17;
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
            this.listPackage.Location = new System.Drawing.Point(273, 402);
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(1213, 726);
            this.listPackage.TabIndex = 18;
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
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(732, 257);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(157, 45);
            this.btnGenerateID.TabIndex = 19;
            this.btnGenerateID.Text = "Generate ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // cmbImportance
            // 
            this.cmbImportance.FormattingEnabled = true;
            this.cmbImportance.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbImportance.Location = new System.Drawing.Point(1089, 165);
            this.cmbImportance.Name = "cmbImportance";
            this.cmbImportance.Size = new System.Drawing.Size(397, 33);
            this.cmbImportance.TabIndex = 20;
            // 
            // lblImportance
            // 
            this.lblImportance.AutoSize = true;
            this.lblImportance.Location = new System.Drawing.Point(872, 173);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(204, 25);
            this.lblImportance.TabIndex = 21;
            this.lblImportance.Text = "Level Of Importance";
            // 
            // frmAddServiceContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2469, 1616);
            this.Controls.Add(this.lblImportance);
            this.Controls.Add(this.cmbImportance);
            this.Controls.Add(this.btnGenerateID);
            this.Controls.Add(this.listPackage);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.btnRemovePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dtDateTer);
            this.Controls.Add(this.dtDateFinal);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.txtStat);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblIDent);
            this.Controls.Add(this.lblscStatus);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblSCDateTer);
            this.Controls.Add(this.lblDateFinalized);
            this.Controls.Add(this.lblSCDescript);
            this.Controls.Add(this.btnSCOk);
            this.Name = "frmAddServiceContract";
            this.Text = "frmAddServiceContract";
            this.Load += new System.EventHandler(this.frmAddServiceContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSCOk;
        private System.Windows.Forms.Label lblSCDescript;
        private System.Windows.Forms.Label lblDateFinalized;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSCDateTer;
        private System.Windows.Forms.Label lblIDent;
        private System.Windows.Forms.Label lblscStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.DateTimePicker dtDateFinal;
        private System.Windows.Forms.DateTimePicker dtDateTer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chSID;
        private System.Windows.Forms.ColumnHeader slaId;
        private System.Windows.Forms.ColumnHeader chPName;
        private System.Windows.Forms.ColumnHeader chPDis;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.ComboBox cmbImportance;
        private System.Windows.Forms.Label lblImportance;
    }
}