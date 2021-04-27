﻿
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
            this.cmbAddPackage = new System.Windows.Forms.ComboBox();
            this.cmbIdentNumber = new System.Windows.Forms.ComboBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblImportanceLevel = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(-1501, -847);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(6304, 3333);
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
            this.tabContracts.Location = new System.Drawing.Point(8, 39);
            this.tabContracts.Margin = new System.Windows.Forms.Padding(4);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Padding = new System.Windows.Forms.Padding(4);
            this.tabContracts.Size = new System.Drawing.Size(6288, 3286);
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
            this.grbxServiceContracts.Location = new System.Drawing.Point(3547, 843);
            this.grbxServiceContracts.Name = "grbxServiceContracts";
            this.grbxServiceContracts.Size = new System.Drawing.Size(721, 679);
            this.grbxServiceContracts.TabIndex = 10;
            this.grbxServiceContracts.TabStop = false;
            this.grbxServiceContracts.Text = "New Service Cotract";
            // 
            // dtpDateTer
            // 
            this.dtpDateTer.Location = new System.Drawing.Point(319, 167);
            this.dtpDateTer.Name = "dtpDateTer";
            this.dtpDateTer.Size = new System.Drawing.Size(336, 31);
            this.dtpDateTer.TabIndex = 12;
            // 
            // dtpDateFianal
            // 
            this.dtpDateFianal.Location = new System.Drawing.Point(319, 119);
            this.dtpDateFianal.Name = "dtpDateFianal";
            this.dtpDateFianal.Size = new System.Drawing.Size(336, 31);
            this.dtpDateFianal.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 294);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(322, 291);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(333, 31);
            this.txtStatus.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(322, 230);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(333, 31);
            this.txtCost.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(31, 230);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(56, 25);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // lblDateTerminated
            // 
            this.lblDateTerminated.AutoSize = true;
            this.lblDateTerminated.Location = new System.Drawing.Point(31, 172);
            this.lblDateTerminated.Name = "lblDateTerminated";
            this.lblDateTerminated.Size = new System.Drawing.Size(165, 25);
            this.lblDateTerminated.TabIndex = 6;
            this.lblDateTerminated.Text = "DateTerminated";
            // 
            // btnSCDone
            // 
            this.btnSCDone.AutoEllipsis = true;
            this.btnSCDone.Location = new System.Drawing.Point(376, 574);
            this.btnSCDone.Name = "btnSCDone";
            this.btnSCDone.Size = new System.Drawing.Size(279, 45);
            this.btnSCDone.TabIndex = 5;
            this.btnSCDone.Text = "Done";
            this.btnSCDone.UseVisualStyleBackColor = true;
            this.btnSCDone.Click += new System.EventHandler(this.btnSCDone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Finalised";
            // 
            // lblSCDescription
            // 
            this.lblSCDescription.AutoSize = true;
            this.lblSCDescription.Location = new System.Drawing.Point(31, 58);
            this.lblSCDescription.Name = "lblSCDescription";
            this.lblSCDescription.Size = new System.Drawing.Size(285, 25);
            this.lblSCDescription.TabIndex = 3;
            this.lblSCDescription.Text = "Service Contract Description";
            // 
            // txtSCDescription
            // 
            this.txtSCDescription.Location = new System.Drawing.Point(322, 52);
            this.txtSCDescription.Name = "txtSCDescription";
            this.txtSCDescription.Size = new System.Drawing.Size(333, 31);
            this.txtSCDescription.TabIndex = 1;
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(36, 574);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(279, 45);
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
            this.gbPackage.Location = new System.Drawing.Point(2801, 831);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Size = new System.Drawing.Size(721, 408);
            this.gbPackage.TabIndex = 6;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "New Package";
            // 
            // cmbxSla
            // 
            this.cmbxSla.FormattingEnabled = true;
            this.cmbxSla.Location = new System.Drawing.Point(323, 230);
            this.cmbxSla.Name = "cmbxSla";
            this.cmbxSla.Size = new System.Drawing.Size(332, 33);
            this.cmbxSla.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "SLA ID";
            // 
            // cmbxService
            // 
            this.cmbxService.FormattingEnabled = true;
            this.cmbxService.Location = new System.Drawing.Point(322, 172);
            this.cmbxService.Name = "cmbxService";
            this.cmbxService.Size = new System.Drawing.Size(332, 33);
            this.cmbxService.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Service ID";
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.Location = new System.Drawing.Point(375, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(279, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "Done";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Package Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Package Name";
            // 
            // txtPDis
            // 
            this.txtPDis.Location = new System.Drawing.Point(322, 113);
            this.txtPDis.Name = "txtPDis";
            this.txtPDis.Size = new System.Drawing.Size(333, 31);
            this.txtPDis.TabIndex = 2;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(322, 52);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(333, 31);
            this.txtPname.TabIndex = 1;
            // 
            // btnAddPcak
            // 
            this.btnAddPcak.Location = new System.Drawing.Point(36, 303);
            this.btnAddPcak.Name = "btnAddPcak";
            this.btnAddPcak.Size = new System.Drawing.Size(279, 45);
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
            this.gbrxServiceLevelAgreement.Location = new System.Drawing.Point(2074, 1230);
            this.gbrxServiceLevelAgreement.Name = "gbrxServiceLevelAgreement";
            this.gbrxServiceLevelAgreement.Size = new System.Drawing.Size(816, 261);
            this.gbrxServiceLevelAgreement.TabIndex = 6;
            this.gbrxServiceLevelAgreement.TabStop = false;
            this.gbrxServiceLevelAgreement.Text = "New Service Level Agreement ";
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.Location = new System.Drawing.Point(511, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Done";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "ServiceLevel Agreement Description";
            // 
            // txtSLADescription
            // 
            this.txtSLADescription.Location = new System.Drawing.Point(408, 81);
            this.txtSLADescription.Name = "txtSLADescription";
            this.txtSLADescription.Size = new System.Drawing.Size(333, 31);
            this.txtSLADescription.TabIndex = 1;
            // 
            // btnAddServiceLevelAgreement
            // 
            this.btnAddServiceLevelAgreement.Location = new System.Drawing.Point(33, 168);
            this.btnAddServiceLevelAgreement.Name = "btnAddServiceLevelAgreement";
            this.btnAddServiceLevelAgreement.Size = new System.Drawing.Size(355, 45);
            this.btnAddServiceLevelAgreement.TabIndex = 0;
            this.btnAddServiceLevelAgreement.Text = "Add Service Level Agreement";
            this.btnAddServiceLevelAgreement.UseVisualStyleBackColor = true;
            this.btnAddServiceLevelAgreement.Click += new System.EventHandler(this.btnAddServiceLevelAgreement_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
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
            this.gbxService.Location = new System.Drawing.Point(2074, 820);
            this.gbxService.Name = "gbxService";
            this.gbxService.Size = new System.Drawing.Size(721, 385);
            this.gbxService.TabIndex = 5;
            this.gbxService.TabStop = false;
            this.gbxService.Text = "New Service";
            // 
            // btnServiceDone
            // 
            this.btnServiceDone.AutoEllipsis = true;
            this.btnServiceDone.Location = new System.Drawing.Point(376, 301);
            this.btnServiceDone.Name = "btnServiceDone";
            this.btnServiceDone.Size = new System.Drawing.Size(279, 45);
            this.btnServiceDone.TabIndex = 5;
            this.btnServiceDone.Text = "Done";
            this.btnServiceDone.UseVisualStyleBackColor = true;
            this.btnServiceDone.Click += new System.EventHandler(this.btnServiceDone_Click);
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Location = new System.Drawing.Point(76, 211);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(171, 25);
            this.lblServiceDuration.TabIndex = 4;
            this.lblServiceDuration.Text = "Service Duration";
            // 
            // lblServiceDiscription
            // 
            this.lblServiceDiscription.AutoSize = true;
            this.lblServiceDiscription.Location = new System.Drawing.Point(76, 135);
            this.lblServiceDiscription.Name = "lblServiceDiscription";
            this.lblServiceDiscription.Size = new System.Drawing.Size(198, 25);
            this.lblServiceDiscription.TabIndex = 3;
            this.lblServiceDiscription.Text = "Service Description";
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.Location = new System.Drawing.Point(322, 211);
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.Size = new System.Drawing.Size(333, 31);
            this.txtServiceDuration.TabIndex = 2;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(322, 129);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(333, 31);
            this.txtServiceDescription.TabIndex = 1;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(33, 301);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(279, 45);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "Add Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // lstViewItems
            // 
            this.lstViewItems.HideSelection = false;
            this.lstViewItems.Location = new System.Drawing.Point(1970, 1607);
            this.lstViewItems.Name = "lstViewItems";
            this.lstViewItems.Size = new System.Drawing.Size(1445, 757);
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
            this.groupBox1.Location = new System.Drawing.Point(1505, 820);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 491);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Elements";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(43, 370);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(412, 49);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Add Service ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddSLA
            // 
            this.btnAddSLA.Location = new System.Drawing.Point(43, 275);
            this.btnAddSLA.Name = "btnAddSLA";
            this.btnAddSLA.Size = new System.Drawing.Size(412, 49);
            this.btnAddSLA.TabIndex = 2;
            this.btnAddSLA.Text = "Add Service Level Agreement";
            this.btnAddSLA.UseVisualStyleBackColor = true;
            this.btnAddSLA.Click += new System.EventHandler(this.btnAddSLA_Click);
            // 
            // btnAddContracts
            // 
            this.btnAddContracts.Location = new System.Drawing.Point(43, 185);
            this.btnAddContracts.Name = "btnAddContracts";
            this.btnAddContracts.Size = new System.Drawing.Size(412, 49);
            this.btnAddContracts.TabIndex = 1;
            this.btnAddContracts.Text = "Add Service Contract";
            this.btnAddContracts.UseVisualStyleBackColor = true;
            this.btnAddContracts.Click += new System.EventHandler(this.btnAddContracts_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(43, 95);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(412, 49);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnView_All_Service_Contracts
            // 
            this.btnView_All_Service_Contracts.Location = new System.Drawing.Point(1599, 602);
            this.btnView_All_Service_Contracts.Margin = new System.Windows.Forms.Padding(6);
            this.btnView_All_Service_Contracts.Name = "btnView_All_Service_Contracts";
            this.btnView_All_Service_Contracts.Size = new System.Drawing.Size(340, 59);
            this.btnView_All_Service_Contracts.TabIndex = 0;
            this.btnView_All_Service_Contracts.Text = "View All Service Contracts";
            this.btnView_All_Service_Contracts.UseVisualStyleBackColor = true;
            // 
            // tabPackage
            // 
            this.tabPackage.Location = new System.Drawing.Point(8, 39);
            this.tabPackage.Margin = new System.Windows.Forms.Padding(4);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Windows.Forms.Padding(4);
            this.tabPackage.Size = new System.Drawing.Size(6288, 3286);
            this.tabPackage.TabIndex = 1;
            this.tabPackage.Text = "Package";
            this.tabPackage.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.button1);
            this.tabService.Controls.Add(this.listView1);
            this.tabService.Location = new System.Drawing.Point(8, 39);
            this.tabService.Margin = new System.Windows.Forms.Padding(4);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(4);
            this.tabService.Size = new System.Drawing.Size(6288, 3286);
            this.tabService.TabIndex = 2;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1975, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 77);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 787);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(2868, 588);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabSLA
            // 
            this.tabSLA.Controls.Add(this.btnViewSLA);
            this.tabSLA.Controls.Add(this.listViewServiceLevelAgreemnet);
            this.tabSLA.Location = new System.Drawing.Point(8, 39);
            this.tabSLA.Margin = new System.Windows.Forms.Padding(4);
            this.tabSLA.Name = "tabSLA";
            this.tabSLA.Padding = new System.Windows.Forms.Padding(4);
            this.tabSLA.Size = new System.Drawing.Size(6288, 3286);
            this.tabSLA.TabIndex = 3;
            this.tabSLA.Text = "Service Level Agreement";
            this.tabSLA.UseVisualStyleBackColor = true;
            // 
            // btnViewSLA
            // 
            this.btnViewSLA.Location = new System.Drawing.Point(2176, 630);
            this.btnViewSLA.Name = "btnViewSLA";
            this.btnViewSLA.Size = new System.Drawing.Size(403, 60);
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
            this.listViewServiceLevelAgreemnet.Location = new System.Drawing.Point(28, 803);
            this.listViewServiceLevelAgreemnet.Name = "listViewServiceLevelAgreemnet";
            this.listViewServiceLevelAgreemnet.Size = new System.Drawing.Size(2551, 551);
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
            // cmbAddPackage
            // 
            this.cmbAddPackage.FormattingEnabled = true;
            this.cmbAddPackage.Location = new System.Drawing.Point(323, 363);
            this.cmbAddPackage.Name = "cmbAddPackage";
            this.cmbAddPackage.Size = new System.Drawing.Size(332, 33);
            this.cmbAddPackage.TabIndex = 10;
            // 
            // cmbIdentNumber
            // 
            this.cmbIdentNumber.FormattingEnabled = true;
            this.cmbIdentNumber.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbIdentNumber.Location = new System.Drawing.Point(323, 435);
            this.cmbIdentNumber.Name = "cmbIdentNumber";
            this.cmbIdentNumber.Size = new System.Drawing.Size(332, 33);
            this.cmbIdentNumber.TabIndex = 13;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(31, 371);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(96, 25);
            this.lblPackage.TabIndex = 14;
            this.lblPackage.Text = "Package";
            // 
            // lblImportanceLevel
            // 
            this.lblImportanceLevel.AutoSize = true;
            this.lblImportanceLevel.Location = new System.Drawing.Point(31, 443);
            this.lblImportanceLevel.Name = "lblImportanceLevel";
            this.lblImportanceLevel.Size = new System.Drawing.Size(200, 25);
            this.lblImportanceLevel.TabIndex = 15;
            this.lblImportanceLevel.Text = "Level of Importance";
            // 
            // frmNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3120, 1680);
            this.Controls.Add(this.tabControl1);
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