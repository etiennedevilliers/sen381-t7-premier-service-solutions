
namespace Presentation.Forms.ServiceDepartment
{
    partial class frmViewServices
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblCurrentServices = new System.Windows.Forms.Label();
            this.lstCurrentServices = new System.Windows.Forms.ListView();
            this.colServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(625, 12);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(163, 51);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Service Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblCurrentServices
            // 
            this.lblCurrentServices.AutoSize = true;
            this.lblCurrentServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentServices.Location = new System.Drawing.Point(23, 22);
            this.lblCurrentServices.Name = "lblCurrentServices";
            this.lblCurrentServices.Size = new System.Drawing.Size(158, 25);
            this.lblCurrentServices.TabIndex = 1;
            this.lblCurrentServices.Text = "Current Services";
            // 
            // lstCurrentServices
            // 
            this.lstCurrentServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceName});
            this.lstCurrentServices.HideSelection = false;
            this.lstCurrentServices.Location = new System.Drawing.Point(12, 69);
            this.lstCurrentServices.Name = "lstCurrentServices";
            this.lstCurrentServices.Size = new System.Drawing.Size(776, 369);
            this.lstCurrentServices.TabIndex = 2;
            this.lstCurrentServices.UseCompatibleStateImageBehavior = false;
            this.lstCurrentServices.View = System.Windows.Forms.View.Details;
            // 
            // colServiceName
            // 
            this.colServiceName.Text = "Service Name";
            this.colServiceName.Width = 112;
            // 
            // frmViewServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCurrentServices);
            this.Controls.Add(this.lblCurrentServices);
            this.Controls.Add(this.btnComplete);
            this.Name = "frmViewServices";
            this.Text = "View Services Assigned";
            this.Load += new System.EventHandler(this.frmViewServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblCurrentServices;
        private System.Windows.Forms.ListView lstCurrentServices;
        private System.Windows.Forms.ColumnHeader colServiceName;
    }
}