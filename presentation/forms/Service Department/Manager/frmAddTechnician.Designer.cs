
namespace Presentation.Forms.ServiceDepartment
{
    partial class frmAddTechnician
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.lstSkills = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpectedDur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxServices = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(498, 531);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(380, 119);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 31);
            this.txtName.TabIndex = 1;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(244, 62);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(336, 31);
            this.txtContactNum.TabIndex = 2;
            // 
            // lstSkills
            // 
            this.lstSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDescription,
            this.colExpectedDur});
            this.lstSkills.HideSelection = false;
            this.lstSkills.Location = new System.Drawing.Point(244, 163);
            this.lstSkills.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(630, 352);
            this.lstSkills.TabIndex = 3;
            this.lstSkills.UseCompatibleStateImageBehavior = false;
            this.lstSkills.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 39;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 166;
            // 
            // colExpectedDur
            // 
            this.colExpectedDur.Text = "Expected Duration";
            this.colExpectedDur.Width = 103;
            // 
            // cbxServices
            // 
            this.cbxServices.FormattingEnabled = true;
            this.cbxServices.Location = new System.Drawing.Point(244, 112);
            this.cbxServices.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxServices.Name = "cbxServices";
            this.cbxServices.Size = new System.Drawing.Size(620, 33);
            this.cbxServices.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 163);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(52, 215);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(46, 67);
            this.lblContactNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(173, 25);
            this.lblContactNum.TabIndex = 8;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(46, 119);
            this.lblSkills.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(69, 25);
            this.lblSkills.TabIndex = 9;
            this.lblSkills.Text = "Skills:";
            // 
            // frmAddTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 663);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxServices);
            this.Controls.Add(this.lstSkills);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAddTechnician";
            this.Text = "frmAddTechnician";
            this.Load += new System.EventHandler(this.frmAddTechnician_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.ListView lstSkills;
        private System.Windows.Forms.ComboBox cbxServices;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colExpectedDur;
    }
}