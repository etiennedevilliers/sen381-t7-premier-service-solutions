namespace Presentation.Forms.ContractMaintenance
{
    partial class frmEditServiceCon
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
            this.dtDateTer = new System.Windows.Forms.DateTimePicker();
            this.dtDateFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSCDateTer = new System.Windows.Forms.Label();
            this.lblDateFinalized = new System.Windows.Forms.Label();
            this.lblSCDescript = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.listPackage = new System.Windows.Forms.ListView();
            this.chPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPDis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnSCOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtDateTer
            // 
            this.dtDateTer.Location = new System.Drawing.Point(128, 80);
            this.dtDateTer.Margin = new System.Windows.Forms.Padding(2);
            this.dtDateTer.Name = "dtDateTer";
            this.dtDateTer.Size = new System.Drawing.Size(200, 20);
            this.dtDateTer.TabIndex = 18;
            // 
            // dtDateFinal
            // 
            this.dtDateFinal.Location = new System.Drawing.Point(128, 48);
            this.dtDateFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtDateFinal.Name = "dtDateFinal";
            this.dtDateFinal.Size = new System.Drawing.Size(200, 20);
            this.dtDateFinal.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 18);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 16;
            // 
            // lblSCDateTer
            // 
            this.lblSCDateTer.AutoSize = true;
            this.lblSCDateTer.Location = new System.Drawing.Point(17, 83);
            this.lblSCDateTer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSCDateTer.Name = "lblSCDateTer";
            this.lblSCDateTer.Size = new System.Drawing.Size(86, 13);
            this.lblSCDateTer.TabIndex = 15;
            this.lblSCDateTer.Text = "Date Terminated";
            // 
            // lblDateFinalized
            // 
            this.lblDateFinalized.AutoSize = true;
            this.lblDateFinalized.Location = new System.Drawing.Point(17, 51);
            this.lblDateFinalized.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFinalized.Name = "lblDateFinalized";
            this.lblDateFinalized.Size = new System.Drawing.Size(74, 13);
            this.lblDateFinalized.TabIndex = 14;
            this.lblDateFinalized.Text = "Date Finalized";
            // 
            // lblSCDescript
            // 
            this.lblSCDescript.AutoSize = true;
            this.lblSCDescript.Location = new System.Drawing.Point(17, 21);
            this.lblSCDescript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSCDescript.Name = "lblSCDescript";
            this.lblSCDescript.Size = new System.Drawing.Size(60, 13);
            this.lblSCDescript.TabIndex = 13;
            this.lblSCDescript.Text = "Description";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(128, 122);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 21;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(17, 125);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Cost";
            // 
            // listPackage
            // 
            this.listPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPID,
            this.chSID,
            this.slaId,
            this.chPName,
            this.chPDis});
            this.listPackage.FullRowSelect = true;
            this.listPackage.HideSelection = false;
            this.listPackage.Location = new System.Drawing.Point(128, 184);
            this.listPackage.Margin = new System.Windows.Forms.Padding(2);
            this.listPackage.MultiSelect = false;
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(608, 379);
            this.listPackage.TabIndex = 28;
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
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(128, 157);
            this.cmbPackage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(608, 21);
            this.cmbPackage.TabIndex = 27;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(17, 159);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(50, 13);
            this.lblPackage.TabIndex = 26;
            this.lblPackage.Text = "Package";
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(738, 213);
            this.btnRemovePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(94, 28);
            this.btnRemovePackage.TabIndex = 25;
            this.btnRemovePackage.Text = "Remove package";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(738, 182);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(94, 28);
            this.btnAddPackage.TabIndex = 24;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnSCOk
            // 
            this.btnSCOk.Location = new System.Drawing.Point(648, 570);
            this.btnSCOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnSCOk.Name = "btnSCOk";
            this.btnSCOk.Size = new System.Drawing.Size(86, 28);
            this.btnSCOk.TabIndex = 23;
            this.btnSCOk.Text = "OK";
            this.btnSCOk.UseVisualStyleBackColor = true;
            this.btnSCOk.Click += new System.EventHandler(this.btnSCOk_Click);
            // 
            // frmEditServiceCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 655);
            this.Controls.Add(this.listPackage);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.btnRemovePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnSCOk);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.dtDateTer);
            this.Controls.Add(this.dtDateFinal);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblSCDateTer);
            this.Controls.Add(this.lblDateFinalized);
            this.Controls.Add(this.lblSCDescript);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditServiceCon";
            this.Text = "frmEditServiceCon";
            this.Load += new System.EventHandler(this.frmEditServiceCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDateTer;
        private System.Windows.Forms.DateTimePicker dtDateFinal;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSCDateTer;
        private System.Windows.Forms.Label lblDateFinalized;
        private System.Windows.Forms.Label lblSCDescript;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader chPID;
        private System.Windows.Forms.ColumnHeader chSID;
        private System.Windows.Forms.ColumnHeader slaId;
        private System.Windows.Forms.ColumnHeader chPName;
        private System.Windows.Forms.ColumnHeader chPDis;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnSCOk;
    }
}