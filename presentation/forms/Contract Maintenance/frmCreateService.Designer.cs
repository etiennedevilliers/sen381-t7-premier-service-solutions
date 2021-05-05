namespace Presentation.Forms.Contract_Maintenance
{
    partial class frmCreateService
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
            this.lblServiceDescript = new System.Windows.Forms.Label();
            this.txtSDescript = new System.Windows.Forms.TextBox();
            this.txtSDuration = new System.Windows.Forms.TextBox();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.lstServiceAdd = new System.Windows.Forms.ListView();
            this.chServiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceDescript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpectDura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnServiceAddOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServiceDescript
            // 
            this.lblServiceDescript.AutoSize = true;
            this.lblServiceDescript.Location = new System.Drawing.Point(58, 34);
            this.lblServiceDescript.Name = "lblServiceDescript";
            this.lblServiceDescript.Size = new System.Drawing.Size(198, 25);
            this.lblServiceDescript.TabIndex = 0;
            this.lblServiceDescript.Text = "Service Description";
            // 
            // txtSDescript
            // 
            this.txtSDescript.Location = new System.Drawing.Point(279, 31);
            this.txtSDescript.Name = "txtSDescript";
            this.txtSDescript.Size = new System.Drawing.Size(346, 31);
            this.txtSDescript.TabIndex = 2;
            // 
            // txtSDuration
            // 
            this.txtSDuration.Location = new System.Drawing.Point(279, 95);
            this.txtSDuration.Name = "txtSDuration";
            this.txtSDuration.Size = new System.Drawing.Size(346, 31);
            this.txtSDuration.TabIndex = 3;
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Location = new System.Drawing.Point(58, 98);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(171, 25);
            this.lblServiceDuration.TabIndex = 1;
            this.lblServiceDuration.Text = "Service Duration";
            // 
            // lstServiceAdd
            // 
            this.lstServiceAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chServiceID,
            this.chServiceDescript,
            this.chExpectDura});
            this.lstServiceAdd.HideSelection = false;
            this.lstServiceAdd.Location = new System.Drawing.Point(279, 152);
            this.lstServiceAdd.Name = "lstServiceAdd";
            this.lstServiceAdd.Size = new System.Drawing.Size(597, 298);
            this.lstServiceAdd.TabIndex = 4;
            this.lstServiceAdd.UseCompatibleStateImageBehavior = false;
            this.lstServiceAdd.View = System.Windows.Forms.View.Details;
            // 
            // chServiceID
            // 
            this.chServiceID.Text = "ServiceID";
            this.chServiceID.Width = 138;
            // 
            // chServiceDescript
            // 
            this.chServiceDescript.Text = "Service Description";
            this.chServiceDescript.Width = 206;
            // 
            // chExpectDura
            // 
            this.chExpectDura.Text = "Expected Duration";
            this.chExpectDura.Width = 196;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(63, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(193, 41);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnServiceAddOK
            // 
            this.btnServiceAddOK.Location = new System.Drawing.Point(683, 468);
            this.btnServiceAddOK.Name = "btnServiceAddOK";
            this.btnServiceAddOK.Size = new System.Drawing.Size(193, 41);
            this.btnServiceAddOK.TabIndex = 7;
            this.btnServiceAddOK.Text = "Remove";
            this.btnServiceAddOK.UseVisualStyleBackColor = true;
            // 
            // frmCreateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 540);
            this.Controls.Add(this.btnServiceAddOK);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstServiceAdd);
            this.Controls.Add(this.txtSDuration);
            this.Controls.Add(this.txtSDescript);
            this.Controls.Add(this.lblServiceDuration);
            this.Controls.Add(this.lblServiceDescript);
            this.Name = "frmCreateService";
            this.Text = "frmCreateService";
            this.Load += new System.EventHandler(this.frmCreateService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceDescript;
        private System.Windows.Forms.TextBox txtSDescript;
        private System.Windows.Forms.TextBox txtSDuration;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.ListView lstServiceAdd;
        private System.Windows.Forms.ColumnHeader chServiceID;
        private System.Windows.Forms.ColumnHeader chServiceDescript;
        private System.Windows.Forms.ColumnHeader chExpectDura;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnServiceAddOK;
    }
}