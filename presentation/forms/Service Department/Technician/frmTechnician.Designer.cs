
namespace Presentation.Forms.ServiceDepartment
{
    partial class frmTechnician
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
            this.lblServiceContract = new System.Windows.Forms.Label();
            this.lstCurrentServices = new System.Windows.Forms.ListView();
            this.colServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstEquipment = new System.Windows.Forms.ListView();
            this.colSerialNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
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
            // lblServiceContract
            // 
            this.lblServiceContract.AutoSize = true;
            this.lblServiceContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceContract.Location = new System.Drawing.Point(7, 22);
            this.lblServiceContract.Name = "lblServiceContract";
            this.lblServiceContract.Size = new System.Drawing.Size(225, 25);
            this.lblServiceContract.TabIndex = 1;
            this.lblServiceContract.Text = "Current Service Request";
            // 
            // lstCurrentServices
            // 
            this.lstCurrentServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceName,
            this.colDuration});
            this.lstCurrentServices.FullRowSelect = true;
            this.lstCurrentServices.HideSelection = false;
            this.lstCurrentServices.Location = new System.Drawing.Point(12, 96);
            this.lstCurrentServices.MultiSelect = false;
            this.lstCurrentServices.Name = "lstCurrentServices";
            this.lstCurrentServices.Size = new System.Drawing.Size(357, 342);
            this.lstCurrentServices.TabIndex = 2;
            this.lstCurrentServices.UseCompatibleStateImageBehavior = false;
            this.lstCurrentServices.View = System.Windows.Forms.View.Details;
            // 
            // colServiceName
            // 
            this.colServiceName.Text = "Service Name";
            this.colServiceName.Width = 112;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Expected Duration";
            this.colDuration.Width = 133;
            // 
            // lstEquipment
            // 
            this.lstEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerialNum,
            this.colManufacturer,
            this.colCategory});
            this.lstEquipment.FullRowSelect = true;
            this.lstEquipment.HideSelection = false;
            this.lstEquipment.Location = new System.Drawing.Point(431, 96);
            this.lstEquipment.MultiSelect = false;
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(357, 342);
            this.lstEquipment.TabIndex = 3;
            this.lstEquipment.UseCompatibleStateImageBehavior = false;
            this.lstEquipment.View = System.Windows.Forms.View.Details;
            // 
            // colSerialNum
            // 
            this.colSerialNum.Text = "Serial Number";
            this.colSerialNum.Width = 112;
            // 
            // colManufacturer
            // 
            this.colManufacturer.Text = "Manufacturer";
            this.colManufacturer.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 115;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.Location = new System.Drawing.Point(426, 68);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(111, 25);
            this.lblEquipment.TabIndex = 4;
            this.lblEquipment.Text = "Equipment:";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(7, 68);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(94, 25);
            this.lblServices.TabIndex = 5;
            this.lblServices.Text = "Services:";
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lstEquipment);
            this.Controls.Add(this.lstCurrentServices);
            this.Controls.Add(this.lblServiceContract);
            this.Controls.Add(this.btnComplete);
            this.Name = "frmTechnician";
            this.Text = "View Services Assigned";
            this.Load += new System.EventHandler(this.frmViewServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblServiceContract;
        private System.Windows.Forms.ListView lstCurrentServices;
        private System.Windows.Forms.ColumnHeader colServiceName;
        private System.Windows.Forms.ListView lstEquipment;
        private System.Windows.Forms.ColumnHeader colSerialNum;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colManufacturer;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label lblServices;
    }
}