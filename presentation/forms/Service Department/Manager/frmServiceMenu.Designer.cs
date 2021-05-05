
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
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListView();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJobStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateResolved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCallTimeStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCallTimeEnded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTechnicians = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReqStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseRequest = new System.Windows.Forms.Button();
            this.tpgTechnicians = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstTechnicians = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSkills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAssignedID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabServiceMenu.SuspendLayout();
            this.tpgService.SuspendLayout();
            this.tpgTechnicians.SuspendLayout();
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
            this.tpgService.Controls.Add(this.btnSchedule);
            this.tpgService.Controls.Add(this.lstRequests);
            this.tpgService.Controls.Add(this.btnCloseRequest);
            this.tpgService.Location = new System.Drawing.Point(4, 22);
            this.tpgService.Name = "tpgService";
            this.tpgService.Padding = new System.Windows.Forms.Padding(3);
            this.tpgService.Size = new System.Drawing.Size(791, 425);
            this.tpgService.TabIndex = 0;
            this.tpgService.Text = "Requests";
            this.tpgService.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Location = new System.Drawing.Point(518, 6);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(145, 28);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule Technicians";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lstRequests
            // 
            this.lstRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescription,
            this.colDateCreated,
            this.colJobStarted,
            this.colDateResolved,
            this.colCallTimeStarted,
            this.colCallTimeEnded,
            this.colTechnicians,
            this.colClientName,
            this.colReqStatus});
            this.lstRequests.HideSelection = false;
            this.lstRequests.Location = new System.Drawing.Point(6, 40);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(779, 379);
            this.lstRequests.TabIndex = 3;
            this.lstRequests.UseCompatibleStateImageBehavior = false;
            this.lstRequests.View = System.Windows.Forms.View.Details;
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
            // colReqStatus
            // 
            this.colReqStatus.Text = "Status";
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
            this.tpgTechnicians.Controls.Add(this.btnCreate);
            this.tpgTechnicians.Controls.Add(this.btnEdit);
            this.tpgTechnicians.Controls.Add(this.lstTechnicians);
            this.tpgTechnicians.Controls.Add(this.btnRemove);
            this.tpgTechnicians.Location = new System.Drawing.Point(4, 22);
            this.tpgTechnicians.Name = "tpgTechnicians";
            this.tpgTechnicians.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTechnicians.Size = new System.Drawing.Size(791, 425);
            this.tpgTechnicians.TabIndex = 1;
            this.tpgTechnicians.Text = "Technicians";
            this.tpgTechnicians.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(427, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 28);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(548, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstTechnicians
            // 
            this.lstTechnicians.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTechnicians.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colContactNum,
            this.colStatus,
            this.colSkills,
            this.colAssignedID});
            this.lstTechnicians.HideSelection = false;
            this.lstTechnicians.Location = new System.Drawing.Point(6, 40);
            this.lstTechnicians.Name = "lstTechnicians";
            this.lstTechnicians.Size = new System.Drawing.Size(779, 379);
            this.lstTechnicians.TabIndex = 5;
            this.lstTechnicians.UseCompatibleStateImageBehavior = false;
            this.lstTechnicians.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colContactNum
            // 
            this.colContactNum.Text = "Contact Number";
            this.colContactNum.Width = 108;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colSkills
            // 
            this.colSkills.Text = "Skills";
            this.colSkills.Width = 139;
            // 
            // colAssignedID
            // 
            this.colAssignedID.Text = "Assigned Request ID";
            this.colAssignedID.Width = 114;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(669, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.tpgTechnicians.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabServiceMenu;
        private System.Windows.Forms.TabPage tpgService;
        private System.Windows.Forms.TabPage tpgTechnicians;
        private System.Windows.Forms.Button btnCloseRequest;
        private System.Windows.Forms.ListView lstRequests;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colJobStarted;
        private System.Windows.Forms.ColumnHeader colDateResolved;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colCallTimeStarted;
        private System.Windows.Forms.ColumnHeader colCallTimeEnded;
        private System.Windows.Forms.ColumnHeader colTechnicians;
        private System.Windows.Forms.ListView lstTechnicians;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colContactNum;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colSkills;
        private System.Windows.Forms.ColumnHeader colAssignedID;
        private System.Windows.Forms.ColumnHeader colReqStatus;
        private System.Windows.Forms.Button btnSchedule;
    }
}