
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(23, 22);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(84, 13);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(109, 20);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(123, 20);
            this.txtContact.TabIndex = 14;
            // 
            // btnIndividualNew
            // 
            this.btnIndividualNew.Location = new System.Drawing.Point(176, 145);
            this.btnIndividualNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIndividualNew.Name = "btnIndividualNew";
            this.btnIndividualNew.Size = new System.Drawing.Size(56, 19);
            this.btnIndividualNew.TabIndex = 13;
            this.btnIndividualNew.Text = "Add";
            this.btnIndividualNew.UseVisualStyleBackColor = true;
            this.btnIndividualNew.Click += new System.EventHandler(this.btnIndividualNew_Click);
            // 
            // lblSurnameI
            // 
            this.lblSurnameI.AutoSize = true;
            this.lblSurnameI.Location = new System.Drawing.Point(23, 66);
            this.lblSurnameI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnameI.Name = "lblSurnameI";
            this.lblSurnameI.Size = new System.Drawing.Size(49, 13);
            this.lblSurnameI.TabIndex = 12;
            this.lblSurnameI.Text = "Surname";
            // 
            // txtSurnameNewI
            // 
            this.txtSurnameNewI.Location = new System.Drawing.Point(109, 63);
            this.txtSurnameNewI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurnameNewI.Name = "txtSurnameNewI";
            this.txtSurnameNewI.Size = new System.Drawing.Size(123, 20);
            this.txtSurnameNewI.TabIndex = 11;
            // 
            // lblNameI
            // 
            this.lblNameI.AutoSize = true;
            this.lblNameI.Location = new System.Drawing.Point(23, 43);
            this.lblNameI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameI.Name = "lblNameI";
            this.lblNameI.Size = new System.Drawing.Size(35, 13);
            this.lblNameI.TabIndex = 10;
            this.lblNameI.Text = "Name";
            // 
            // txtNameNewI
            // 
            this.txtNameNewI.Location = new System.Drawing.Point(109, 41);
            this.txtNameNewI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameNewI.Name = "txtNameNewI";
            this.txtNameNewI.Size = new System.Drawing.Size(123, 20);
            this.txtNameNewI.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Regenerate ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(109, 88);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.ReadOnly = true;
            this.tbClientID.Size = new System.Drawing.Size(125, 20);
            this.tbClientID.TabIndex = 17;
            this.tbClientID.TextChanged += new System.EventHandler(this.tbClientID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Client ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnIndividualNew);
            this.Controls.Add(this.txtNameNewI);
            this.Controls.Add(this.lblSurnameI);
            this.Controls.Add(this.lblNameI);
            this.Controls.Add(this.txtSurnameNewI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label label1;
    }
}