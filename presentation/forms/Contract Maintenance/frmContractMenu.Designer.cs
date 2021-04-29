
namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmContractMenu
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
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.btnEditContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.AccessibleDescription = "";
            this.btnViewContracts.Location = new System.Drawing.Point(172, 48);
            this.btnViewContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(364, 108);
            this.btnViewContracts.TabIndex = 0;
            this.btnViewContracts.Text = "View Contracts";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.btnViewContracts_Click);
            // 
            // btnEditContracts
            // 
            this.btnEditContracts.AccessibleDescription = "";
            this.btnEditContracts.Location = new System.Drawing.Point(172, 178);
            this.btnEditContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditContracts.Name = "btnEditContracts";
            this.btnEditContracts.Size = new System.Drawing.Size(364, 108);
            this.btnEditContracts.TabIndex = 1;
            this.btnEditContracts.Text = "Edit Contracts";
            this.btnEditContracts.UseVisualStyleBackColor = true;
            this.btnEditContracts.Click += new System.EventHandler(this.btnEditContracts_Click);
            // 
            // frmContractMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 410);
            this.Controls.Add(this.btnEditContracts);
            this.Controls.Add(this.btnViewContracts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmContractMenu";
            this.Text = "Contact Menu";
            this.Load += new System.EventHandler(this.frmContractMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewContracts;
        private System.Windows.Forms.Button btnEditContracts;
    }
}