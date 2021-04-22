
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
            this.tpgTechnicians = new System.Windows.Forms.TabPage();
            this.btnCloseRequests = new System.Windows.Forms.Button();
            this.lstServices = new System.Windows.Forms.ListView();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabServiceMenu.SuspendLayout();
            this.tpgService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabServiceMenu
            // 
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
            this.tpgService.Controls.Add(this.btnCloseRequests);
            this.tpgService.Location = new System.Drawing.Point(4, 22);
            this.tpgService.Name = "tpgService";
            this.tpgService.Padding = new System.Windows.Forms.Padding(3);
            this.tpgService.Size = new System.Drawing.Size(791, 425);
            this.tpgService.TabIndex = 0;
            this.tpgService.Text = "Services";
            this.tpgService.UseVisualStyleBackColor = true;
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
            // btnCloseRequests
            // 
            this.btnCloseRequests.Location = new System.Drawing.Point(669, 6);
            this.btnCloseRequests.Name = "btnCloseRequests";
            this.btnCloseRequests.Size = new System.Drawing.Size(115, 28);
            this.btnCloseRequests.TabIndex = 1;
            this.btnCloseRequests.Text = "Close Requests";
            this.btnCloseRequests.UseVisualStyleBackColor = true;
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescription,
            this.colDateCreated});
            this.lstServices.HideSelection = false;
            this.lstServices.Location = new System.Drawing.Point(6, 40);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(779, 379);
            this.lstServices.TabIndex = 3;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.View = System.Windows.Forms.View.Details;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date Created";
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
        private System.Windows.Forms.Button btnCloseRequests;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDateCreated;
    }
}