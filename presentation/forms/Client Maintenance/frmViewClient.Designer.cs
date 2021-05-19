
namespace Presentation.Forms.ClientMaintenance
{
    partial class frmViewClient
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
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstEquipment = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnRemoveAddress = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lstAddress = new System.Windows.Forms.ListView();
            this.colCountryAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProvinceAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistrictAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocalityAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostalCodeAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStreetAddressAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPremiseAB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabViewClient = new System.Windows.Forms.TabControl();
            this.tpgAddresses = new System.Windows.Forms.TabPage();
            this.tpgEquipment = new System.Windows.Forms.TabPage();
            this.tpgEmployees = new System.Windows.Forms.TabPage();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tpgContracts = new System.Windows.Forms.TabPage();
            this.lstContracts = new System.Windows.Forms.ListView();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabViewClient.SuspendLayout();
            this.tpgAddresses.SuspendLayout();
            this.tpgEquipment.SuspendLayout();
            this.tpgEmployees.SuspendLayout();
            this.tpgContracts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(136, 40);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.ReadOnly = true;
            this.txtContactNum.Size = new System.Drawing.Size(125, 20);
            this.txtContactNum.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(795, 346);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 39);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstEquipment
            // 
            this.lstEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colManufact,
            this.colCat});
            this.lstEquipment.HideSelection = false;
            this.lstEquipment.Location = new System.Drawing.Point(10, 40);
            this.lstEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(809, 164);
            this.lstEquipment.TabIndex = 7;
            this.lstEquipment.UseCompatibleStateImageBehavior = false;
            this.lstEquipment.View = System.Windows.Forms.View.Details;
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
            this.btnAddEquipment.Location = new System.Drawing.Point(585, 11);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(115, 25);
            this.btnAddEquipment.TabIndex = 8;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Visible = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(704, 11);
            this.btnRemoveEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(115, 25);
            this.btnRemoveEquipment.TabIndex = 9;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Visible = false;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnRemoveAddress
            // 
            this.btnRemoveAddress.Location = new System.Drawing.Point(704, 11);
            this.btnRemoveAddress.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAddress.Name = "btnRemoveAddress";
            this.btnRemoveAddress.Size = new System.Drawing.Size(115, 25);
            this.btnRemoveAddress.TabIndex = 17;
            this.btnRemoveAddress.Text = "Remove Address";
            this.btnRemoveAddress.UseVisualStyleBackColor = true;
            this.btnRemoveAddress.Visible = false;
            this.btnRemoveAddress.Click += new System.EventHandler(this.btnRemoveAddress_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(585, 11);
            this.btnAddAddress.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(115, 25);
            this.btnAddAddress.TabIndex = 16;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Visible = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // lstAddress
            // 
            this.lstAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCountryAB,
            this.colProvinceAB,
            this.colDistrictAB,
            this.colLocalityAB,
            this.colPostalCodeAB,
            this.colStreetAddressAB,
            this.colPremiseAB});
            this.lstAddress.FullRowSelect = true;
            this.lstAddress.HideSelection = false;
            this.lstAddress.Location = new System.Drawing.Point(10, 40);
            this.lstAddress.Margin = new System.Windows.Forms.Padding(2);
            this.lstAddress.Name = "lstAddress";
            this.lstAddress.Size = new System.Drawing.Size(809, 164);
            this.lstAddress.TabIndex = 15;
            this.lstAddress.UseCompatibleStateImageBehavior = false;
            this.lstAddress.View = System.Windows.Forms.View.Details;
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
            // tabViewClient
            // 
            this.tabViewClient.Controls.Add(this.tpgAddresses);
            this.tabViewClient.Controls.Add(this.tpgEquipment);
            this.tabViewClient.Controls.Add(this.tpgEmployees);
            this.tabViewClient.Controls.Add(this.tpgContracts);
            this.tabViewClient.Location = new System.Drawing.Point(18, 97);
            this.tabViewClient.Margin = new System.Windows.Forms.Padding(2);
            this.tabViewClient.Name = "tabViewClient";
            this.tabViewClient.SelectedIndex = 0;
            this.tabViewClient.Size = new System.Drawing.Size(844, 245);
            this.tabViewClient.TabIndex = 18;
            // 
            // tpgAddresses
            // 
            this.tpgAddresses.Controls.Add(this.btnRemoveAddress);
            this.tpgAddresses.Controls.Add(this.lstAddress);
            this.tpgAddresses.Controls.Add(this.btnAddAddress);
            this.tpgAddresses.Location = new System.Drawing.Point(4, 22);
            this.tpgAddresses.Margin = new System.Windows.Forms.Padding(2);
            this.tpgAddresses.Name = "tpgAddresses";
            this.tpgAddresses.Padding = new System.Windows.Forms.Padding(2);
            this.tpgAddresses.Size = new System.Drawing.Size(836, 219);
            this.tpgAddresses.TabIndex = 0;
            this.tpgAddresses.Text = "Addresses";
            this.tpgAddresses.UseVisualStyleBackColor = true;
            // 
            // tpgEquipment
            // 
            this.tpgEquipment.Controls.Add(this.lstEquipment);
            this.tpgEquipment.Controls.Add(this.btnRemoveEquipment);
            this.tpgEquipment.Controls.Add(this.btnAddEquipment);
            this.tpgEquipment.Location = new System.Drawing.Point(4, 22);
            this.tpgEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.tpgEquipment.Name = "tpgEquipment";
            this.tpgEquipment.Padding = new System.Windows.Forms.Padding(2);
            this.tpgEquipment.Size = new System.Drawing.Size(836, 219);
            this.tpgEquipment.TabIndex = 1;
            this.tpgEquipment.Text = "Equipment";
            this.tpgEquipment.UseVisualStyleBackColor = true;
            // 
            // tpgEmployees
            // 
            this.tpgEmployees.Controls.Add(this.btnRemoveEmployee);
            this.tpgEmployees.Controls.Add(this.lstEmployee);
            this.tpgEmployees.Controls.Add(this.btnAddEmployee);
            this.tpgEmployees.Location = new System.Drawing.Point(4, 22);
            this.tpgEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.tpgEmployees.Name = "tpgEmployees";
            this.tpgEmployees.Size = new System.Drawing.Size(836, 219);
            this.tpgEmployees.TabIndex = 3;
            this.tpgEmployees.Text = "Employees";
            this.tpgEmployees.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(704, 11);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(115, 25);
            this.btnRemoveEmployee.TabIndex = 20;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Visible = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
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
            this.lstEmployee.Location = new System.Drawing.Point(10, 40);
            this.lstEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(809, 164);
            this.lstEmployee.TabIndex = 18;
            this.lstEmployee.UseCompatibleStateImageBehavior = false;
            this.lstEmployee.View = System.Windows.Forms.View.Details;
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
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(585, 11);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(115, 25);
            this.btnAddEmployee.TabIndex = 19;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Visible = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Business Name:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(23, 43);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(87, 13);
            this.lblContactNum.TabIndex = 20;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 64);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 20);
            this.txtID.TabIndex = 21;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(284, 19);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 25;
            this.lblSurname.Text = "Surname:";
            this.lblSurname.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(397, 16);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(125, 20);
            this.txtSurname.TabIndex = 24;
            this.txtSurname.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(795, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 39);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tpgContracts
            // 
            this.tpgContracts.Controls.Add(this.lstContracts);
            this.tpgContracts.Location = new System.Drawing.Point(4, 22);
            this.tpgContracts.Name = "tpgContracts";
            this.tpgContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tpgContracts.Size = new System.Drawing.Size(836, 219);
            this.tpgContracts.TabIndex = 4;
            this.tpgContracts.Text = "Contracts";
            this.tpgContracts.UseVisualStyleBackColor = true;
            // 
            // lstContracts
            // 
            this.lstContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescription,
            this.colStartDate,
            this.colEndDate});
            this.lstContracts.FullRowSelect = true;
            this.lstContracts.HideSelection = false;
            this.lstContracts.Location = new System.Drawing.Point(10, 40);
            this.lstContracts.Margin = new System.Windows.Forms.Padding(2);
            this.lstContracts.Name = "lstContracts";
            this.lstContracts.Size = new System.Drawing.Size(809, 164);
            this.lstContracts.TabIndex = 16;
            this.lstContracts.UseCompatibleStateImageBehavior = false;
            this.lstContracts.View = System.Windows.Forms.View.Details;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 108;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 107;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 108;
            // 
            // frmViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 396);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabViewClient);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContactNum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewClient";
            this.Text = "frmViewClient";
            this.Load += new System.EventHandler(this.frmViewClient_Load);
            this.tabViewClient.ResumeLayout(false);
            this.tpgAddresses.ResumeLayout(false);
            this.tpgEquipment.ResumeLayout(false);
            this.tpgEmployees.ResumeLayout(false);
            this.tpgContracts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lstEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colManufact;
        private System.Windows.Forms.ColumnHeader colCat;
        private System.Windows.Forms.Button btnRemoveAddress;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.ListView lstAddress;
        private System.Windows.Forms.ColumnHeader colStreetAddressAB;
        private System.Windows.Forms.ColumnHeader colProvinceAB;
        private System.Windows.Forms.ColumnHeader colCountryAB;
        private System.Windows.Forms.ColumnHeader colDistrictAB;
        private System.Windows.Forms.ColumnHeader colLocalityAB;
        private System.Windows.Forms.ColumnHeader colPremiseAB;
        private System.Windows.Forms.ColumnHeader colPostalCodeAB;
        private System.Windows.Forms.TabControl tabViewClient;
        private System.Windows.Forms.TabPage tpgAddresses;
        private System.Windows.Forms.TabPage tpgEquipment;
        private System.Windows.Forms.TabPage tpgEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.ListView lstEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSurname;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colContactNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tpgContracts;
        private System.Windows.Forms.ListView lstContracts;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
    }
}