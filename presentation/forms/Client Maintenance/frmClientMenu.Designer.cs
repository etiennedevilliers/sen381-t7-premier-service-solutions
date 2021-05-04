
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmClientMenu
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
            this.lstClientsI = new System.Windows.Forms.ListView();
            this.colClientNameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientSurnameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditI = new System.Windows.Forms.Button();
            this.btnDeleteI = new System.Windows.Forms.Button();
            this.btnViewContractI = new System.Windows.Forms.Button();
            this.tpgIndividual = new System.Windows.Forms.TabControl();
            this.tpgIndividualClients = new System.Windows.Forms.TabPage();
            this.btnAddI = new System.Windows.Forms.Button();
            this.tpgBusinessClients = new System.Windows.Forms.TabPage();
            this.cbEmployeesB = new System.Windows.Forms.ComboBox();
            this.btnAssignEmployeeB = new System.Windows.Forms.Button();
            this.btnAddB = new System.Windows.Forms.Button();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.btnViewContractB = new System.Windows.Forms.Button();
            this.lstClientsB = new System.Windows.Forms.ListView();
            this.colNameB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditB = new System.Windows.Forms.Button();
            this.tpgServiceContractRequests = new System.Windows.Forms.TabPage();
            this.btnCallClient = new System.Windows.Forms.Button();
            this.lvServiceContractRequests = new System.Windows.Forms.ListView();
            this.chClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClientType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpgIndividual.SuspendLayout();
            this.tpgIndividualClients.SuspendLayout();
            this.tpgBusinessClients.SuspendLayout();
            this.tpgServiceContractRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientsI
            // 
            this.lstClientsI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientNameI,
            this.colClientSurnameI,
            this.colContactNumI});
            this.lstClientsI.FullRowSelect = true;
            this.lstClientsI.HideSelection = false;
            this.lstClientsI.Location = new System.Drawing.Point(0, 54);
            this.lstClientsI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstClientsI.Name = "lstClientsI";
            this.lstClientsI.Size = new System.Drawing.Size(1546, 756);
            this.lstClientsI.TabIndex = 0;
            this.lstClientsI.UseCompatibleStateImageBehavior = false;
            this.lstClientsI.View = System.Windows.Forms.View.Details;
            // 
            // colClientNameI
            // 
            this.colClientNameI.Text = "Name";
            this.colClientNameI.Width = 125;
            // 
            // colClientSurnameI
            // 
            this.colClientSurnameI.Text = "Surname";
            this.colClientSurnameI.Width = 188;
            // 
            // colContactNumI
            // 
            this.colContactNumI.Text = "Contact Number";
            this.colContactNumI.Width = 136;
            // 
            // btnEditI
            // 
            this.btnEditI.Location = new System.Drawing.Point(1246, 12);
            this.btnEditI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditI.Name = "btnEditI";
            this.btnEditI.Size = new System.Drawing.Size(120, 37);
            this.btnEditI.TabIndex = 1;
            this.btnEditI.Text = "Edit";
            this.btnEditI.UseVisualStyleBackColor = true;
            this.btnEditI.Click += new System.EventHandler(this.btnEditI_Click);
            // 
            // btnDeleteI
            // 
            this.btnDeleteI.Location = new System.Drawing.Point(778, 12);
            this.btnDeleteI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteI.Name = "btnDeleteI";
            this.btnDeleteI.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteI.TabIndex = 2;
            this.btnDeleteI.Text = "Delete";
            this.btnDeleteI.UseVisualStyleBackColor = true;
            this.btnDeleteI.Click += new System.EventHandler(this.btnDeleteI_Click);
            // 
            // btnViewContractI
            // 
            this.btnViewContractI.Location = new System.Drawing.Point(1376, 12);
            this.btnViewContractI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewContractI.Name = "btnViewContractI";
            this.btnViewContractI.Size = new System.Drawing.Size(172, 37);
            this.btnViewContractI.TabIndex = 3;
            this.btnViewContractI.Text = "View Contract";
            this.btnViewContractI.UseVisualStyleBackColor = true;
            this.btnViewContractI.Click += new System.EventHandler(this.btnViewContractI_Click);
            // 
            // tpgIndividual
            // 
            this.tpgIndividual.Controls.Add(this.tpgIndividualClients);
            this.tpgIndividual.Controls.Add(this.tpgBusinessClients);
            this.tpgIndividual.Controls.Add(this.tpgServiceContractRequests);
            this.tpgIndividual.Location = new System.Drawing.Point(4, 4);
            this.tpgIndividual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgIndividual.Name = "tpgIndividual";
            this.tpgIndividual.SelectedIndex = 0;
            this.tpgIndividual.Size = new System.Drawing.Size(1568, 862);
            this.tpgIndividual.TabIndex = 4;
            // 
            // tpgIndividualClients
            // 
            this.tpgIndividualClients.Controls.Add(this.btnAddI);
            this.tpgIndividualClients.Controls.Add(this.btnDeleteI);
            this.tpgIndividualClients.Controls.Add(this.btnViewContractI);
            this.tpgIndividualClients.Controls.Add(this.lstClientsI);
            this.tpgIndividualClients.Controls.Add(this.btnEditI);
            this.tpgIndividualClients.Location = new System.Drawing.Point(8, 39);
            this.tpgIndividualClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgIndividualClients.Name = "tpgIndividualClients";
            this.tpgIndividualClients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgIndividualClients.Size = new System.Drawing.Size(1552, 815);
            this.tpgIndividualClients.TabIndex = 0;
            this.tpgIndividualClients.Text = "Individual Clients";
            this.tpgIndividualClients.UseVisualStyleBackColor = true;
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(1124, 12);
            this.btnAddI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(112, 37);
            this.btnAddI.TabIndex = 4;
            this.btnAddI.Text = "Add";
            this.btnAddI.UseVisualStyleBackColor = true;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click);
            // 
            // tpgBusinessClients
            // 
            this.tpgBusinessClients.Controls.Add(this.cbEmployeesB);
            this.tpgBusinessClients.Controls.Add(this.btnAssignEmployeeB);
            this.tpgBusinessClients.Controls.Add(this.btnAddB);
            this.tpgBusinessClients.Controls.Add(this.btnDeleteB);
            this.tpgBusinessClients.Controls.Add(this.btnViewContractB);
            this.tpgBusinessClients.Controls.Add(this.lstClientsB);
            this.tpgBusinessClients.Controls.Add(this.btnEditB);
            this.tpgBusinessClients.Location = new System.Drawing.Point(8, 39);
            this.tpgBusinessClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgBusinessClients.Name = "tpgBusinessClients";
            this.tpgBusinessClients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgBusinessClients.Size = new System.Drawing.Size(1552, 815);
            this.tpgBusinessClients.TabIndex = 1;
            this.tpgBusinessClients.Text = "Business Clients";
            this.tpgBusinessClients.UseVisualStyleBackColor = true;
            // 
            // cbEmployeesB
            // 
            this.cbEmployeesB.FormattingEnabled = true;
            this.cbEmployeesB.Location = new System.Drawing.Point(8, 6);
            this.cbEmployeesB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmployeesB.Name = "cbEmployeesB";
            this.cbEmployeesB.Size = new System.Drawing.Size(185, 24);
            this.cbEmployeesB.TabIndex = 11;
            // 
            // btnAssignEmployeeB
            // 
            this.btnAssignEmployeeB.Location = new System.Drawing.Point(244, 8);
            this.btnAssignEmployeeB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignEmployeeB.Name = "btnAssignEmployeeB";
            this.btnAssignEmployeeB.Size = new System.Drawing.Size(192, 37);
            this.btnAssignEmployeeB.TabIndex = 10;
            this.btnAssignEmployeeB.Text = "Assign Employee";
            this.btnAssignEmployeeB.UseVisualStyleBackColor = true;
            this.btnAssignEmployeeB.Click += new System.EventHandler(this.btnAssignEmployeeB_Click);
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(1130, 8);
            this.btnAddB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(112, 37);
            this.btnAddB.TabIndex = 9;
            this.btnAddB.Text = "Add";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.btnAddB_Click);
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.Location = new System.Drawing.Point(784, 8);
            this.btnDeleteB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteB.TabIndex = 7;
            this.btnDeleteB.Text = "Delete";
            this.btnDeleteB.UseVisualStyleBackColor = true;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // btnViewContractB
            // 
            this.btnViewContractB.Location = new System.Drawing.Point(1380, 8);
            this.btnViewContractB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewContractB.Name = "btnViewContractB";
            this.btnViewContractB.Size = new System.Drawing.Size(172, 37);
            this.btnViewContractB.TabIndex = 8;
            this.btnViewContractB.Text = "View Contract";
            this.btnViewContractB.UseVisualStyleBackColor = true;
            this.btnViewContractB.Click += new System.EventHandler(this.btnViewContractB_Click);
            // 
            // lstClientsB
            // 
            this.lstClientsB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNameB,
            this.colContactNumB});
            this.lstClientsB.FullRowSelect = true;
            this.lstClientsB.HideSelection = false;
            this.lstClientsB.Location = new System.Drawing.Point(4, 50);
            this.lstClientsB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstClientsB.Name = "lstClientsB";
            this.lstClientsB.Size = new System.Drawing.Size(1546, 756);
            this.lstClientsB.TabIndex = 5;
            this.lstClientsB.UseCompatibleStateImageBehavior = false;
            this.lstClientsB.View = System.Windows.Forms.View.Details;
            // 
            // colNameB
            // 
            this.colNameB.Text = "Name";
            this.colNameB.Width = 147;
            // 
            // colContactNumB
            // 
            this.colContactNumB.Text = "Contact Number";
            this.colContactNumB.Width = 167;
            // 
            // btnEditB
            // 
            this.btnEditB.Location = new System.Drawing.Point(1252, 8);
            this.btnEditB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditB.Name = "btnEditB";
            this.btnEditB.Size = new System.Drawing.Size(120, 37);
            this.btnEditB.TabIndex = 6;
            this.btnEditB.Text = "Edit";
            this.btnEditB.UseVisualStyleBackColor = true;
            this.btnEditB.Click += new System.EventHandler(this.btnEditB_Click);
            // 
            // tpgServiceContractRequests
            // 
            this.tpgServiceContractRequests.Controls.Add(this.btnCallClient);
            this.tpgServiceContractRequests.Controls.Add(this.lvServiceContractRequests);
            this.tpgServiceContractRequests.Location = new System.Drawing.Point(8, 39);
            this.tpgServiceContractRequests.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpgServiceContractRequests.Name = "tpgServiceContractRequests";
            this.tpgServiceContractRequests.Size = new System.Drawing.Size(1552, 815);
            this.tpgServiceContractRequests.TabIndex = 2;
            this.tpgServiceContractRequests.Text = "Service Contract Requests";
            this.tpgServiceContractRequests.UseVisualStyleBackColor = true;
            // 
            // btnCallClient
            // 
            this.btnCallClient.Location = new System.Drawing.Point(860, 765);
            this.btnCallClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCallClient.Name = "btnCallClient";
            this.btnCallClient.Size = new System.Drawing.Size(686, 44);
            this.btnCallClient.TabIndex = 3;
            this.btnCallClient.Text = "Call Client and finalise new Service Contract";
            this.btnCallClient.UseVisualStyleBackColor = true;
            this.btnCallClient.Click += new System.EventHandler(this.btnCallClient_Click);
            // 
            // lvServiceContractRequests
            // 
            this.lvServiceContractRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chClient,
            this.chClientType,
            this.chServiceContract,
            this.columnHeader1,
            this.columnHeader2});
            this.lvServiceContractRequests.FullRowSelect = true;
            this.lvServiceContractRequests.HideSelection = false;
            this.lvServiceContractRequests.Location = new System.Drawing.Point(12, 16);
            this.lvServiceContractRequests.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvServiceContractRequests.MultiSelect = false;
            this.lvServiceContractRequests.Name = "lvServiceContractRequests";
            this.lvServiceContractRequests.Size = new System.Drawing.Size(1548, 737);
            this.lvServiceContractRequests.TabIndex = 0;
            this.lvServiceContractRequests.UseCompatibleStateImageBehavior = false;
            this.lvServiceContractRequests.View = System.Windows.Forms.View.Details;
            // 
            // chClient
            // 
            this.chClient.Text = "Client Name";
            this.chClient.Width = 120;
            // 
            // chClientType
            // 
            this.chClientType.Text = "Client Type";
            this.chClientType.Width = 120;
            // 
            // chServiceContract
            // 
            this.chServiceContract.Text = "Service Cotract";
            this.chServiceContract.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date Created";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            // 
            // frmClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 883);
            this.Controls.Add(this.tpgIndividual);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientMenu";
            this.Text = "ClientMenu";
            this.Load += new System.EventHandler(this.frmClientMenu_Load);
            this.tpgIndividual.ResumeLayout(false);
            this.tpgIndividualClients.ResumeLayout(false);
            this.tpgBusinessClients.ResumeLayout(false);
            this.tpgServiceContractRequests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClientsI;
        private System.Windows.Forms.ColumnHeader colClientNameI;
        private System.Windows.Forms.ColumnHeader colClientSurnameI;
        private System.Windows.Forms.Button btnEditI;
        private System.Windows.Forms.Button btnDeleteI;
        private System.Windows.Forms.Button btnViewContractI;
        private System.Windows.Forms.TabControl tpgIndividual;
        private System.Windows.Forms.TabPage tpgIndividualClients;
        private System.Windows.Forms.TabPage tpgBusinessClients;
        private System.Windows.Forms.Button btnAddI;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.Button btnDeleteB;
        private System.Windows.Forms.Button btnViewContractB;
        private System.Windows.Forms.ListView lstClientsB;
        private System.Windows.Forms.ColumnHeader colNameB;
        private System.Windows.Forms.Button btnEditB;
        private System.Windows.Forms.ComboBox cbEmployeesB;
        private System.Windows.Forms.Button btnAssignEmployeeB;
        private System.Windows.Forms.ColumnHeader colContactNumI;
        private System.Windows.Forms.ColumnHeader colContactNumB;
        private System.Windows.Forms.TabPage tpgServiceContractRequests;
        private System.Windows.Forms.ListView lvServiceContractRequests;
        private System.Windows.Forms.ColumnHeader chClient;
        private System.Windows.Forms.ColumnHeader chClientType;
        private System.Windows.Forms.ColumnHeader chServiceContract;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnCallClient;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}