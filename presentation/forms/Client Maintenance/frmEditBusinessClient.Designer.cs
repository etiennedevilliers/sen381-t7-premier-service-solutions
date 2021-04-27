
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmEditBusinessClient
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
            this.tbContactBusiness = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbNameBusiness = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbContactBusiness
            // 
            this.tbContactBusiness.Location = new System.Drawing.Point(34, 29);
            this.tbContactBusiness.Name = "tbContactBusiness";
            this.tbContactBusiness.Size = new System.Drawing.Size(175, 22);
            this.tbContactBusiness.TabIndex = 19;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(134, 103);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbNameBusiness
            // 
            this.tbNameBusiness.Location = new System.Drawing.Point(34, 57);
            this.tbNameBusiness.Name = "tbNameBusiness";
            this.tbNameBusiness.Size = new System.Drawing.Size(175, 22);
            this.tbNameBusiness.TabIndex = 17;
            // 
            // frmEditBusinessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 240);
            this.Controls.Add(this.tbContactBusiness);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbNameBusiness);
            this.Name = "frmEditBusinessClient";
            this.Text = "frmEditBusinessClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContactBusiness;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbNameBusiness;
    }
}