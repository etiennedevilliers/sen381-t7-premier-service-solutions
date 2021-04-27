
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
            this.lblEdContactI = new System.Windows.Forms.Label();
            this.txtContactEdI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactEdB = new System.Windows.Forms.TextBox();
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
            this.tpcEditClient.Size = new System.Drawing.Size(317, 368);
            this.tpcEditClient.TabIndex = 1;
            // 
            // tpgIndividualEdit
            // 
            this.tpgIndividualEdit.Controls.Add(this.lblEdContactI);
            this.tpgIndividualEdit.Controls.Add(this.txtContactEdI);
            this.tpgIndividualEdit.Controls.Add(this.btnIndividualEdit);
            this.tpgIndividualEdit.Controls.Add(this.lblSurnameI);
            this.tpgIndividualEdit.Controls.Add(this.txtSurnameEditI);
            this.tpgIndividualEdit.Controls.Add(this.lblNameI);
            this.tpgIndividualEdit.Controls.Add(this.txtNameEditI);
            this.tpgIndividualEdit.Location = new System.Drawing.Point(4, 25);
            this.tpgIndividualEdit.Name = "tpgIndividualEdit";
            this.tpgIndividualEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpgIndividualEdit.Size = new System.Drawing.Size(309, 339);
            this.tpgIndividualEdit.TabIndex = 0;
            this.tpgIndividualEdit.Text = "Individual";
            this.tpgIndividualEdit.UseVisualStyleBackColor = true;
            // 
            // btnIndividualEdit
            // 
            this.btnIndividualEdit.Location = new System.Drawing.Point(216, 90);
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
            this.lblSurnameI.Location = new System.Drawing.Point(4, 65);
            this.lblSurnameI.Name = "lblSurnameI";
            this.lblSurnameI.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameI.TabIndex = 12;
            this.lblSurnameI.Text = "Surname";
            // 
            // txtSurnameEditI
            // 
            this.txtSurnameEditI.Location = new System.Drawing.Point(120, 62);
            this.txtSurnameEditI.Name = "txtSurnameEditI";
            this.txtSurnameEditI.Size = new System.Drawing.Size(171, 22);
            this.txtSurnameEditI.TabIndex = 11;
            // 
            // lblNameI
            // 
            this.lblNameI.AutoSize = true;
            this.lblNameI.Location = new System.Drawing.Point(4, 37);
            this.lblNameI.Name = "lblNameI";
            this.lblNameI.Size = new System.Drawing.Size(45, 17);
            this.lblNameI.TabIndex = 10;
            this.lblNameI.Text = "Name";
            // 
            // txtNameEditI
            // 
            this.txtNameEditI.Location = new System.Drawing.Point(120, 34);
            this.txtNameEditI.Name = "txtNameEditI";
            this.txtNameEditI.Size = new System.Drawing.Size(171, 22);
            this.txtNameEditI.TabIndex = 9;
            // 
            // tpgBusinessEdit
            // 
            this.tpgBusinessEdit.Controls.Add(this.label1);
            this.tpgBusinessEdit.Controls.Add(this.txtContactEdB);
            this.tpgBusinessEdit.Controls.Add(this.btnEditBusiness);
            this.tpgBusinessEdit.Controls.Add(this.lblBusinessName);
            this.tpgBusinessEdit.Controls.Add(this.txtBusinessNameEdit);
            this.tpgBusinessEdit.Location = new System.Drawing.Point(4, 25);
            this.tpgBusinessEdit.Name = "tpgBusinessEdit";
            this.tpgBusinessEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBusinessEdit.Size = new System.Drawing.Size(309, 339);
            this.tpgBusinessEdit.TabIndex = 1;
            this.tpgBusinessEdit.Text = "Business";
            this.tpgBusinessEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditBusiness
            // 
            this.btnEditBusiness.Location = new System.Drawing.Point(220, 83);
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
            this.lblBusinessName.Location = new System.Drawing.Point(6, 40);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(106, 17);
            this.lblBusinessName.TabIndex = 10;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessNameEdit
            // 
            this.txtBusinessNameEdit.Location = new System.Drawing.Point(120, 37);
            this.txtBusinessNameEdit.Name = "txtBusinessNameEdit";
            this.txtBusinessNameEdit.Size = new System.Drawing.Size(175, 22);
            this.txtBusinessNameEdit.TabIndex = 9;
            // 
            // lblEdContactI
            // 
            this.lblEdContactI.AutoSize = true;
            this.lblEdContactI.Location = new System.Drawing.Point(4, 9);
            this.lblEdContactI.Name = "lblEdContactI";
            this.lblEdContactI.Size = new System.Drawing.Size(110, 17);
            this.lblEdContactI.TabIndex = 15;
            this.lblEdContactI.Text = "Contact Number";
            // 
            // txtContactEdI
            // 
            this.txtContactEdI.Location = new System.Drawing.Point(120, 6);
            this.txtContactEdI.Name = "txtContactEdI";
            this.txtContactEdI.Size = new System.Drawing.Size(171, 22);
            this.txtContactEdI.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contact Number";
            // 
            // txtContactEdB
            // 
            this.txtContactEdB.Location = new System.Drawing.Point(120, 9);
            this.txtContactEdB.Name = "txtContactEdB";
            this.txtContactEdB.Size = new System.Drawing.Size(175, 22);
            this.txtContactEdB.TabIndex = 16;
            // 
            // frmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 475);
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
        private System.Windows.Forms.Label lblEdContactI;
        private System.Windows.Forms.TextBox txtContactEdI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactEdB;
    }
}