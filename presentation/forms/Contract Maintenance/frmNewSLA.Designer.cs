namespace Presentation.Forms.ContractMaintenance
{
    partial class frmNewSLA
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
            this.lblSLADescript = new System.Windows.Forms.Label();
            this.btnAddSLA = new System.Windows.Forms.Button();
            this.txtSLADescript = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSLADescript
            // 
            this.lblSLADescript.AutoSize = true;
            this.lblSLADescript.Location = new System.Drawing.Point(83, 76);
            this.lblSLADescript.Name = "lblSLADescript";
            this.lblSLADescript.Size = new System.Drawing.Size(120, 25);
            this.lblSLADescript.TabIndex = 0;
            this.lblSLADescript.Text = "Description";
            // 
            // btnAddSLA
            // 
            this.btnAddSLA.Location = new System.Drawing.Point(331, 131);
            this.btnAddSLA.Name = "btnAddSLA";
            this.btnAddSLA.Size = new System.Drawing.Size(143, 42);
            this.btnAddSLA.TabIndex = 1;
            this.btnAddSLA.Text = "Add";
            this.btnAddSLA.UseVisualStyleBackColor = true;
            this.btnAddSLA.Click += new System.EventHandler(this.btnAddSLA_Click);
            // 
            // txtSLADescript
            // 
            this.txtSLADescript.Location = new System.Drawing.Point(251, 76);
            this.txtSLADescript.Name = "txtSLADescript";
            this.txtSLADescript.Size = new System.Drawing.Size(223, 31);
            this.txtSLADescript.TabIndex = 2;
            // 
            // frmNewSLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 227);
            this.Controls.Add(this.txtSLADescript);
            this.Controls.Add(this.btnAddSLA);
            this.Controls.Add(this.lblSLADescript);
            this.Name = "frmNewSLA";
            this.Text = "frmNewSLA";
            this.Load += new System.EventHandler(this.frmNewSLA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSLADescript;
        private System.Windows.Forms.Button btnAddSLA;
        private System.Windows.Forms.TextBox txtSLADescript;
    }
}