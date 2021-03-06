
namespace Presentation.Forms.Agents
{
    partial class frmSelectAgent
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
            this.btnStartCall = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.agentCollection = new System.Windows.Forms.ListBox();
            this.tbNameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartCall
            // 
            this.btnStartCall.BackgroundImage = global::sen381_t7_premier_service_solutions.Properties.Resources.phone_outgoing;
            this.btnStartCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartCall.Location = new System.Drawing.Point(242, 346);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(37, 37);
            this.btnStartCall.TabIndex = 1;
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Select Agent:";
            // 
            // agentCollection
            // 
            this.agentCollection.FormattingEnabled = true;
            this.agentCollection.Location = new System.Drawing.Point(9, 70);
            this.agentCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agentCollection.Name = "agentCollection";
            this.agentCollection.Size = new System.Drawing.Size(270, 277);
            this.agentCollection.TabIndex = 4;
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Location = new System.Drawing.Point(72, 40);
            this.tbNameFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(207, 20);
            this.tbNameFilter.TabIndex = 5;
            this.tbNameFilter.TextChanged += new System.EventHandler(this.tbNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Call";
            // 
            // frmSelectAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameFilter);
            this.Controls.Add(this.agentCollection);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStartCall);
            this.Name = "frmSelectAgent";
            this.Text = "Select Agent";
            this.Load += new System.EventHandler(this.frmCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartCall;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox agentCollection;
        private System.Windows.Forms.TextBox tbNameFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}