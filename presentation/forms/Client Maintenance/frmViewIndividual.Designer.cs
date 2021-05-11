
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmViewIndividual
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
            this.lstViewIndiv = new System.Windows.Forms.ListView();
            this.colDescript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbIndivName = new System.Windows.Forms.TextBox();
            this.tbIndivContact = new System.Windows.Forms.TextBox();
            this.tbIndivSurname = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstAddressI = new System.Windows.Forms.ListView();
            this.colCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStreetAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPremise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstViewIndiv
            // 
            this.lstViewIndiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescript,
            this.colStartDate,
            this.colEndDate});
            this.lstViewIndiv.HideSelection = false;
            this.lstViewIndiv.Location = new System.Drawing.Point(59, 150);
            this.lstViewIndiv.Name = "lstViewIndiv";
            this.lstViewIndiv.Size = new System.Drawing.Size(648, 156);
            this.lstViewIndiv.TabIndex = 0;
            this.lstViewIndiv.UseCompatibleStateImageBehavior = false;
            this.lstViewIndiv.View = System.Windows.Forms.View.Details;
            // 
            // colDescript
            // 
            this.colDescript.Text = "Service Description";
            this.colDescript.Width = 140;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 112;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 197;
            // 
            // tbIndivName
            // 
            this.tbIndivName.Location = new System.Drawing.Point(160, 12);
            this.tbIndivName.Name = "tbIndivName";
            this.tbIndivName.Size = new System.Drawing.Size(176, 22);
            this.tbIndivName.TabIndex = 1;
            // 
            // tbIndivContact
            // 
            this.tbIndivContact.Location = new System.Drawing.Point(160, 72);
            this.tbIndivContact.Name = "tbIndivContact";
            this.tbIndivContact.Size = new System.Drawing.Size(176, 22);
            this.tbIndivContact.TabIndex = 2;
            // 
            // tbIndivSurname
            // 
            this.tbIndivSurname.Location = new System.Drawing.Point(160, 40);
            this.tbIndivSurname.Name = "tbIndivSurname";
            this.tbIndivSurname.Size = new System.Drawing.Size(176, 22);
            this.tbIndivSurname.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(597, 59);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 48);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(632, 501);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstAddressI
            // 
            this.lstAddressI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCountry,
            this.colProvince,
            this.colDistrict,
            this.colPostalCode,
            this.colStreetAddress,
            this.colPremise});
            this.lstAddressI.HideSelection = false;
            this.lstAddressI.Location = new System.Drawing.Point(59, 320);
            this.lstAddressI.Name = "lstAddressI";
            this.lstAddressI.Size = new System.Drawing.Size(648, 156);
            this.lstAddressI.TabIndex = 8;
            this.lstAddressI.UseCompatibleStateImageBehavior = false;
            this.lstAddressI.View = System.Windows.Forms.View.Details;
            // 
            // colCountry
            // 
            this.colCountry.Text = "country";
            this.colCountry.Width = 89;
            // 
            // colProvince
            // 
            this.colProvince.Text = "province";
            this.colProvince.Width = 111;
            // 
            // colDistrict
            // 
            this.colDistrict.Text = "district";
            this.colDistrict.Width = 117;
            // 
            // colPostalCode
            // 
            this.colPostalCode.Text = "postalCode";
            this.colPostalCode.Width = 88;
            // 
            // colStreetAddress
            // 
            this.colStreetAddress.Text = "streetAddress";
            this.colStreetAddress.Width = 113;
            // 
            // colPremise
            // 
            this.colPremise.Text = "premise";
            this.colPremise.Width = 78;
            // 
            // frmViewIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 594);
            this.Controls.Add(this.lstAddressI);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbIndivSurname);
            this.Controls.Add(this.tbIndivContact);
            this.Controls.Add(this.tbIndivName);
            this.Controls.Add(this.lstViewIndiv);
            this.Name = "frmViewIndividual";
            this.Text = "ViewContract";
            this.Load += new System.EventHandler(this.frmViewContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewIndiv;
        private System.Windows.Forms.TextBox tbIndivName;
        private System.Windows.Forms.TextBox tbIndivContact;
        private System.Windows.Forms.TextBox tbIndivSurname;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ColumnHeader colDescript;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lstAddressI;
        private System.Windows.Forms.ColumnHeader colCountry;
        private System.Windows.Forms.ColumnHeader colProvince;
        private System.Windows.Forms.ColumnHeader colDistrict;
        private System.Windows.Forms.ColumnHeader colPostalCode;
        private System.Windows.Forms.ColumnHeader colStreetAddress;
        private System.Windows.Forms.ColumnHeader colPremise;
    }
}