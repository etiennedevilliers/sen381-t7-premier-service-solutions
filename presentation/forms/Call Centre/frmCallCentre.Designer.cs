
namespace Presentation.Forms.CallCentre
{
    partial class frmCallCentre
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
            this.btnCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.BackgroundImage = global::sen381_t7_premier_service_solutions.Properties.Resources.phone_outgoing;
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall.Location = new System.Drawing.Point(12, 12);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(99, 99);
            this.btnCall.TabIndex = 0;
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // frmCallCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 125);
            this.Controls.Add(this.btnCall);
            this.Name = "frmCallCentre";
            this.Text = "StartCall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
    }
}