
namespace Presentation.Forms.ClientMaintenance
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
            this.colStreetAddressAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProvinceAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCountryAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistrictAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocalityAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPremiseAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostalCodeAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.lstvEquipment = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAddressAI = new System.Windows.Forms.Button();
            this.btnAddAddressAI = new System.Windows.Forms.Button();
            this.tbcBusiness = new System.Windows.Forms.TabControl();
            this.tpgAddress = new System.Windows.Forms.TabPage();
            this.tpgEquipment = new System.Windows.Forms.TabPage();
            this.tpgService = new System.Windows.Forms.TabPage();
            this.tbcBusiness.SuspendLayout();
            this.tpgAddress.SuspendLayout();
            this.tpgEquipment.SuspendLayout();
            this.tpgService.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewIndiv
            // 
            this.lstViewIndiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescript,
            this.colStartDate,
            this.colEndDate});
            this.lstViewIndiv.FullRowSelect = true;
            this.lstViewIndiv.HideSelection = false;
            this.lstViewIndiv.Location = new System.Drawing.Point(3, 35);
            this.lstViewIndiv.Name = "lstViewIndiv";
            this.lstViewIndiv.Size = new System.Drawing.Size(992, 269);
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
            this.tbIndivName.Location = new System.Drawing.Point(9, 25);
            this.tbIndivName.Name = "tbIndivName";
            this.tbIndivName.Size = new System.Drawing.Size(147, 22);
            this.tbIndivName.TabIndex = 1;
            // 
            // tbIndivContact
            // 
            this.tbIndivContact.Location = new System.Drawing.Point(345, 25);
            this.tbIndivContact.Name = "tbIndivContact";
            this.tbIndivContact.Size = new System.Drawing.Size(172, 22);
            this.tbIndivContact.TabIndex = 2;
            // 
            // tbIndivSurname
            // 
            this.tbIndivSurname.Location = new System.Drawing.Point(168, 25);
            this.tbIndivSurname.Name = "tbIndivSurname";
            this.tbIndivSurname.Size = new System.Drawing.Size(168, 22);
            this.tbIndivSurname.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(537, 12);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 48);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(982, 452);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 47);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstAddressI
            // 
            this.lstAddressI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStreetAddressAI,
            this.colProvinceAI,
            this.colCountryAI,
            this.colDistrictAI,
            this.colLocalityAI,
            this.colPremiseAI,
            this.colPostalCodeAI});
            this.lstAddressI.FullRowSelect = true;
            this.lstAddressI.HideSelection = false;
            this.lstAddressI.Location = new System.Drawing.Point(18, 49);
            this.lstAddressI.Margin = new System.Windows.Forms.Padding(2);
            this.lstAddressI.Name = "lstAddressI";
            this.lstAddressI.Size = new System.Drawing.Size(995, 232);
            this.lstAddressI.TabIndex = 8;
            this.lstAddressI.UseCompatibleStateImageBehavior = false;
            this.lstAddressI.View = System.Windows.Forms.View.Details;
            // 
            // colStreetAddressAI
            // 
            this.colStreetAddressAI.Text = "Street Address";
            this.colStreetAddressAI.Width = 130;
            // 
            // colProvinceAI
            // 
            this.colProvinceAI.Text = "Province";
            this.colProvinceAI.Width = 98;
            // 
            // colCountryAI
            // 
            this.colCountryAI.Text = "Country";
            this.colCountryAI.Width = 103;
            // 
            // colDistrictAI
            // 
            this.colDistrictAI.Text = "District";
            this.colDistrictAI.Width = 99;
            // 
            // colLocalityAI
            // 
            this.colLocalityAI.Text = "Locality";
            this.colLocalityAI.Width = 101;
            // 
            // colPremiseAI
            // 
            this.colPremiseAI.Text = "Premise";
            this.colPremiseAI.Width = 101;
            // 
            // colPostalCodeAI
            // 
            this.colPostalCodeAI.Text = "Postal Code";
            this.colPostalCodeAI.Width = 88;
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(659, 15);
            this.btnRemoveEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(166, 30);
            this.btnRemoveEquipment.TabIndex = 12;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(834, 15);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(166, 30);
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
            this.lstvEquipment.Location = new System.Drawing.Point(19, 49);
            this.lstvEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.lstvEquipment.Name = "lstvEquipment";
            this.lstvEquipment.Size = new System.Drawing.Size(981, 244);
            this.lstvEquipment.TabIndex = 10;
            this.lstvEquipment.UseCompatibleStateImageBehavior = false;
            this.lstvEquipment.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial Number";
            this.colSerial.Width = 209;
            // 
            // colManufact
            // 
            this.colManufact.Text = "Manufacturer";
            this.colManufact.Width = 251;
            // 
            // colCat
            // 
            this.colCat.Text = "Category";
            this.colCat.Width = 274;
            // 
            // btnRemoveAddressAI
            // 
            this.btnRemoveAddressAI.Location = new System.Drawing.Point(683, 15);
            this.btnRemoveAddressAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAddressAI.Name = "btnRemoveAddressAI";
            this.btnRemoveAddressAI.Size = new System.Drawing.Size(153, 30);
            this.btnRemoveAddressAI.TabIndex = 14;
            this.btnRemoveAddressAI.Text = "Remove Address";
            this.btnRemoveAddressAI.UseVisualStyleBackColor = true;
            this.btnRemoveAddressAI.Click += new System.EventHandler(this.btnRemoveAddressAI_Click);
            // 
            // btnAddAddressAI
            // 
            this.btnAddAddressAI.Location = new System.Drawing.Point(858, 15);
            this.btnAddAddressAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAddressAI.Name = "btnAddAddressAI";
            this.btnAddAddressAI.Size = new System.Drawing.Size(153, 30);
            this.btnAddAddressAI.TabIndex = 13;
            this.btnAddAddressAI.Text = "Add Address";
            this.btnAddAddressAI.UseVisualStyleBackColor = true;
            this.btnAddAddressAI.Click += new System.EventHandler(this.btnAddAddressAI_Click);
            // 
            // tbcBusiness
            // 
            this.tbcBusiness.Controls.Add(this.tpgAddress);
            this.tbcBusiness.Controls.Add(this.tpgEquipment);
            this.tbcBusiness.Controls.Add(this.tpgService);
            this.tbcBusiness.Location = new System.Drawing.Point(12, 86);
            this.tbcBusiness.Name = "tbcBusiness";
            this.tbcBusiness.SelectedIndex = 0;
            this.tbcBusiness.Size = new System.Drawing.Size(1070, 360);
            this.tbcBusiness.TabIndex = 15;
            // 
            // tpgAddress
            // 
            this.tpgAddress.Controls.Add(this.btnRemoveAddressAI);
            this.tpgAddress.Controls.Add(this.lstAddressI);
            this.tpgAddress.Controls.Add(this.btnAddAddressAI);
            this.tpgAddress.Location = new System.Drawing.Point(4, 25);
            this.tpgAddress.Name = "tpgAddress";
            this.tpgAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAddress.Size = new System.Drawing.Size(1062, 331);
            this.tpgAddress.TabIndex = 0;
            this.tpgAddress.Text = "Address";
            this.tpgAddress.UseVisualStyleBackColor = true;
            // 
            // tpgEquipment
            // 
            this.tpgEquipment.Controls.Add(this.lstvEquipment);
            this.tpgEquipment.Controls.Add(this.btnAddEquipment);
            this.tpgEquipment.Controls.Add(this.btnRemoveEquipment);
            this.tpgEquipment.Location = new System.Drawing.Point(4, 25);
            this.tpgEquipment.Name = "tpgEquipment";
            this.tpgEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEquipment.Size = new System.Drawing.Size(1062, 331);
            this.tpgEquipment.TabIndex = 1;
            this.tpgEquipment.Text = "Equipment";
            this.tpgEquipment.UseVisualStyleBackColor = true;
            // 
            // tpgService
            // 
            this.tpgService.Controls.Add(this.lstViewIndiv);
            this.tpgService.Location = new System.Drawing.Point(4, 25);
            this.tpgService.Name = "tpgService";
            this.tpgService.Size = new System.Drawing.Size(1062, 331);
            this.tpgService.TabIndex = 2;
            this.tpgService.Text = "Service";
            this.tpgService.UseVisualStyleBackColor = true;
            // 
            // frmViewIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 515);
            this.Controls.Add(this.tbcBusiness);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbIndivSurname);
            this.Controls.Add(this.tbIndivContact);
            this.Controls.Add(this.tbIndivName);
            this.Name = "frmViewIndividual";
            this.Text = "ViewContract";
            this.Load += new System.EventHandler(this.frmViewContract_Load);
            this.tbcBusiness.ResumeLayout(false);
            this.tpgAddress.ResumeLayout(false);
            this.tpgEquipment.ResumeLayout(false);
            this.tpgService.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader colStreetAddressAI;
        private System.Windows.Forms.ColumnHeader colProvinceAI;
        private System.Windows.Forms.ColumnHeader colCountryAI;
        private System.Windows.Forms.ColumnHeader colDistrictAI;
        private System.Windows.Forms.ColumnHeader colLocalityAI;
        private System.Windows.Forms.ColumnHeader colPremiseAI;
        private System.Windows.Forms.ColumnHeader colPostalCodeAI;
        private System.Windows.Forms.Button btnRemoveAddressAI;
        private System.Windows.Forms.Button btnAddAddressAI;
        private System.Windows.Forms.TabControl tbcBusiness;
        private System.Windows.Forms.TabPage tpgAddress;
        private System.Windows.Forms.TabPage tpgEquipment;
        private System.Windows.Forms.TabPage tpgService;
    }
}