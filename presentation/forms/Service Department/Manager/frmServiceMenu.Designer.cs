
namespace Presentation.Forms.ServiceDepartment
{
    partial class frmServiceMenu
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
            this.tabServiceMenu = new System.Windows.Forms.TabControl();
            this.tpgService = new System.Windows.Forms.TabPage();
            this.lstServices = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJobStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateResolved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCallTimeStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCallTimeEnded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTechnicians = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseRequest = new System.Windows.Forms.Button();
            this.tpgTechnicians = new System.Windows.Forms.TabPage();
            this.tabServiceMenu.SuspendLayout();
            this.tpgService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabServiceMenu
            // 
            this.tabServiceMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabServiceMenu.Controls.Add(this.tpgService);
            this.tabServiceMenu.Controls.Add(this.tpgTechnicians);
            this.tabServiceMenu.Location = new System.Drawing.Point(0, 3);
            this.tabServiceMenu.Name = "tabServiceMenu";
            this.tabServiceMenu.SelectedIndex = 0;
            this.tabServiceMenu.Size = new System.Drawing.Size(799, 451);
            this.tabServiceMenu.TabIndex = 2;
            // 
            // tpgService
            // 
            this.tpgService.Controls.Add(this.lstServices);
            this.tpgService.Controls.Add(this.btnCloseRequest);
            this.tpgService.Location = new System.Drawing.Point(4, 22);
            this.tpgService.Name = "tpgService";
            this.tpgService.Padding = new System.Windows.Forms.Padding(3);
            this.tpgService.Size = new System.Drawing.Size(791, 425);
            this.tpgService.TabIndex = 0;
            this.tpgService.Text = "Services";
            this.tpgService.UseVisualStyleBackColor = true;
            // 
            // lstServices
            // 
            this.lstServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDescription,
            this.colDateCreated,
            this.colJobStarted,
            this.colDateResolved,
            this.colCallTimeStarted,
            this.colCallTimeEnded,
            this.colTechnicians,
            this.colClientName});
            this.lstServices.HideSelection = false;
            this.lstServices.Location = new System.Drawing.Point(6, 40);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(779, 379);
            this.lstServices.TabIndex = 3;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date Created";
            // 
            // colJobStarted
            // 
            this.colJobStarted.Text = "Job Started";
            // 
            // colDateResolved
            // 
            this.colDateResolved.Text = "Date Resolved";
            // 
            // colCallTimeStarted
            // 
            this.colCallTimeStarted.Text = "Call Time Started";
            this.colCallTimeStarted.Width = 119;
            // 
            // colCallTimeEnded
            // 
            this.colCallTimeEnded.Text = "Call Time Ended";
            // 
            // colTechnicians
            // 
            this.colTechnicians.Text = "Technicians Assigned";
            this.colTechnicians.Width = 143;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Client Name";
            this.colClientName.Width = 123;
            // 
            // btnCloseRequest
            // 
            this.btnCloseRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseRequest.Location = new System.Drawing.Point(669, 6);
            this.btnCloseRequest.Name = "btnCloseRequest";
            this.btnCloseRequest.Size = new System.Drawing.Size(115, 28);
            this.btnCloseRequest.TabIndex = 1;
            this.btnCloseRequest.Text = "Close Request";
            this.btnCloseRequest.UseVisualStyleBackColor = true;
            this.btnCloseRequest.Click += new System.EventHandler(this.btnCloseRequest_Click);
            // 
            // tpgTechnicians
            // 
            this.tpgTechnicians.Location = new System.Drawing.Point(4, 22);
            this.tpgTechnicians.Name = "tpgTechnicians";
            this.tpgTechnicians.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTechnicians.Size = new System.Drawing.Size(791, 425);
            this.tpgTechnicians.TabIndex = 1;
            this.tpgTechnicians.Text = "Technicians";
            this.tpgTechnicians.UseVisualStyleBackColor = true;
            // 
            // frmServiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabServiceMenu);
            this.Name = "frmServiceMenu";
            this.Text = "ServiceMenu";
            this.Load += new System.EventHandler(this.frmServiceMenu_Load);
            this.tabServiceMenu.ResumeLayout(false);
            this.tpgService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabServiceMenu;
        private System.Windows.Forms.TabPage tpgService;
        private System.Windows.Forms.TabPage tpgTechnicians;
        private System.Windows.Forms.Button btnCloseRequest;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colJobStarted;
        private System.Windows.Forms.ColumnHeader colDateResolved;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colCallTimeStarted;
        private System.Windows.Forms.ColumnHeader colCallTimeEnded;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colTechnicians;
    }
}