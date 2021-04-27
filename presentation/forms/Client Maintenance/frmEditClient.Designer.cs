
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmEditClient
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
            this.tpcEditClient = new System.Windows.Forms.TabControl();
            this.tpgIndividualEdit = new System.Windows.Forms.TabPage();
            this.btnIndividualEdit = new System.Windows.Forms.Button();
            this.lblSurnameI = new System.Windows.Forms.Label();
            this.txtSurnameEditI = new System.Windows.Forms.TextBox();
            this.lblNameI = new System.Windows.Forms.Label();
            this.txtNameEditI = new System.Windows.Forms.TextBox();
            this.tpgBusinessEdit = new System.Windows.Forms.TabPage();
            this.btnEditBusiness = new System.Windows.Forms.Button();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.txtBusinessNameEdit = new System.Windows.Forms.TextBox();
            this.tpcEditClient.SuspendLayout();
            this.tpgIndividualEdit.SuspendLayout();
            this.tpgBusinessEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpcEditClient
            // 
            this.tpcEditClient.Controls.Add(this.tpgIndividualEdit);
            this.tpcEditClient.Controls.Add(this.tpgBusinessEdit);
            this.tpcEditClient.Location = new System.Drawing.Point(12, 12);
            this.tpcEditClient.Name = "tpcEditClient";
            this.tpcEditClient.SelectedIndex = 0;
            this.tpcEditClient.Size = new System.Drawing.Size(615, 325);
            this.tpcEditClient.TabIndex = 1;
            // 
            // tpgIndividualEdit
            // 
            this.tpgIndividualEdit.Controls.Add(this.btnIndividualEdit);
            this.tpgIndividualEdit.Controls.Add(this.lblSurnameI);
            this.tpgIndividualEdit.Controls.Add(this.txtSurnameEditI);
            this.tpgIndividualEdit.Controls.Add(this.lblNameI);
            this.tpgIndividualEdit.Controls.Add(this.txtNameEditI);
            this.tpgIndividualEdit.Location = new System.Drawing.Point(4, 25);
            this.tpgIndividualEdit.Name = "tpgIndividualEdit";
            this.tpgIndividualEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpgIndividualEdit.Size = new System.Drawing.Size(607, 296);
            this.tpgIndividualEdit.TabIndex = 0;
            this.tpgIndividualEdit.Text = "Individual";
            this.tpgIndividualEdit.UseVisualStyleBackColor = true;
            // 
            // btnIndividualEdit
            // 
            this.btnIndividualEdit.Location = new System.Drawing.Point(130, 87);
            this.btnIndividualEdit.Name = "btnIndividualEdit";
            this.btnIndividualEdit.Size = new System.Drawing.Size(75, 23);
            this.btnIndividualEdit.TabIndex = 13;
            this.btnIndividualEdit.Text = "Edit";
            this.btnIndividualEdit.UseVisualStyleBackColor = true;
            this.btnIndividualEdit.Click += new System.EventHandler(this.btnIndividualEdit_Click);
            // 
            // lblSurnameI
            // 
            this.lblSurnameI.AutoSize = true;
            this.lblSurnameI.Location = new System.Drawing.Point(6, 37);
            this.lblSurnameI.Name = "lblSurnameI";
            this.lblSurnameI.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameI.TabIndex = 12;
            this.lblSurnameI.Text = "Surname";
            // 
            // txtSurnameEditI
            // 
            this.txtSurnameEditI.Location = new System.Drawing.Point(105, 34);
            this.txtSurnameEditI.Name = "txtSurnameEditI";
            this.txtSurnameEditI.Size = new System.Drawing.Size(171, 22);
            this.txtSurnameEditI.TabIndex = 11;
            // 
            // lblNameI
            // 
            this.lblNameI.AutoSize = true;
            this.lblNameI.Location = new System.Drawing.Point(6, 9);
            this.lblNameI.Name = "lblNameI";
            this.lblNameI.Size = new System.Drawing.Size(45, 17);
            this.lblNameI.TabIndex = 10;
            this.lblNameI.Text = "Name";
            // 
            // txtNameEditI
            // 
            this.txtNameEditI.Location = new System.Drawing.Point(105, 6);
            this.txtNameEditI.Name = "txtNameEditI";
            this.txtNameEditI.Size = new System.Drawing.Size(171, 22);
            this.txtNameEditI.TabIndex = 9;
            // 
            // tpgBusinessEdit
            // 
            this.tpgBusinessEdit.Controls.Add(this.btnEditBusiness);
            this.tpgBusinessEdit.Controls.Add(this.lblBusinessName);
            this.tpgBusinessEdit.Controls.Add(this.txtBusinessNameEdit);
            this.tpgBusinessEdit.Location = new System.Drawing.Point(4, 25);
            this.tpgBusinessEdit.Name = "tpgBusinessEdit";
            this.tpgBusinessEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBusinessEdit.Size = new System.Drawing.Size(607, 296);
            this.tpgBusinessEdit.TabIndex = 1;
            this.tpgBusinessEdit.Text = "Business";
            this.tpgBusinessEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditBusiness
            // 
            this.btnEditBusiness.Location = new System.Drawing.Point(149, 52);
            this.btnEditBusiness.Name = "btnEditBusiness";
            this.btnEditBusiness.Size = new System.Drawing.Size(75, 23);
            this.btnEditBusiness.TabIndex = 14;
            this.btnEditBusiness.Text = "Edit";
            this.btnEditBusiness.UseVisualStyleBackColor = true;
            this.btnEditBusiness.Click += new System.EventHandler(this.btnEditBusiness_Click);
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(6, 9);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(106, 17);
            this.lblBusinessName.TabIndex = 10;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessNameEdit
            // 
            this.txtBusinessNameEdit.Location = new System.Drawing.Point(124, 6);
            this.txtBusinessNameEdit.Name = "txtBusinessNameEdit";
            this.txtBusinessNameEdit.Size = new System.Drawing.Size(167, 22);
            this.txtBusinessNameEdit.TabIndex = 9;
            // 
            // frmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.tpcEditClient);
            this.Name = "frmEditClient";
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.frmEditClient_Load);
            this.tpcEditClient.ResumeLayout(false);
            this.tpgIndividualEdit.ResumeLayout(false);
            this.tpgIndividualEdit.PerformLayout();
            this.tpgBusinessEdit.ResumeLayout(false);
            this.tpgBusinessEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpcEditClient;
        private System.Windows.Forms.TabPage tpgIndividualEdit;
        private System.Windows.Forms.Button btnIndividualEdit;
        private System.Windows.Forms.Label lblSurnameI;
        private System.Windows.Forms.TextBox txtSurnameEditI;
        private System.Windows.Forms.Label lblNameI;
        private System.Windows.Forms.TextBox txtNameEditI;
        private System.Windows.Forms.TabPage tpgBusinessEdit;
        private System.Windows.Forms.Button btnEditBusiness;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txtBusinessNameEdit;
    }
}