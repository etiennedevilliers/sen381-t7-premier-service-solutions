
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
            this.tpgIndividual.SuspendLayout();
            this.tpgIndividualClients.SuspendLayout();
            this.tpgBusinessClients.SuspendLayout();
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
            this.lstClientsI.Location = new System.Drawing.Point(0, 34);
            this.lstClientsI.Name = "lstClientsI";
            this.lstClientsI.Size = new System.Drawing.Size(1032, 485);
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
            this.btnEditI.Location = new System.Drawing.Point(831, 7);
            this.btnEditI.Name = "btnEditI";
            this.btnEditI.Size = new System.Drawing.Size(80, 23);
            this.btnEditI.TabIndex = 1;
            this.btnEditI.Text = "Edit";
            this.btnEditI.UseVisualStyleBackColor = true;
            this.btnEditI.Click += new System.EventHandler(this.btnEditI_Click);
            // 
            // btnDeleteI
            // 
            this.btnDeleteI.Location = new System.Drawing.Point(519, 7);
            this.btnDeleteI.Name = "btnDeleteI";
            this.btnDeleteI.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteI.TabIndex = 2;
            this.btnDeleteI.Text = "Delete";
            this.btnDeleteI.UseVisualStyleBackColor = true;
            this.btnDeleteI.Click += new System.EventHandler(this.btnDeleteI_Click);
            // 
            // btnViewContractI
            // 
            this.btnViewContractI.Location = new System.Drawing.Point(917, 7);
            this.btnViewContractI.Name = "btnViewContractI";
            this.btnViewContractI.Size = new System.Drawing.Size(115, 23);
            this.btnViewContractI.TabIndex = 3;
            this.btnViewContractI.Text = "View Contract";
            this.btnViewContractI.UseVisualStyleBackColor = true;
            this.btnViewContractI.Click += new System.EventHandler(this.btnViewContractI_Click);
            // 
            // tpgIndividual
            // 
            this.tpgIndividual.Controls.Add(this.tpgIndividualClients);
            this.tpgIndividual.Controls.Add(this.tpgBusinessClients);
            this.tpgIndividual.Location = new System.Drawing.Point(3, 2);
            this.tpgIndividual.Name = "tpgIndividual";
            this.tpgIndividual.SelectedIndex = 0;
            this.tpgIndividual.Size = new System.Drawing.Size(1046, 551);
            this.tpgIndividual.TabIndex = 4;
            // 
            // tpgIndividualClients
            // 
            this.tpgIndividualClients.Controls.Add(this.btnAddI);
            this.tpgIndividualClients.Controls.Add(this.btnDeleteI);
            this.tpgIndividualClients.Controls.Add(this.btnViewContractI);
            this.tpgIndividualClients.Controls.Add(this.lstClientsI);
            this.tpgIndividualClients.Controls.Add(this.btnEditI);
            this.tpgIndividualClients.Location = new System.Drawing.Point(4, 25);
            this.tpgIndividualClients.Name = "tpgIndividualClients";
            this.tpgIndividualClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpgIndividualClients.Size = new System.Drawing.Size(1038, 522);
            this.tpgIndividualClients.TabIndex = 0;
            this.tpgIndividualClients.Text = "Individual Clients";
            this.tpgIndividualClients.UseVisualStyleBackColor = true;
            // 
            // btnAddI
            // 
            this.btnAddI.Location = new System.Drawing.Point(750, 7);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(75, 23);
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
            this.tpgBusinessClients.Location = new System.Drawing.Point(4, 25);
            this.tpgBusinessClients.Name = "tpgBusinessClients";
            this.tpgBusinessClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBusinessClients.Size = new System.Drawing.Size(1038, 522);
            this.tpgBusinessClients.TabIndex = 1;
            this.tpgBusinessClients.Text = "Business Clients";
            this.tpgBusinessClients.UseVisualStyleBackColor = true;
            // 
            // cbEmployeesB
            // 
            this.cbEmployeesB.FormattingEnabled = true;
            this.cbEmployeesB.Location = new System.Drawing.Point(6, 4);
            this.cbEmployeesB.Name = "cbEmployeesB";
            this.cbEmployeesB.Size = new System.Drawing.Size(185, 24);
            this.cbEmployeesB.TabIndex = 11;
            // 
            // btnAssignEmployeeB
            // 
            this.btnAssignEmployeeB.Location = new System.Drawing.Point(197, 5);
            this.btnAssignEmployeeB.Name = "btnAssignEmployeeB";
            this.btnAssignEmployeeB.Size = new System.Drawing.Size(128, 23);
            this.btnAssignEmployeeB.TabIndex = 10;
            this.btnAssignEmployeeB.Text = "Assign Employee";
            this.btnAssignEmployeeB.UseVisualStyleBackColor = true;
            this.btnAssignEmployeeB.Click += new System.EventHandler(this.btnAssignEmployeeB_Click);
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(753, 5);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(75, 23);
            this.btnAddB.TabIndex = 9;
            this.btnAddB.Text = "Add";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.btnAddB_Click);
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.Location = new System.Drawing.Point(522, 5);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteB.TabIndex = 7;
            this.btnDeleteB.Text = "Delete";
            this.btnDeleteB.UseVisualStyleBackColor = true;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // btnViewContractB
            // 
            this.btnViewContractB.Location = new System.Drawing.Point(920, 5);
            this.btnViewContractB.Name = "btnViewContractB";
            this.btnViewContractB.Size = new System.Drawing.Size(115, 23);
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
            this.lstClientsB.Location = new System.Drawing.Point(3, 32);
            this.lstClientsB.Name = "lstClientsB";
            this.lstClientsB.Size = new System.Drawing.Size(1032, 485);
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
            this.btnEditB.Location = new System.Drawing.Point(834, 5);
            this.btnEditB.Name = "btnEditB";
            this.btnEditB.Size = new System.Drawing.Size(80, 23);
            this.btnEditB.TabIndex = 6;
            this.btnEditB.Text = "Edit";
            this.btnEditB.UseVisualStyleBackColor = true;
            this.btnEditB.Click += new System.EventHandler(this.btnEditB_Click);
            // 
            // frmClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 565);
            this.Controls.Add(this.tpgIndividual);
            this.Name = "frmClientMenu";
            this.Text = "ClientMenu";
            this.Load += new System.EventHandler(this.frmClientMenu_Load);
            this.tpgIndividual.ResumeLayout(false);
            this.tpgIndividualClients.ResumeLayout(false);
            this.tpgBusinessClients.ResumeLayout(false);
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
    }
}