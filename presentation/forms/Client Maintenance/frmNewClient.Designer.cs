
namespace Presentation.Forms.ClientMaintenance
{
    partial class frmNewClient
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
            this.tabNewClient = new System.Windows.Forms.TabControl();
            this.tpgAddress = new System.Windows.Forms.TabPage();
            this.tpgEquipment = new System.Windows.Forms.TabPage();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
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
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.tabNewClient.SuspendLayout();
            this.tpgAddress.SuspendLayout();
            this.tpgEquipment.SuspendLayout();
            this.tpgEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(136, 40);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(125, 20);
            this.txtContactNum.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
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
            this.lstEquipment.FullRowSelect = true;
            this.lstEquipment.HideSelection = false;
            this.lstEquipment.Location = new System.Drawing.Point(10, 40);
            this.lstEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.lstEquipment.MultiSelect = false;
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
            this.lstAddress.MultiSelect = false;
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
            // tabNewClient
            // 
            this.tabNewClient.Controls.Add(this.tpgAddress);
            this.tabNewClient.Controls.Add(this.tpgEquipment);
            this.tabNewClient.Controls.Add(this.tpgEmployee);
            this.tabNewClient.Location = new System.Drawing.Point(18, 97);
            this.tabNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.tabNewClient.Name = "tabNewClient";
            this.tabNewClient.SelectedIndex = 0;
            this.tabNewClient.Size = new System.Drawing.Size(844, 245);
            this.tabNewClient.TabIndex = 18;
            // 
            // tpgAddress
            // 
            this.tpgAddress.Controls.Add(this.btnRemoveAddress);
            this.tpgAddress.Controls.Add(this.lstAddress);
            this.tpgAddress.Controls.Add(this.btnAddAddress);
            this.tpgAddress.Location = new System.Drawing.Point(4, 22);
            this.tpgAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tpgAddress.Name = "tpgAddress";
            this.tpgAddress.Padding = new System.Windows.Forms.Padding(2);
            this.tpgAddress.Size = new System.Drawing.Size(836, 219);
            this.tpgAddress.TabIndex = 0;
            this.tpgAddress.Text = "Address";
            this.tpgAddress.UseVisualStyleBackColor = true;
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
            // tpgEmployee
            // 
            this.tpgEmployee.Controls.Add(this.btnRemoveEmployee);
            this.tpgEmployee.Controls.Add(this.lstEmployee);
            this.tpgEmployee.Controls.Add(this.btnAddEmployee);
            this.tpgEmployee.Location = new System.Drawing.Point(4, 22);
            this.tpgEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(836, 219);
            this.tpgEmployee.TabIndex = 3;
            this.tpgEmployee.Text = "Employee";
            this.tpgEmployee.UseVisualStyleBackColor = true;
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
            this.lstEmployee.MultiSelect = false;
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
            // btnRegenerate
            // 
            this.btnRegenerate.Location = new System.Drawing.Point(47, 63);
            this.btnRegenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(83, 22);
            this.btnRegenerate.TabIndex = 23;
            this.btnRegenerate.Text = "Regenerate";
            this.btnRegenerate.UseVisualStyleBackColor = true;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
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
            this.txtSurname.Size = new System.Drawing.Size(125, 20);
            this.txtSurname.TabIndex = 24;
            this.txtSurname.Visible = false;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 396);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabNewClient);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContactNum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewClient";
            this.Text = "frmViewBusinessContract";
            this.Load += new System.EventHandler(this.frmNewBusinessClient_Load);
            this.tabNewClient.ResumeLayout(false);
            this.tpgAddress.ResumeLayout(false);
            this.tpgEquipment.ResumeLayout(false);
            this.tpgEmployee.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabNewClient;
        private System.Windows.Forms.TabPage tpgAddress;
        private System.Windows.Forms.TabPage tpgEquipment;
        private System.Windows.Forms.TabPage tpgEmployee;
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
        private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
    }
}