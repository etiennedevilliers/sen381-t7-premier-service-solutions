
namespace Presentation.Forms.ClientMaintenance
{
    partial class frmNewEquipment
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
            this.lblSerialNum = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSerialNum
            // 
            this.lblSerialNum.AutoSize = true;
            this.lblSerialNum.Location = new System.Drawing.Point(6, 19);
            this.lblSerialNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialNum.Name = "lblSerialNum";
            this.lblSerialNum.Size = new System.Drawing.Size(76, 13);
            this.lblSerialNum.TabIndex = 0;
            this.lblSerialNum.Text = "Serial Number:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(6, 44);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 68);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(285, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(112, 16);
            this.txtSerialNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(238, 20);
            this.txtSerialNum.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(112, 41);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(238, 20);
            this.txtManufacturer.TabIndex = 5;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(112, 65);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(238, 21);
            this.cbxCategory.TabIndex = 6;
            // 
            // frmNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 145);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSerialNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSerialNum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewEquipment";
            this.Text = "frmNewEquipment";
            this.Load += new System.EventHandler(this.frmNewEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerialNum;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSerialNum;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.ComboBox cbxCategory;
    }
}