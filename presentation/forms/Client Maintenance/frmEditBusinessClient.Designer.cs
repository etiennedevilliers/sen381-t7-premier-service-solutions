
namespace Presentation.Forms.ClientMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContactBusiness
            // 
            this.tbContactBusiness.Location = new System.Drawing.Point(91, 22);
            this.tbContactBusiness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContactBusiness.Name = "tbContactBusiness";
            this.tbContactBusiness.Size = new System.Drawing.Size(130, 20);
            this.tbContactBusiness.TabIndex = 19;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(165, 128);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(56, 19);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbNameBusiness
            // 
            this.tbNameBusiness.Location = new System.Drawing.Point(91, 46);
            this.tbNameBusiness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameBusiness.Name = "tbNameBusiness";
            this.tbNameBusiness.Size = new System.Drawing.Size(132, 20);
            this.tbNameBusiness.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Client ID";
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(91, 71);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.ReadOnly = true;
            this.tbClientID.Size = new System.Drawing.Size(132, 20);
            this.tbClientID.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Regenerate ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contact";
            // 
            // frmEditBusinessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbContactBusiness);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbNameBusiness);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEditBusinessClient";
            this.Text = "frmEditBusinessClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContactBusiness;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbNameBusiness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}