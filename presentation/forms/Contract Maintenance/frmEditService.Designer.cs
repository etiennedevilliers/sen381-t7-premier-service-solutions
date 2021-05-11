namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmEditService
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
            this.lblDesscription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDesscription
            // 
            this.lblDesscription.AutoSize = true;
            this.lblDesscription.Location = new System.Drawing.Point(49, 43);
            this.lblDesscription.Name = "lblDesscription";
            this.lblDesscription.Size = new System.Drawing.Size(120, 25);
            this.lblDesscription.TabIndex = 0;
            this.lblDesscription.Text = "Description";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(49, 110);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(93, 25);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(363, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(220, 43);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(287, 31);
            this.txtDescription.TabIndex = 3;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(220, 110);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(287, 31);
            this.txtDuration.TabIndex = 4;
            // 
            // frmEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 255);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblDesscription);
            this.Name = "frmEditService";
            this.Text = "frmEditService";
            this.Load += new System.EventHandler(this.frmEditService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesscription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuration;
    }
}