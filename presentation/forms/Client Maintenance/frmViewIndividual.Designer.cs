
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
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.lstvEquipment = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstViewIndiv
            // 
            this.lstViewIndiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescript,
            this.colStartDate,
            this.colEndDate});
            this.lstViewIndiv.HideSelection = false;
            this.lstViewIndiv.Location = new System.Drawing.Point(13, 108);
            this.lstViewIndiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewIndiv.Name = "lstViewIndiv";
            this.lstViewIndiv.Size = new System.Drawing.Size(1103, 396);
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
            this.tbIndivName.Location = new System.Drawing.Point(13, 39);
            this.tbIndivName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIndivName.Name = "tbIndivName";
            this.tbIndivName.Size = new System.Drawing.Size(218, 31);
            this.tbIndivName.TabIndex = 1;
            // 
            // tbIndivContact
            // 
            this.tbIndivContact.Location = new System.Drawing.Point(518, 39);
            this.tbIndivContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIndivContact.Name = "tbIndivContact";
            this.tbIndivContact.Size = new System.Drawing.Size(256, 31);
            this.tbIndivContact.TabIndex = 2;
            // 
            // tbIndivSurname
            // 
            this.tbIndivSurname.Location = new System.Drawing.Point(252, 39);
            this.tbIndivSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIndivSurname.Name = "tbIndivSurname";
            this.tbIndivSurname.Size = new System.Drawing.Size(250, 31);
            this.tbIndivSurname.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(987, 14);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(129, 75);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1004, 938);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(650, 512);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(230, 48);
            this.btnRemoveEquipment.TabIndex = 12;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(886, 512);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(230, 48);
            this.btnAddEquipment.TabIndex = 11;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // lstvEquipment
            // 
            this.lstvEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colManufact,
            this.colCat});
            this.lstvEquipment.HideSelection = false;
            this.lstvEquipment.Location = new System.Drawing.Point(10, 566);
            this.lstvEquipment.Name = "lstvEquipment";
            this.lstvEquipment.Size = new System.Drawing.Size(1106, 364);
            this.lstvEquipment.TabIndex = 10;
            this.lstvEquipment.UseCompatibleStateImageBehavior = false;
            this.lstvEquipment.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial Number";
            this.colSerial.Width = 208;
            // 
            // colManufact
            // 
            this.colManufact.Text = "Manufacturer";
            this.colManufact.Width = 246;
            // 
            // colCat
            // 
            this.colCat.Text = "Category";
            this.colCat.Width = 398;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 989);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.lstvEquipment);
            this.Controls.Add(this.lstAddressI);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbIndivSurname);
            this.Controls.Add(this.tbIndivContact);
            this.Controls.Add(this.tbIndivName);
            this.Controls.Add(this.lstViewIndiv);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.ListView lstvEquipment;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colManufact;
        private System.Windows.Forms.ColumnHeader colCat;
        private System.Windows.Forms.ListView lstAddressI;
        private System.Windows.Forms.ColumnHeader colCountry;
        private System.Windows.Forms.ColumnHeader colProvince;
        private System.Windows.Forms.ColumnHeader colDistrict;
        private System.Windows.Forms.ColumnHeader colPostalCode;
        private System.Windows.Forms.ColumnHeader colStreetAddress;
        private System.Windows.Forms.ColumnHeader colPremise;
    }
}