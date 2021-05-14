
namespace Presentation.Forms.ClientMaintenance
{
    partial class frmNewEmployee
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
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.tbEmpContact = new System.Windows.Forms.TextBox();
            this.tbEmpRole = new System.Windows.Forms.TextBox();
            this.tbEmpSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(163, 39);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(159, 22);
            this.tbEmpName.TabIndex = 0;
            // 
            // tbEmpContact
            // 
            this.tbEmpContact.Location = new System.Drawing.Point(163, 123);
            this.tbEmpContact.Name = "tbEmpContact";
            this.tbEmpContact.Size = new System.Drawing.Size(159, 22);
            this.tbEmpContact.TabIndex = 1;
            // 
            // tbEmpRole
            // 
            this.tbEmpRole.Location = new System.Drawing.Point(163, 95);
            this.tbEmpRole.Name = "tbEmpRole";
            this.tbEmpRole.Size = new System.Drawing.Size(159, 22);
            this.tbEmpRole.TabIndex = 2;
            // 
            // tbEmpSurname
            // 
            this.tbEmpSurname.Location = new System.Drawing.Point(163, 67);
            this.tbEmpSurname.Name = "tbEmpSurname";
            this.tbEmpSurname.Size = new System.Drawing.Size(159, 22);
            this.tbEmpSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact Number";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(237, 173);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(85, 28);
            this.btnAddEmp.TabIndex = 8;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 240);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmpSurname);
            this.Controls.Add(this.tbEmpRole);
            this.Controls.Add(this.tbEmpContact);
            this.Controls.Add(this.tbEmpName);
            this.Name = "frmNewEmployee";
            this.Text = "frmNewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbEmpContact;
        private System.Windows.Forms.TextBox tbEmpRole;
        private System.Windows.Forms.TextBox tbEmpSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEmp;
    }
}