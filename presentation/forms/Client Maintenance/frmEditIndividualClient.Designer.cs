
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmEditIndividualClient
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbContactDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(22, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 22);
            this.tbName.TabIndex = 0;
           // this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(22, 96);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(119, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(22, 40);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(119, 22);
            this.tbSurname.TabIndex = 2;
            // 
            // tbContactDetails
            // 
            this.tbContactDetails.Location = new System.Drawing.Point(22, 68);
            this.tbContactDetails.Name = "tbContactDetails";
            this.tbContactDetails.Size = new System.Drawing.Size(119, 22);
            this.tbContactDetails.TabIndex = 3;
            // 
            // frmEditIndividualClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 143);
            this.Controls.Add(this.tbContactDetails);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbName);
            this.Name = "frmEditIndividualClient";
            this.Text = "frmEditIndividualClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbContactDetails;
    }
}