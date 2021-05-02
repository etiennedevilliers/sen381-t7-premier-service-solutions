
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmViewContract
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
            this.lstViewIndiv = new System.Windows.Forms.ListView();
            this.tbIndivName = new System.Windows.Forms.TextBox();
            this.tbIndivContact = new System.Windows.Forms.TextBox();
            this.tbIndivSurname = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewIndiv
            // 
            this.lstViewIndiv.HideSelection = false;
            this.lstViewIndiv.Location = new System.Drawing.Point(58, 119);
            this.lstViewIndiv.Name = "lstViewIndiv";
            this.lstViewIndiv.Size = new System.Drawing.Size(625, 255);
            this.lstViewIndiv.TabIndex = 0;
            this.lstViewIndiv.UseCompatibleStateImageBehavior = false;
            // 
            // tbIndivName
            // 
            this.tbIndivName.Location = new System.Drawing.Point(58, 75);
            this.tbIndivName.Name = "tbIndivName";
            this.tbIndivName.Size = new System.Drawing.Size(147, 22);
            this.tbIndivName.TabIndex = 1;
            // 
            // tbIndivContact
            // 
            this.tbIndivContact.Location = new System.Drawing.Point(395, 75);
            this.tbIndivContact.Name = "tbIndivContact";
            this.tbIndivContact.Size = new System.Drawing.Size(172, 22);
            this.tbIndivContact.TabIndex = 2;
            // 
            // tbIndivSurname
            // 
            this.tbIndivSurname.Location = new System.Drawing.Point(217, 75);
            this.tbIndivSurname.Name = "tbIndivSurname";
            this.tbIndivSurname.Size = new System.Drawing.Size(168, 22);
            this.tbIndivSurname.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(597, 59);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 48);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmViewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbIndivSurname);
            this.Controls.Add(this.tbIndivContact);
            this.Controls.Add(this.tbIndivName);
            this.Controls.Add(this.lstViewIndiv);
            this.Name = "frmViewContract";
            this.Text = "ViewContract";
            this.Load += new System.EventHandler(this.frmViewContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewIndiv;
        private System.Windows.Forms.TextBox tbIndivName;
        private System.Windows.Forms.TextBox tbIndivContact;
        private System.Windows.Forms.TextBox tbIndivSurname;
        private System.Windows.Forms.Button btnApply;
    }
}