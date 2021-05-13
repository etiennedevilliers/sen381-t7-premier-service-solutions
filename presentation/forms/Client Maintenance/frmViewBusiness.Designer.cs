
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmViewBusiness
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
            this.lstViewBusi = new System.Windows.Forms.ListView();
            this.colDescript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbBusContact = new System.Windows.Forms.TextBox();
            this.tbBusiName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstvEquipment = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnRemoveAddressAB = new System.Windows.Forms.Button();
            this.btnAddAddressAB = new System.Windows.Forms.Button();
            this.lstAddressB = new System.Windows.Forms.ListView();
            this.colCountryAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProvinceAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistrictAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocalityAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostalCodeAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStreetAddressAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPremiseAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcViewBusiness = new System.Windows.Forms.TabControl();
            this.tbpAddress = new System.Windows.Forms.TabPage();
            this.tpgEquipment = new System.Windows.Forms.TabPage();
            this.tpgServices = new System.Windows.Forms.TabPage();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
            this.btnRemoveEmpl = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListView();
            this.btnAddEmpl = new System.Windows.Forms.Button();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcViewBusiness.SuspendLayout();
            this.tbpAddress.SuspendLayout();
            this.tpgEquipment.SuspendLayout();
            this.tpgServices.SuspendLayout();
            this.tpgEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewBusi
            // 
            this.lstViewBusi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescript,
            this.colStartDate,
            this.colEndDate});
            this.lstViewBusi.HideSelection = false;
            this.lstViewBusi.Location = new System.Drawing.Point(13, 35);
            this.lstViewBusi.Name = "lstViewBusi";
            this.lstViewBusi.Size = new System.Drawing.Size(952, 234);
            this.lstViewBusi.TabIndex = 1;
            this.lstViewBusi.UseCompatibleStateImageBehavior = false;
            this.lstViewBusi.View = System.Windows.Forms.View.Details;
            // 
            // colDescript
            // 
            this.colDescript.Text = "Service Description";
            this.colDescript.Width = 294;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 229;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 231;
            // 
            // tbBusContact
            // 
            this.tbBusContact.Location = new System.Drawing.Point(28, 23);
            this.tbBusContact.Name = "tbBusContact";
            this.tbBusContact.Size = new System.Drawing.Size(165, 22);
            this.tbBusContact.TabIndex = 2;
            // 
            // tbBusiName
            // 
            this.tbBusiName.Location = new System.Drawing.Point(199, 23);
            this.tbBusiName.Name = "tbBusiName";
            this.tbBusiName.Size = new System.Drawing.Size(165, 22);
            this.tbBusiName.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(389, 12);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 48);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1051, 417);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 48);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstvEquipment
            // 
            this.lstvEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colManufact,
            this.colCat});
            this.lstvEquipment.HideSelection = false;
            this.lstvEquipment.Location = new System.Drawing.Point(17, 56);
            this.lstvEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.lstvEquipment.Name = "lstvEquipment";
            this.lstvEquipment.Size = new System.Drawing.Size(1079, 194);
            this.lstvEquipment.TabIndex = 7;
            this.lstvEquipment.UseCompatibleStateImageBehavior = false;
            this.lstvEquipment.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial Number";
            this.colSerial.Width = 264;
            // 
            // colManufact
            // 
            this.colManufact.Text = "Manufacturer";
            this.colManufact.Width = 249;
            // 
            // colCat
            // 
            this.colCat.Text = "Category";
            this.colCat.Width = 246;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(941, 21);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(153, 31);
            this.btnAddEquipment.TabIndex = 8;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(766, 21);
            this.btnRemoveEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(153, 31);
            this.btnRemoveEquipment.TabIndex = 9;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnRemoveAddressAB
            // 
            this.btnRemoveAddressAB.Location = new System.Drawing.Point(725, 15);
            this.btnRemoveAddressAB.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAddressAB.Name = "btnRemoveAddressAB";
            this.btnRemoveAddressAB.Size = new System.Drawing.Size(153, 30);
            this.btnRemoveAddressAB.TabIndex = 17;
            this.btnRemoveAddressAB.Text = "Remove Address";
            this.btnRemoveAddressAB.UseVisualStyleBackColor = true;
            this.btnRemoveAddressAB.Click += new System.EventHandler(this.btnRemoveAddressAB_Click);
            // 
            // btnAddAddressAB
            // 
            this.btnAddAddressAB.Location = new System.Drawing.Point(937, 15);
            this.btnAddAddressAB.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAddressAB.Name = "btnAddAddressAB";
            this.btnAddAddressAB.Size = new System.Drawing.Size(153, 30);
            this.btnAddAddressAB.TabIndex = 16;
            this.btnAddAddressAB.Text = "Add Address";
            this.btnAddAddressAB.UseVisualStyleBackColor = true;
            this.btnAddAddressAB.Click += new System.EventHandler(this.btnAddAddressAB_Click);
            // 
            // lstAddressB
            // 
            this.lstAddressB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCountryAB,
            this.colProvinceAB,
            this.colDistrictAB,
            this.colLocalityAB,
            this.colPostalCodeAB,
            this.colStreetAddressAB,
            this.colPremiseAB});
            this.lstAddressB.FullRowSelect = true;
            this.lstAddressB.HideSelection = false;
            this.lstAddressB.Location = new System.Drawing.Point(14, 49);
            this.lstAddressB.Margin = new System.Windows.Forms.Padding(2);
            this.lstAddressB.Name = "lstAddressB";
            this.lstAddressB.Size = new System.Drawing.Size(1077, 201);
            this.lstAddressB.TabIndex = 15;
            this.lstAddressB.UseCompatibleStateImageBehavior = false;
            this.lstAddressB.View = System.Windows.Forms.View.Details;
            // 
            // colCountryAB
            // 
            this.colCountryAB.Text = "Country";
            this.colCountryAB.Width = 108;
            // 
            // colProvinceAB
            // 
            this.colProvinceAB.Text = "Province";
            this.colProvinceAB.Width = 107;
            // 
            // colDistrictAB
            // 
            this.colDistrictAB.Text = "District";
            this.colDistrictAB.Width = 108;
            // 
            // colLocalityAB
            // 
            this.colLocalityAB.Text = "Locality";
            this.colLocalityAB.Width = 101;
            // 
            // colPostalCodeAB
            // 
            this.colPostalCodeAB.Text = "Postal Code";
            this.colPostalCodeAB.Width = 88;
            // 
            // colStreetAddressAB
            // 
            this.colStreetAddressAB.Text = "Street Address";
            this.colStreetAddressAB.Width = 150;
            // 
            // colPremiseAB
            // 
            this.colPremiseAB.Text = "Premise";
            this.colPremiseAB.Width = 101;
            // 
            // tbcViewBusiness
            // 
            this.tbcViewBusiness.Controls.Add(this.tbpAddress);
            this.tbcViewBusiness.Controls.Add(this.tpgEquipment);
            this.tbcViewBusiness.Controls.Add(this.tpgServices);
            this.tbcViewBusiness.Controls.Add(this.tpgEmployee);
            this.tbcViewBusiness.Location = new System.Drawing.Point(29, 86);
            this.tbcViewBusiness.Name = "tbcViewBusiness";
            this.tbcViewBusiness.SelectedIndex = 0;
            this.tbcViewBusiness.Size = new System.Drawing.Size(1126, 301);
            this.tbcViewBusiness.TabIndex = 18;
            // 
            // tbpAddress
            // 
            this.tbpAddress.Controls.Add(this.btnRemoveAddressAB);
            this.tbpAddress.Controls.Add(this.lstAddressB);
            this.tbpAddress.Controls.Add(this.btnAddAddressAB);
            this.tbpAddress.Location = new System.Drawing.Point(4, 25);
            this.tbpAddress.Name = "tbpAddress";
            this.tbpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddress.Size = new System.Drawing.Size(1118, 272);
            this.tbpAddress.TabIndex = 0;
            this.tbpAddress.Text = "Address";
            this.tbpAddress.UseVisualStyleBackColor = true;
            // 
            // tpgEquipment
            // 
            this.tpgEquipment.Controls.Add(this.lstvEquipment);
            this.tpgEquipment.Controls.Add(this.btnRemoveEquipment);
            this.tpgEquipment.Controls.Add(this.btnAddEquipment);
            this.tpgEquipment.Location = new System.Drawing.Point(4, 25);
            this.tpgEquipment.Name = "tpgEquipment";
            this.tpgEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEquipment.Size = new System.Drawing.Size(1118, 272);
            this.tpgEquipment.TabIndex = 1;
            this.tpgEquipment.Text = "Equipment";
            this.tpgEquipment.UseVisualStyleBackColor = true;
            // 
            // tpgServices
            // 
            this.tpgServices.Controls.Add(this.lstViewBusi);
            this.tpgServices.Location = new System.Drawing.Point(4, 25);
            this.tpgServices.Name = "tpgServices";
            this.tpgServices.Size = new System.Drawing.Size(1118, 272);
            this.tpgServices.TabIndex = 2;
            this.tpgServices.Text = "Services";
            this.tpgServices.UseVisualStyleBackColor = true;
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Controls.Add(this.btnRemoveEmpl);
            this.tpgEmployee.Controls.Add(this.lstEmployee);
            this.tpgEmployee.Controls.Add(this.btnAddEmpl);
            this.tpgEmployee.Location = new System.Drawing.Point(4, 25);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(1118, 272);
            this.tpgEmployee.TabIndex = 3;
            this.tpgEmployee.Text = "Employee";
            this.tpgEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmpl
            // 
            this.btnRemoveEmpl.Location = new System.Drawing.Point(732, 19);
            this.btnRemoveEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmpl.Name = "btnRemoveEmpl";
            this.btnRemoveEmpl.Size = new System.Drawing.Size(153, 30);
            this.btnRemoveEmpl.TabIndex = 20;
            this.btnRemoveEmpl.Text = "Remove Employee";
            this.btnRemoveEmpl.UseVisualStyleBackColor = true;
            this.btnRemoveEmpl.Click += new System.EventHandler(this.btnRemoveEmpl_Click);
            // 
            // lstEmployee
            // 
            this.lstEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSurname,
            this.colRole,
            this.colContactNum});
            this.lstEmployee.FullRowSelect = true;
            this.lstEmployee.HideSelection = false;
            this.lstEmployee.Location = new System.Drawing.Point(21, 53);
            this.lstEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(1077, 201);
            this.lstEmployee.TabIndex = 18;
            this.lstEmployee.UseCompatibleStateImageBehavior = false;
            this.lstEmployee.View = System.Windows.Forms.View.Details;
            // 
            // btnAddEmpl
            // 
            this.btnAddEmpl.Location = new System.Drawing.Point(944, 19);
            this.btnAddEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmpl.Name = "btnAddEmpl";
            this.btnAddEmpl.Size = new System.Drawing.Size(153, 30);
            this.btnAddEmpl.TabIndex = 19;
            this.btnAddEmpl.Text = "Add Employee";
            this.btnAddEmpl.UseVisualStyleBackColor = true;
            this.btnAddEmpl.Click += new System.EventHandler(this.btnAddEmpl_Click);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 132;
            // 
            // colSurname
            // 
            this.colSurname.Text = "Surname";
            this.colSurname.Width = 151;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 161;
            // 
            // colContactNum
            // 
            this.colContactNum.Text = "Contact Number";
            this.colContactNum.Width = 186;
            // 
            // frmViewBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 496);
            this.Controls.Add(this.tbcViewBusiness);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbBusiName);
            this.Controls.Add(this.tbBusContact);
            this.Name = "frmViewBusiness";
            this.Text = "frmViewBusinessContract";
            this.Load += new System.EventHandler(this.frmViewBusinessContract_Load);
            this.tbcViewBusiness.ResumeLayout(false);
            this.tbpAddress.ResumeLayout(false);
            this.tpgEquipment.ResumeLayout(false);
            this.tpgServices.ResumeLayout(false);
            this.tpgEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewBusi;
        private System.Windows.Forms.TextBox tbBusContact;
        private System.Windows.Forms.TextBox tbBusiName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ColumnHeader colDescript;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lstvEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colManufact;
        private System.Windows.Forms.ColumnHeader colCat;
        private System.Windows.Forms.Button btnRemoveAddressAB;
        private System.Windows.Forms.Button btnAddAddressAB;
        private System.Windows.Forms.ListView lstAddressB;
        private System.Windows.Forms.ColumnHeader colStreetAddressAB;
        private System.Windows.Forms.ColumnHeader colProvinceAB;
        private System.Windows.Forms.ColumnHeader colCountryAB;
        private System.Windows.Forms.ColumnHeader colDistrictAB;
        private System.Windows.Forms.ColumnHeader colLocalityAB;
        private System.Windows.Forms.ColumnHeader colPremiseAB;
        private System.Windows.Forms.ColumnHeader colPostalCodeAB;
        private System.Windows.Forms.TabControl tbcViewBusiness;
        private System.Windows.Forms.TabPage tbpAddress;
        private System.Windows.Forms.TabPage tpgEquipment;
        private System.Windows.Forms.TabPage tpgServices;
        private System.Windows.Forms.TabPage tpgEmployee;
        private System.Windows.Forms.Button btnRemoveEmpl;
        private System.Windows.Forms.ListView lstEmployee;
        private System.Windows.Forms.Button btnAddEmpl;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSurname;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colContactNum;
    }
}