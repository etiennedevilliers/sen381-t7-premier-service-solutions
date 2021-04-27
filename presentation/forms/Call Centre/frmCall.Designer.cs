
namespace Presentation.Forms.CallCentre
{
    partial class frmCall
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
            this.cbAgents = new System.Windows.Forms.ComboBox();
            this.btnStartCall = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbIncoming = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbAgents
            // 
            this.cbAgents.FormattingEnabled = true;
            this.cbAgents.Location = new System.Drawing.Point(80, 12);
            this.cbAgents.Name = "cbAgents";
            this.cbAgents.Size = new System.Drawing.Size(197, 21);
            this.cbAgents.TabIndex = 0;
            this.cbAgents.SelectedIndexChanged += new System.EventHandler(this.cbAgents_SelectedIndexChanged);
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(12, 353);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(265, 23);
            this.btnStartCall.TabIndex = 1;
            this.btnStartCall.Text = "Start Call";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(3, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Select Agent:";
            // 
            // cbIncoming
            // 
            this.cbIncoming.AutoSize = true;
            this.cbIncoming.Location = new System.Drawing.Point(189, 39);
            this.cbIncoming.Name = "cbIncoming";
            this.cbIncoming.Size = new System.Drawing.Size(88, 17);
            this.cbIncoming.TabIndex = 3;
            this.cbIncoming.Text = "Incoming call";
            this.cbIncoming.UseVisualStyleBackColor = true;
            // 
            // frmCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 388);
            this.Controls.Add(this.cbIncoming);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStartCall);
            this.Controls.Add(this.cbAgents);
            this.Name = "frmCall";
            this.Text = "Call";
            this.Load += new System.EventHandler(this.frmCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAgents;
        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox cbIncoming;
    }
}