
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
            this.btnStartCall.Location = new System.Drawing.Point(488, 679);
            this.btnStartCall.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(66, 44);
            this.btnStartCall.TabIndex = 1;
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 25);
            this.lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(140, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Select Agent:";
            // 
            // agentCollection
            // 
            this.agentCollection.FormattingEnabled = true;
            this.agentCollection.ItemHeight = 25;
            this.agentCollection.Location = new System.Drawing.Point(18, 135);
            this.agentCollection.Name = "agentCollection";
            this.agentCollection.Size = new System.Drawing.Size(536, 529);
            this.agentCollection.TabIndex = 4;
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Location = new System.Drawing.Point(144, 76);
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(410, 31);
            this.tbNameFilter.TabIndex = 5;
            this.tbNameFilter.TextChanged += new System.EventHandler(this.tbNameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Call";
            // 
            // frmSelectAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 746);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameFilter);
            this.Controls.Add(this.agentCollection);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStartCall);
            this.Margin = new System.Windows.Forms.Padding(6);
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