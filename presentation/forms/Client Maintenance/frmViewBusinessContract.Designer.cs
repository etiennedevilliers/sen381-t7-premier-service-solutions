
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmViewBusinessContract
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
            this.lstViewBusi = new System.Windows.Forms.ListView();
            this.tbBusContact = new System.Windows.Forms.TextBox();
            this.tbBusiName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewBusi
            // 
            this.lstViewBusi.HideSelection = false;
            this.lstViewBusi.Location = new System.Drawing.Point(88, 98);
            this.lstViewBusi.Name = "lstViewBusi";
            this.lstViewBusi.Size = new System.Drawing.Size(625, 255);
            this.lstViewBusi.TabIndex = 1;
            this.lstViewBusi.UseCompatibleStateImageBehavior = false;
            // 
            // tbBusContact
            // 
            this.tbBusContact.Location = new System.Drawing.Point(88, 57);
            this.tbBusContact.Name = "tbBusContact";
            this.tbBusContact.Size = new System.Drawing.Size(154, 22);
            this.tbBusContact.TabIndex = 2;
            // 
            // tbBusiName
            // 
            this.tbBusiName.Location = new System.Drawing.Point(279, 57);
            this.tbBusiName.Name = "tbBusiName";
            this.tbBusiName.Size = new System.Drawing.Size(163, 22);
            this.tbBusiName.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(621, 44);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 48);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmViewBusinessContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbBusiName);
            this.Controls.Add(this.tbBusContact);
            this.Controls.Add(this.lstViewBusi);
            this.Name = "frmViewBusinessContract";
            this.Text = "frmViewBusinessContract";
            this.Load += new System.EventHandler(this.frmViewBusinessContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewBusi;
        private System.Windows.Forms.TextBox tbBusContact;
        private System.Windows.Forms.TextBox tbBusiName;
        private System.Windows.Forms.Button btnApply;
    }
}