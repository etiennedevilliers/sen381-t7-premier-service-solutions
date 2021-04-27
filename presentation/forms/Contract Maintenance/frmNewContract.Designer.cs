
namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmNewContract
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
            this.tabContracts = new System.Windows.Forms.TabPage();
            this.grbxServiceContracts = new System.Windows.Forms.GroupBox();
            this.lblImportanceLevel = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cmbIdentNumber = new System.Windows.Forms.ComboBox();
            this.cmbAddPackage = new System.Windows.Forms.ComboBox();
            this.dtpDateTer = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFianal = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDateTerminated = new System.Windows.Forms.Label();
            this.btnSCDone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSCDescription = new System.Windows.Forms.Label();
            this.txtSCDescription = new System.Windows.Forms.TextBox();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.gbPackage = new System.Windows.Forms.GroupBox();
            this.cmbxSla = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxService = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPDis = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.btnAddPcak = new System.Windows.Forms.Button();
            this.gbrxServiceLevelAgreement = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLADescription = new System.Windows.Forms.TextBox();
            this.btnAddServiceLevelAgreement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxService = new System.Windows.Forms.GroupBox();
            this.btnServiceDone = new System.Windows.Forms.Button();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.lblServiceDiscription = new System.Windows.Forms.Label();
            this.txtServiceDuration = new System.Windows.Forms.TextBox();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.btnService = new System.Windows.Forms.Button();
            this.lstViewItems = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnAddSLA = new System.Windows.Forms.Button();
            this.btnAddContracts = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnView_All_Service_Contracts = new System.Windows.Forms.Button();
            this.tabPackage = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabSLA = new System.Windows.Forms.TabPage();
            this.btnViewSLA = new System.Windows.Forms.Button();
            this.listViewServiceLevelAgreemnet = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabContracts.SuspendLayout();
            this.grbxServiceContracts.SuspendLayout();
            this.gbPackage.SuspendLayout();
            this.gbrxServiceLevelAgreement.SuspendLayout();
            this.gbxService.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabService.SuspendLayout();
            this.tabSLA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContracts);
            this.tabControl1.Controls.Add(this.tabPackage);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Controls.Add(this.tabSLA);
            this.tabControl1.Location = new System.Drawing.Point(-750, -440);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3152, 1733);
            this.tabControl1.TabIndex = 1;
            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.grbxServiceContracts);
            this.tabContracts.Controls.Add(this.gbPackage);
            this.tabContracts.Controls.Add(this.gbrxServiceLevelAgreement);
            this.tabContracts.Controls.Add(this.label6);
            this.tabContracts.Controls.Add(this.gbxService);
            this.tabContracts.Controls.Add(this.lstViewItems);
            this.tabContracts.Controls.Add(this.groupBox1);
            this.tabContracts.Controls.Add(this.button2);
            this.tabContracts.Controls.Add(this.btnView_All_Service_Contracts);
            this.tabContracts.Location = new System.Drawing.Point(4, 22);
            this.tabContracts.Margin = new System.Windows.Forms.Padding(2);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Padding = new System.Windows.Forms.Padding(2);
            this.tabContracts.Size = new System.Drawing.Size(3144, 1707);
            this.tabContracts.TabIndex = 0;
            this.tabContracts.UseVisualStyleBackColor = true;
            // 
            // grbxServiceContracts
            // 
            this.grbxServiceContracts.Controls.Add(this.lblImportanceLevel);
            this.grbxServiceContracts.Controls.Add(this.lblPackage);
            this.grbxServiceContracts.Controls.Add(this.cmbIdentNumber);
            this.grbxServiceContracts.Controls.Add(this.cmbAddPackage);
            this.grbxServiceContracts.Controls.Add(this.dtpDateTer);
            this.grbxServiceContracts.Controls.Add(this.dtpDateFianal);
            this.grbxServiceContracts.Controls.Add(this.lblStatus);
            this.grbxServiceContracts.Controls.Add(this.txtStatus);
            this.grbxServiceContracts.Controls.Add(this.txtCost);
            this.grbxServiceContracts.Controls.Add(this.lblCost);
            this.grbxServiceContracts.Controls.Add(this.lblDateTerminated);
            this.grbxServiceContracts.Controls.Add(this.btnSCDone);
            this.grbxServiceContracts.Controls.Add(this.label3);
            this.grbxServiceContracts.Controls.Add(this.lblSCDescription);
            this.grbxServiceContracts.Controls.Add(this.txtSCDescription);
            this.grbxServiceContracts.Controls.Add(this.btnAddContract);
            this.grbxServiceContracts.Location = new System.Drawing.Point(1774, 438);
            this.grbxServiceContracts.Margin = new System.Windows.Forms.Padding(2);
            this.grbxServiceContracts.Name = "grbxServiceContracts";
            this.grbxServiceContracts.Padding = new System.Windows.Forms.Padding(2);
            this.grbxServiceContracts.Size = new System.Drawing.Size(360, 353);
            this.grbxServiceContracts.TabIndex = 10;
            this.grbxServiceContracts.TabStop = false;
            this.grbxServiceContracts.Text = "New Service Cotract";
            // 
            // lblImportanceLevel
            // 
            this.lblImportanceLevel.AutoSize = true;
            this.lblImportanceLevel.Location = new System.Drawing.Point(16, 230);
            this.lblImportanceLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImportanceLevel.Name = "lblImportanceLevel";
            this.lblImportanceLevel.Size = new System.Drawing.Size(101, 13);
            this.lblImportanceLevel.TabIndex = 15;
            this.lblImportanceLevel.Text = "Level of Importance";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(16, 193);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(50, 13);
            this.lblPackage.TabIndex = 14;
            this.lblPackage.Text = "Package";
            // 
            // cmbIdentNumber
            // 
            this.cmbIdentNumber.FormattingEnabled = true;
            this.cmbIdentNumber.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbIdentNumber.Location = new System.Drawing.Point(162, 226);
            this.cmbIdentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdentNumber.Name = "cmbIdentNumber";
            this.cmbIdentNumber.Size = new System.Drawing.Size(168, 21);
            this.cmbIdentNumber.TabIndex = 13;
            // 
            // cmbAddPackage
            // 
            this.cmbAddPackage.FormattingEnabled = true;
            this.cmbAddPackage.Location = new System.Drawing.Point(162, 189);
            this.cmbAddPackage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddPackage.Name = "cmbAddPackage";
            this.cmbAddPackage.Size = new System.Drawing.Size(168, 21);
            this.cmbAddPackage.TabIndex = 10;
            // 
            // dtpDateTer
            // 
            this.dtpDateTer.Location = new System.Drawing.Point(160, 87);
            this.dtpDateTer.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateTer.Name = "dtpDateTer";
            this.dtpDateTer.Size = new System.Drawing.Size(170, 20);
            this.dtpDateTer.TabIndex = 12;
            // 
            // dtpDateFianal
            // 
            this.dtpDateFianal.Location = new System.Drawing.Point(160, 62);
            this.dtpDateFianal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateFianal.Name = "dtpDateFianal";
            this.dtpDateFianal.Size = new System.Drawing.Size(170, 20);
            this.dtpDateFianal.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 153);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(161, 151);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(168, 20);
            this.txtStatus.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(161, 120);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(168, 20);
            this.txtCost.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(16, 120);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // lblDateTerminated
            // 
            this.lblDateTerminated.AutoSize = true;
            this.lblDateTerminated.Location = new System.Drawing.Point(16, 89);
            this.lblDateTerminated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTerminated.Name = "lblDateTerminated";
            this.lblDateTerminated.Size = new System.Drawing.Size(83, 13);
            this.lblDateTerminated.TabIndex = 6;
            this.lblDateTerminated.Text = "DateTerminated";
            // 
            // btnSCDone
            // 
            this.btnSCDone.AutoEllipsis = true;
            this.btnSCDone.Location = new System.Drawing.Point(188, 298);
            this.btnSCDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnSCDone.Name = "btnSCDone";
            this.btnSCDone.Size = new System.Drawing.Size(140, 23);
            this.btnSCDone.TabIndex = 5;
            this.btnSCDone.Text = "Done";
            this.btnSCDone.UseVisualStyleBackColor = true;
            this.btnSCDone.Click += new System.EventHandler(this.btnSCDone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Finalised";
            // 
            // lblSCDescription
            // 
            this.lblSCDescription.AutoSize = true;
            this.lblSCDescription.Location = new System.Drawing.Point(16, 30);
            this.lblSCDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSCDescription.Name = "lblSCDescription";
            this.lblSCDescription.Size = new System.Drawing.Size(142, 13);
            this.lblSCDescription.TabIndex = 3;
            this.lblSCDescription.Text = "Service Contract Description";
            // 
            // txtSCDescription
            // 
            this.txtSCDescription.Location = new System.Drawing.Point(161, 27);
            this.txtSCDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtSCDescription.Name = "txtSCDescription";
            this.txtSCDescription.Size = new System.Drawing.Size(168, 20);
            this.txtSCDescription.TabIndex = 1;
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(18, 298);
            this.btnAddContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(140, 23);
            this.btnAddContract.TabIndex = 0;
            this.btnAddContract.Text = "Add Service Contract";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // gbPackage
            // 
            this.gbPackage.Controls.Add(this.cmbxSla);
            this.gbPackage.Controls.Add(this.label11);
            this.gbPackage.Controls.Add(this.cmbxService);
            this.gbPackage.Controls.Add(this.label10);
            this.gbPackage.Controls.Add(this.button7);
            this.gbPackage.Controls.Add(this.label7);
            this.gbPackage.Controls.Add(this.label9);
            this.gbPackage.Controls.Add(this.txtPDis);
            this.gbPackage.Controls.Add(this.txtPname);
            this.gbPackage.Controls.Add(this.btnAddPcak);
            this.gbPackage.Location = new System.Drawing.Point(1400, 432);
            this.gbPackage.Margin = new System.Windows.Forms.Padding(2);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Padding = new System.Windows.Forms.Padding(2);
            this.gbPackage.Size = new System.Drawing.Size(360, 212);
            this.gbPackage.TabIndex = 6;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "New Package";
            // 
            // cmbxSla
            // 
            this.cmbxSla.FormattingEnabled = true;
            this.cmbxSla.Location = new System.Drawing.Point(162, 120);
            this.cmbxSla.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxSla.Name = "cmbxSla";
            this.cmbxSla.Size = new System.Drawing.Size(168, 21);
            this.cmbxSla.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "SLA ID";
            // 
            // cmbxService
            // 
            this.cmbxService.FormattingEnabled = true;
            this.cmbxService.Location = new System.Drawing.Point(161, 89);
            this.cmbxService.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxService.Name = "cmbxService";
            this.cmbxService.Size = new System.Drawing.Size(168, 21);
            this.cmbxService.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Service ID";
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.Location = new System.Drawing.Point(188, 158);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Done";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Package Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Package Name";
            // 
            // txtPDis
            // 
            this.txtPDis.Location = new System.Drawing.Point(161, 59);
            this.txtPDis.Margin = new System.Windows.Forms.Padding(2);
            this.txtPDis.Name = "txtPDis";
            this.txtPDis.Size = new System.Drawing.Size(168, 20);
            this.txtPDis.TabIndex = 2;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(161, 27);
            this.txtPname.Margin = new System.Windows.Forms.Padding(2);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(168, 20);
            this.txtPname.TabIndex = 1;
            // 
            // btnAddPcak
            // 
            this.btnAddPcak.Location = new System.Drawing.Point(18, 158);
            this.btnAddPcak.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPcak.Name = "btnAddPcak";
            this.btnAddPcak.Size = new System.Drawing.Size(140, 23);
            this.btnAddPcak.TabIndex = 0;
            this.btnAddPcak.Text = "Add Package";
            this.btnAddPcak.UseVisualStyleBackColor = true;
            this.btnAddPcak.Click += new System.EventHandler(this.button8_Click);
            // 
            // gbrxServiceLevelAgreement
            // 
            this.gbrxServiceLevelAgreement.Controls.Add(this.button6);
            this.gbrxServiceLevelAgreement.Controls.Add(this.label8);
            this.gbrxServiceLevelAgreement.Controls.Add(this.txtSLADescription);
            this.gbrxServiceLevelAgreement.Controls.Add(this.btnAddServiceLevelAgreement);
            this.gbrxServiceLevelAgreement.Location = new System.Drawing.Point(1037, 640);
            this.gbrxServiceLevelAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.gbrxServiceLevelAgreement.Name = "gbrxServiceLevelAgreement";
            this.gbrxServiceLevelAgreement.Padding = new System.Windows.Forms.Padding(2);
            this.gbrxServiceLevelAgreement.Size = new System.Drawing.Size(408, 136);
            this.gbrxServiceLevelAgreement.TabIndex = 6;
            this.gbrxServiceLevelAgreement.TabStop = false;
            this.gbrxServiceLevelAgreement.Text = "New Service Level Agreement ";
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.Location = new System.Drawing.Point(256, 87);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Done";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "ServiceLevel Agreement Description";
            // 
            // txtSLADescription
            // 
            this.txtSLADescription.Location = new System.Drawing.Point(204, 42);
            this.txtSLADescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtSLADescription.Name = "txtSLADescription";
            this.txtSLADescription.Size = new System.Drawing.Size(168, 20);
            this.txtSLADescription.TabIndex = 1;
            // 
            // btnAddServiceLevelAgreement
            // 
            this.btnAddServiceLevelAgreement.Location = new System.Drawing.Point(16, 87);
            this.btnAddServiceLevelAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddServiceLevelAgreement.Name = "btnAddServiceLevelAgreement";
            this.btnAddServiceLevelAgreement.Size = new System.Drawing.Size(178, 23);
            this.btnAddServiceLevelAgreement.TabIndex = 0;
            this.btnAddServiceLevelAgreement.Text = "Add Service Level Agreement";
            this.btnAddServiceLevelAgreement.UseVisualStyleBackColor = true;
            this.btnAddServiceLevelAgreement.Click += new System.EventHandler(this.btnAddServiceLevelAgreement_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // gbxService
            // 
            this.gbxService.Controls.Add(this.btnServiceDone);
            this.gbxService.Controls.Add(this.lblServiceDuration);
            this.gbxService.Controls.Add(this.lblServiceDiscription);
            this.gbxService.Controls.Add(this.txtServiceDuration);
            this.gbxService.Controls.Add(this.txtServiceDescription);
            this.gbxService.Controls.Add(this.btnService);
            this.gbxService.Location = new System.Drawing.Point(1037, 426);
            this.gbxService.Margin = new System.Windows.Forms.Padding(2);
            this.gbxService.Name = "gbxService";
            this.gbxService.Padding = new System.Windows.Forms.Padding(2);
            this.gbxService.Size = new System.Drawing.Size(360, 200);
            this.gbxService.TabIndex = 5;
            this.gbxService.TabStop = false;
            this.gbxService.Text = "New Service";
            // 
            // btnServiceDone
            // 
            this.btnServiceDone.AutoEllipsis = true;
            this.btnServiceDone.Location = new System.Drawing.Point(188, 157);
            this.btnServiceDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceDone.Name = "btnServiceDone";
            this.btnServiceDone.Size = new System.Drawing.Size(140, 23);
            this.btnServiceDone.TabIndex = 5;
            this.btnServiceDone.Text = "Done";
            this.btnServiceDone.UseVisualStyleBackColor = true;
            this.btnServiceDone.Click += new System.EventHandler(this.btnServiceDone_Click);
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Location = new System.Drawing.Point(38, 110);
            this.lblServiceDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(86, 13);
            this.lblServiceDuration.TabIndex = 4;
            this.lblServiceDuration.Text = "Service Duration";
            // 
            // lblServiceDiscription
            // 
            this.lblServiceDiscription.AutoSize = true;
            this.lblServiceDiscription.Location = new System.Drawing.Point(38, 70);
            this.lblServiceDiscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceDiscription.Name = "lblServiceDiscription";
            this.lblServiceDiscription.Size = new System.Drawing.Size(99, 13);
            this.lblServiceDiscription.TabIndex = 3;
            this.lblServiceDiscription.Text = "Service Description";
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.Location = new System.Drawing.Point(161, 110);
            this.txtServiceDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.Size = new System.Drawing.Size(168, 20);
            this.txtServiceDuration.TabIndex = 2;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(161, 67);
            this.txtServiceDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(168, 20);
            this.txtServiceDescription.TabIndex = 1;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(16, 157);
            this.btnService.Margin = new System.Windows.Forms.Padding(2);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(140, 23);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "Add Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lstViewItems
            // 
            this.lstViewItems.HideSelection = false;
            this.lstViewItems.Location = new System.Drawing.Point(985, 836);
            this.lstViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewItems.Name = "lstViewItems";
            this.lstViewItems.Size = new System.Drawing.Size(724, 396);
            this.lstViewItems.TabIndex = 4;
            this.lstViewItems.UseCompatibleStateImageBehavior = false;
            this.lstViewItems.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btnAddService);
            this.groupBox1.Controls.Add(this.btnAddSLA);
            this.groupBox1.Controls.Add(this.btnAddContracts);
            this.groupBox1.Controls.Add(this.btnAddPackage);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(752, 426);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 255);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Elements";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(22, 192);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(206, 25);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Add Service ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddSLA
            // 
            this.btnAddSLA.Location = new System.Drawing.Point(22, 143);
            this.btnAddSLA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSLA.Name = "btnAddSLA";
            this.btnAddSLA.Size = new System.Drawing.Size(206, 25);
            this.btnAddSLA.TabIndex = 2;
            this.btnAddSLA.Text = "Add Service Level Agreement";
            this.btnAddSLA.UseVisualStyleBackColor = true;
            this.btnAddSLA.Click += new System.EventHandler(this.btnAddSLA_Click);
            // 
            // btnAddContracts
            // 
            this.btnAddContracts.Location = new System.Drawing.Point(22, 96);
            this.btnAddContracts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddContracts.Name = "btnAddContracts";
            this.btnAddContracts.Size = new System.Drawing.Size(206, 25);
            this.btnAddContracts.TabIndex = 1;
            this.btnAddContracts.Text = "Add Service Contract";
            this.btnAddContracts.UseVisualStyleBackColor = true;
            this.btnAddContracts.Click += new System.EventHandler(this.btnAddContracts_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(22, 49);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(206, 25);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 12);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnView_All_Service_Contracts
            // 
            this.btnView_All_Service_Contracts.Location = new System.Drawing.Point(800, 313);
            this.btnView_All_Service_Contracts.Name = "btnView_All_Service_Contracts";
            this.btnView_All_Service_Contracts.Size = new System.Drawing.Size(170, 31);
            this.btnView_All_Service_Contracts.TabIndex = 0;
            this.btnView_All_Service_Contracts.Text = "View All Service Contracts";
            this.btnView_All_Service_Contracts.UseVisualStyleBackColor = true;
            // 
            // tabPackage
            // 
            this.tabPackage.Location = new System.Drawing.Point(4, 22);
            this.tabPackage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Windows.Forms.Padding(2);
            this.tabPackage.Size = new System.Drawing.Size(3144, 1707);
            this.tabPackage.TabIndex = 1;
            this.tabPackage.Text = "Package";
            this.tabPackage.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.button1);
            this.tabService.Controls.Add(this.listView1);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Margin = new System.Windows.Forms.Padding(2);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(2);
            this.tabService.Size = new System.Drawing.Size(3144, 1707);
            this.tabService.TabIndex = 2;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(988, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 409);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1436, 308);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabSLA
            // 
            this.tabSLA.Controls.Add(this.btnViewSLA);
            this.tabSLA.Controls.Add(this.listViewServiceLevelAgreemnet);
            this.tabSLA.Location = new System.Drawing.Point(4, 22);
            this.tabSLA.Margin = new System.Windows.Forms.Padding(2);
            this.tabSLA.Name = "tabSLA";
            this.tabSLA.Padding = new System.Windows.Forms.Padding(2);
            this.tabSLA.Size = new System.Drawing.Size(3144, 1707);
            this.tabSLA.TabIndex = 3;
            this.tabSLA.Text = "Service Level Agreement";
            this.tabSLA.UseVisualStyleBackColor = true;
            // 
            // btnViewSLA
            // 
            this.btnViewSLA.Location = new System.Drawing.Point(1088, 328);
            this.btnViewSLA.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSLA.Name = "btnViewSLA";
            this.btnViewSLA.Size = new System.Drawing.Size(202, 31);
            this.btnViewSLA.TabIndex = 1;
            this.btnViewSLA.Text = "View Service Level Agreemnet";
            this.btnViewSLA.UseVisualStyleBackColor = true;
            // 
            // listViewServiceLevelAgreemnet
            // 
            this.listViewServiceLevelAgreemnet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Description});
            this.listViewServiceLevelAgreemnet.HideSelection = false;
            this.listViewServiceLevelAgreemnet.Location = new System.Drawing.Point(14, 418);
            this.listViewServiceLevelAgreemnet.Margin = new System.Windows.Forms.Padding(2);
            this.listViewServiceLevelAgreemnet.Name = "listViewServiceLevelAgreemnet";
            this.listViewServiceLevelAgreemnet.Size = new System.Drawing.Size(1278, 288);
            this.listViewServiceLevelAgreemnet.TabIndex = 0;
            this.listViewServiceLevelAgreemnet.UseCompatibleStateImageBehavior = false;
            this.listViewServiceLevelAgreemnet.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "SLA ID";
            this.ID.Width = 168;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // frmNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 821);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewContract";
            this.Text = "NewContract";
            this.Load += new System.EventHandler(this.frmNewContract_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabContracts.ResumeLayout(false);
            this.tabContracts.PerformLayout();
            this.grbxServiceContracts.ResumeLayout(false);
            this.grbxServiceContracts.PerformLayout();
            this.gbPackage.ResumeLayout(false);
            this.gbPackage.PerformLayout();
            this.gbrxServiceLevelAgreement.ResumeLayout(false);
            this.gbrxServiceLevelAgreement.PerformLayout();
            this.gbxService.ResumeLayout(false);
            this.gbxService.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.tabSLA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContracts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnView_All_Service_Contracts;
        private System.Windows.Forms.TabPage tabPackage;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabSLA;
        private System.Windows.Forms.Button btnViewSLA;
        private System.Windows.Forms.ListView listViewServiceLevelAgreemnet;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxService;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.Label lblServiceDiscription;
        private System.Windows.Forms.TextBox txtServiceDuration;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.ListView lstViewItems;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnAddSLA;
        private System.Windows.Forms.Button btnAddContracts;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnServiceDone;
        private System.Windows.Forms.GroupBox gbrxServiceLevelAgreement;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSLADescription;
        private System.Windows.Forms.Button btnAddServiceLevelAgreement;
        private System.Windows.Forms.GroupBox gbPackage;
        private System.Windows.Forms.ComboBox cmbxSla;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPDis;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Button btnAddPcak;
        private System.Windows.Forms.GroupBox grbxServiceContracts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDateTerminated;
        private System.Windows.Forms.Button btnSCDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSCDescription;
        private System.Windows.Forms.TextBox txtSCDescription;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.DateTimePicker dtpDateTer;
        private System.Windows.Forms.DateTimePicker dtpDateFianal;
        private System.Windows.Forms.ComboBox cmbIdentNumber;
        private System.Windows.Forms.ComboBox cmbAddPackage;
        private System.Windows.Forms.Label lblImportanceLevel;
        private System.Windows.Forms.Label lblPackage;
    }
}