
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
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
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnIndividualNew = new System.Windows.Forms.Button();
            this.lblSurnameI = new System.Windows.Forms.Label();
            this.txtSurnameNewI = new System.Windows.Forms.TextBox();
            this.lblNameI = new System.Windows.Forms.Label();
            this.txtNameNewI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(31, 27);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(110, 17);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(145, 24);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(163, 22);
            this.txtContact.TabIndex = 14;
            // 
            // btnIndividualNew
            // 
            this.btnIndividualNew.Location = new System.Drawing.Point(233, 116);
            this.btnIndividualNew.Name = "btnIndividualNew";
            this.btnIndividualNew.Size = new System.Drawing.Size(75, 23);
            this.btnIndividualNew.TabIndex = 13;
            this.btnIndividualNew.Text = "Add";
            this.btnIndividualNew.UseVisualStyleBackColor = true;
            this.btnIndividualNew.Click += new System.EventHandler(this.btnIndividualNew_Click);
            // 
            // lblSurnameI
            // 
            this.lblSurnameI.AutoSize = true;
            this.lblSurnameI.Location = new System.Drawing.Point(31, 81);
            this.lblSurnameI.Name = "lblSurnameI";
            this.lblSurnameI.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameI.TabIndex = 12;
            this.lblSurnameI.Text = "Surname";
            // 
            // txtSurnameNewI
            // 
            this.txtSurnameNewI.Location = new System.Drawing.Point(145, 78);
            this.txtSurnameNewI.Name = "txtSurnameNewI";
            this.txtSurnameNewI.Size = new System.Drawing.Size(163, 22);
            this.txtSurnameNewI.TabIndex = 11;
            // 
            // lblNameI
            // 
            this.lblNameI.AutoSize = true;
            this.lblNameI.Location = new System.Drawing.Point(31, 53);
            this.lblNameI.Name = "lblNameI";
            this.lblNameI.Size = new System.Drawing.Size(45, 17);
            this.lblNameI.TabIndex = 10;
            this.lblNameI.Text = "Name";
            // 
            // txtNameNewI
            // 
            this.txtNameNewI.Location = new System.Drawing.Point(145, 50);
            this.txtNameNewI.Name = "txtNameNewI";
            this.txtNameNewI.Size = new System.Drawing.Size(163, 22);
            this.txtNameNewI.TabIndex = 9;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 215);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnIndividualNew);
            this.Controls.Add(this.txtNameNewI);
            this.Controls.Add(this.lblSurnameI);
            this.Controls.Add(this.lblNameI);
            this.Controls.Add(this.txtSurnameNewI);
            this.Name = "frmNewClient";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.frmNewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIndividualNew;
        private System.Windows.Forms.Label lblSurnameI;
        private System.Windows.Forms.TextBox txtSurnameNewI;
        private System.Windows.Forms.Label lblNameI;
        private System.Windows.Forms.TextBox txtNameNewI;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
    }
}