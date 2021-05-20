
namespace Presentation.Forms.ClientMaintenance
{
    partial class frmClientMaintenance
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
            this.colClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientNameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientSurnameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewI = new System.Windows.Forms.Button();
            this.tpgIndividual = new System.Windows.Forms.TabControl();
            this.tpgIndividualClients = new System.Windows.Forms.TabPage();
            this.btnViewIn = new System.Windows.Forms.Button();
            this.tpgBusinessClients = new System.Windows.Forms.TabPage();
            this.btnViewBu = new System.Windows.Forms.Button();
            this.btnViewB = new System.Windows.Forms.Button();
            this.lstClientsB = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNumB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpgServiceContractRequests = new System.Windows.Forms.TabPage();
            this.btnCallClient = new System.Windows.Forms.Button();
            this.lvServiceContractRequests = new System.Windows.Forms.ListView();
            this.chClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClientType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceContract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResolveNewClientRequest = new System.Windows.Forms.Button();
            this.lvNewClientRequests = new System.Windows.Forms.ListView();
            this.colContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpgIndividual.SuspendLayout();
            this.tpgIndividualClients.SuspendLayout();
            this.tpgBusinessClients.SuspendLayout();
            this.tpgServiceContractRequests.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientsI
            // 
            this.lstClientsI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClientID,
            this.colClientNameI,
            this.colClientSurnameI,
            this.colContactNumI});
            this.lstClientsI.FullRowSelect = true;
            this.lstClientsI.HideSelection = false;
            this.lstClientsI.Location = new System.Drawing.Point(5, 29);
            this.lstClientsI.Margin = new System.Windows.Forms.Padding(2);
            this.lstClientsI.MultiSelect = false;
            this.lstClientsI.Name = "lstClientsI";
            this.lstClientsI.Size = new System.Drawing.Size(767, 389);
            this.lstClientsI.TabIndex = 0;
            this.lstClientsI.UseCompatibleStateImageBehavior = false;
            this.lstClientsI.View = System.Windows.Forms.View.Details;
            // 
            // colClientID
            // 
            this.colClientID.Text = "Identifier";
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
            // btnViewI
            // 
            this.btnViewI.Location = new System.Drawing.Point(917, 8);
            this.btnViewI.Name = "btnViewI";
            this.btnViewI.Size = new System.Drawing.Size(115, 24);
            this.btnViewI.TabIndex = 3;
            this.btnViewI.Text = "View Individual";
            this.btnViewI.UseVisualStyleBackColor = true;
            this.btnViewI.Click += new System.EventHandler(this.btnViewI_Click);
            // 
            // tpgIndividual
            // 
            this.tpgIndividual.Controls.Add(this.tpgIndividualClients);
            this.tpgIndividual.Controls.Add(this.tpgBusinessClients);
            this.tpgIndividual.Controls.Add(this.tpgServiceContractRequests);
            this.tpgIndividual.Controls.Add(this.tabPage1);
            this.tpgIndividual.Location = new System.Drawing.Point(2, 2);
            this.tpgIndividual.Margin = new System.Windows.Forms.Padding(2);
            this.tpgIndividual.Name = "tpgIndividual";
            this.tpgIndividual.SelectedIndex = 0;
            this.tpgIndividual.Size = new System.Drawing.Size(784, 448);
            this.tpgIndividual.TabIndex = 4;
            // 
            // tpgIndividualClients
            // 
            this.tpgIndividualClients.Controls.Add(this.btnViewIn);
            this.tpgIndividualClients.Controls.Add(this.btnViewI);
            this.tpgIndividualClients.Controls.Add(this.lstClientsI);
            this.tpgIndividualClients.Location = new System.Drawing.Point(4, 22);
            this.tpgIndividualClients.Margin = new System.Windows.Forms.Padding(2);
            this.tpgIndividualClients.Name = "tpgIndividualClients";
            this.tpgIndividualClients.Padding = new System.Windows.Forms.Padding(2);
            this.tpgIndividualClients.Size = new System.Drawing.Size(776, 422);
            this.tpgIndividualClients.TabIndex = 0;
            this.tpgIndividualClients.Text = "Individual Clients";
            this.tpgIndividualClients.UseVisualStyleBackColor = true;
            // 
            // btnViewIn
            // 
            this.btnViewIn.Location = new System.Drawing.Point(712, 2);
            this.btnViewIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewIn.Name = "btnViewIn";
            this.btnViewIn.Size = new System.Drawing.Size(60, 23);
            this.btnViewIn.TabIndex = 5;
            this.btnViewIn.Text = "View";
            this.btnViewIn.UseVisualStyleBackColor = true;
            this.btnViewIn.Click += new System.EventHandler(this.btnViewI_Click);
            // 
            // tpgBusinessClients
            // 
            this.tpgBusinessClients.Controls.Add(this.btnViewBu);
            this.tpgBusinessClients.Controls.Add(this.btnViewB);
            this.tpgBusinessClients.Controls.Add(this.lstClientsB);
            this.tpgBusinessClients.Location = new System.Drawing.Point(4, 22);
            this.tpgBusinessClients.Margin = new System.Windows.Forms.Padding(2);
            this.tpgBusinessClients.Name = "tpgBusinessClients";
            this.tpgBusinessClients.Padding = new System.Windows.Forms.Padding(2);
            this.tpgBusinessClients.Size = new System.Drawing.Size(776, 422);
            this.tpgBusinessClients.TabIndex = 1;
            this.tpgBusinessClients.Text = "Business Clients";
            this.tpgBusinessClients.UseVisualStyleBackColor = true;
            // 
            // btnViewBu
            // 
            this.btnViewBu.Location = new System.Drawing.Point(712, 2);
            this.btnViewBu.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewBu.Name = "btnViewBu";
            this.btnViewBu.Size = new System.Drawing.Size(60, 23);
            this.btnViewBu.TabIndex = 12;
            this.btnViewBu.Text = "View";
            this.btnViewBu.UseVisualStyleBackColor = true;
            this.btnViewBu.Click += new System.EventHandler(this.btnViewB_Click);
            // 
            // btnViewB
            // 
            this.btnViewB.Location = new System.Drawing.Point(920, 5);
            this.btnViewB.Name = "btnViewB";
            this.btnViewB.Size = new System.Drawing.Size(115, 24);
            this.btnViewB.TabIndex = 8;
            this.btnViewB.Text = "View Business";
            this.btnViewB.UseVisualStyleBackColor = true;
            this.btnViewB.Click += new System.EventHandler(this.btnViewB_Click);
            // 
            // lstClientsB
            // 
            this.lstClientsB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNameB,
            this.colContactNumB});
            this.lstClientsB.FullRowSelect = true;
            this.lstClientsB.HideSelection = false;
            this.lstClientsB.Location = new System.Drawing.Point(5, 29);
            this.lstClientsB.Margin = new System.Windows.Forms.Padding(2);
            this.lstClientsB.MultiSelect = false;
            this.lstClientsB.Name = "lstClientsB";
            this.lstClientsB.Size = new System.Drawing.Size(767, 389);
            this.lstClientsB.TabIndex = 5;
            this.lstClientsB.UseCompatibleStateImageBehavior = false;
            this.lstClientsB.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "Identifier";
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
            // tpgServiceContractRequests
            // 
            this.tpgServiceContractRequests.Controls.Add(this.btnCallClient);
            this.tpgServiceContractRequests.Controls.Add(this.lvServiceContractRequests);
            this.tpgServiceContractRequests.Location = new System.Drawing.Point(4, 22);
            this.tpgServiceContractRequests.Name = "tpgServiceContractRequests";
            this.tpgServiceContractRequests.Size = new System.Drawing.Size(776, 422);
            this.tpgServiceContractRequests.TabIndex = 2;
            this.tpgServiceContractRequests.Text = "Service Contract Requests";
            this.tpgServiceContractRequests.UseVisualStyleBackColor = true;
            // 
            // btnCallClient
            // 
            this.btnCallClient.BackgroundImage = global::sen381_t7_premier_service_solutions.Properties.Resources.phone_outgoing;
            this.btnCallClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCallClient.Location = new System.Drawing.Point(703, 349);
            this.btnCallClient.Name = "btnCallClient";
            this.btnCallClient.Size = new System.Drawing.Size(70, 70);
            this.btnCallClient.TabIndex = 3;
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
            this.lvServiceContractRequests.Location = new System.Drawing.Point(6, 8);
            this.lvServiceContractRequests.MultiSelect = false;
            this.lvServiceContractRequests.Name = "lvServiceContractRequests";
            this.lvServiceContractRequests.Size = new System.Drawing.Size(776, 337);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResolveNewClientRequest);
            this.tabPage1.Controls.Add(this.lvNewClientRequests);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(776, 422);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "New Client Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResolveNewClientRequest
            // 
            this.btnResolveNewClientRequest.BackgroundImage = global::sen381_t7_premier_service_solutions.Properties.Resources.phone_outgoing;
            this.btnResolveNewClientRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResolveNewClientRequest.Location = new System.Drawing.Point(705, 351);
            this.btnResolveNewClientRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnResolveNewClientRequest.Name = "btnResolveNewClientRequest";
            this.btnResolveNewClientRequest.Size = new System.Drawing.Size(67, 67);
            this.btnResolveNewClientRequest.TabIndex = 1;
            this.btnResolveNewClientRequest.UseVisualStyleBackColor = true;
            this.btnResolveNewClientRequest.Click += new System.EventHandler(this.btnResolveNewClientRequest_Click);
            // 
            // lvNewClientRequests
            // 
            this.lvNewClientRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colContactNum,
            this.colClientType});
            this.lvNewClientRequests.FullRowSelect = true;
            this.lvNewClientRequests.HideSelection = false;
            this.lvNewClientRequests.Location = new System.Drawing.Point(5, 6);
            this.lvNewClientRequests.Margin = new System.Windows.Forms.Padding(2);
            this.lvNewClientRequests.MultiSelect = false;
            this.lvNewClientRequests.Name = "lvNewClientRequests";
            this.lvNewClientRequests.Size = new System.Drawing.Size(767, 341);
            this.lvNewClientRequests.TabIndex = 0;
            this.lvNewClientRequests.UseCompatibleStateImageBehavior = false;
            this.lvNewClientRequests.View = System.Windows.Forms.View.Details;
            // 
            // colContactNum
            // 
            this.colContactNum.Text = "Contact Number";
            // 
            // colClientType
            // 
            this.colClientType.Text = "Client Type";
            // 
            // frmClientMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 459);
            this.Controls.Add(this.tpgIndividual);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientMaintenance";
            this.Text = "ClientMenu";
            this.Load += new System.EventHandler(this.frmClientMenu_Load);
            this.tpgIndividual.ResumeLayout(false);
            this.tpgIndividualClients.ResumeLayout(false);
            this.tpgBusinessClients.ResumeLayout(false);
            this.tpgServiceContractRequests.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClientsI;
        private System.Windows.Forms.ColumnHeader colClientNameI;
        private System.Windows.Forms.ColumnHeader colClientSurnameI;
        private System.Windows.Forms.Button btnViewI;
        private System.Windows.Forms.TabControl tpgIndividual;
        private System.Windows.Forms.TabPage tpgIndividualClients;
        private System.Windows.Forms.TabPage tpgBusinessClients;
        private System.Windows.Forms.Button btnViewB;
        private System.Windows.Forms.ListView lstClientsB;
        private System.Windows.Forms.ColumnHeader colNameB;
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
        private System.Windows.Forms.ColumnHeader colClientID;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Button btnViewIn;
        private System.Windows.Forms.Button btnViewBu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnResolveNewClientRequest;
        private System.Windows.Forms.ListView lvNewClientRequests;
        private System.Windows.Forms.ColumnHeader colContactNum;
        private System.Windows.Forms.ColumnHeader colClientType;
    }
}