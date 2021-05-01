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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.SuspendLayout();
            // 
            // btnSCOk
            // 
            this.btnSCOk.Location = new System.Drawing.Point(1296, 1031);
            this.btnSCOk.Name = "btnSCOk";
            this.btnSCOk.Size = new System.Drawing.Size(172, 53);
            this.btnSCOk.TabIndex = 0;
            this.btnSCOk.Text = "OK";
            this.btnSCOk.UseVisualStyleBackColor = true;
            // 
            // lblSCDescript
            // 
            this.lblSCDescript.AutoSize = true;
            this.lblSCDescript.Location = new System.Drawing.Point(127, 36);
            this.lblSCDescript.Name = "lblSCDescript";
            this.lblSCDescript.Size = new System.Drawing.Size(120, 25);
            this.lblSCDescript.TabIndex = 1;
            this.lblSCDescript.Text = "Description";
            // 
            // lblDateFinalized
            // 
            this.lblDateFinalized.AutoSize = true;
            this.lblDateFinalized.Location = new System.Drawing.Point(127, 95);
            this.lblDateFinalized.Name = "lblDateFinalized";
            this.lblDateFinalized.Size = new System.Drawing.Size(150, 25);
            this.lblDateFinalized.TabIndex = 2;
            this.lblDateFinalized.Text = "Date Finalized";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(945, 36);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(56, 25);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // lblSCDateTer
            // 
            this.lblSCDateTer.AutoSize = true;
            this.lblSCDateTer.Location = new System.Drawing.Point(127, 155);
            this.lblSCDateTer.Name = "lblSCDateTer";
            this.lblSCDateTer.Size = new System.Drawing.Size(171, 25);
            this.lblSCDateTer.TabIndex = 3;
            this.lblSCDateTer.Text = "Date Terminated";
            // 
            // lblIDent
            // 
            this.lblIDent.AutoSize = true;
            this.lblIDent.Location = new System.Drawing.Point(945, 161);
            this.lblIDent.Name = "lblIDent";
            this.lblIDent.Size = new System.Drawing.Size(94, 25);
            this.lblIDent.TabIndex = 6;
            this.lblIDent.Text = "Identifier";
            // 
            // lblscStatus
            // 
            this.lblscStatus.AutoSize = true;
            this.lblscStatus.Location = new System.Drawing.Point(942, 89);
            this.lblscStatus.Name = "lblscStatus";
            this.lblscStatus.Size = new System.Drawing.Size(73, 25);
            this.lblscStatus.TabIndex = 5;
            this.lblscStatus.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 31);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1071, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1071, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(397, 31);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1071, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(397, 31);
            this.textBox4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(397, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(349, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(397, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(132, 304);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(187, 53);
            this.btnAddPackage.TabIndex = 13;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(132, 396);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(187, 63);
            this.btnRemovePackage.TabIndex = 14;
            this.btnRemovePackage.Text = "Remove package";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(127, 231);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(96, 25);
            this.lblPackage.TabIndex = 16;
            this.lblPackage.Text = "Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(349, 223);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(1119, 33);
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
            this.listPackage.Location = new System.Drawing.Point(349, 279);
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(1119, 726);
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
            // frmAddServiceContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 1178);
            this.Controls.Add(this.listPackage);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.btnRemovePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
    }
}