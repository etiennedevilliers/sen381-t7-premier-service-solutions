
namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    partial class frmViewBusinessContract
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
            this.lstViewBusi = new System.Windows.Forms.ListView();
            this.colDescript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbBusContact = new System.Windows.Forms.TextBox();
            this.tbBusiName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstvEquipment = new System.Windows.Forms.ListView();
            this.colSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colManufact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewBusi
            // 
            this.lstViewBusi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescript,
            this.colStartDate,
            this.colEndDate});
            this.lstViewBusi.HideSelection = false;
            this.lstViewBusi.Location = new System.Drawing.Point(132, 153);
            this.lstViewBusi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewBusi.Name = "lstViewBusi";
            this.lstViewBusi.Size = new System.Drawing.Size(936, 396);
            this.lstViewBusi.TabIndex = 1;
            this.lstViewBusi.UseCompatibleStateImageBehavior = false;
            this.lstViewBusi.View = System.Windows.Forms.View.Details;
            // 
            // colDescript
            // 
            this.colDescript.Text = "Service Description";
            this.colDescript.Width = 170;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 89;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 101;
            // 
            // tbBusContact
            // 
            this.tbBusContact.Location = new System.Drawing.Point(132, 89);
            this.tbBusContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusContact.Name = "tbBusContact";
            this.tbBusContact.Size = new System.Drawing.Size(229, 31);
            this.tbBusContact.TabIndex = 2;
            // 
            // tbBusiName
            // 
            this.tbBusiName.Location = new System.Drawing.Point(418, 89);
            this.tbBusiName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusiName.Name = "tbBusiName";
            this.tbBusiName.Size = new System.Drawing.Size(242, 31);
            this.tbBusiName.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(932, 69);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(129, 75);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(957, 588);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 36);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstvEquipment
            // 
            this.lstvEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSerial,
            this.colManufact,
            this.colCat});
            this.lstvEquipment.HideSelection = false;
            this.lstvEquipment.Location = new System.Drawing.Point(12, 722);
            this.lstvEquipment.Name = "lstvEquipment";
            this.lstvEquipment.Size = new System.Drawing.Size(1106, 364);
            this.lstvEquipment.TabIndex = 7;
            this.lstvEquipment.UseCompatibleStateImageBehavior = false;
            this.lstvEquipment.View = System.Windows.Forms.View.Details;
            // 
            // colSerial
            // 
            this.colSerial.Text = "Serial Number";
            // 
            // colManufact
            // 
            this.colManufact.Text = "Manufacturer";
            // 
            // colCat
            // 
            this.colCat.Text = "Category";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(888, 668);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(230, 48);
            this.btnAddEquipment.TabIndex = 8;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(652, 668);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(230, 48);
            this.btnRemoveEquipment.TabIndex = 9;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // frmViewBusinessContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 1098);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.lstvEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbBusiName);
            this.Controls.Add(this.tbBusContact);
            this.Controls.Add(this.lstViewBusi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmViewBusinessContract";
            this.Text = "frmViewBusinessContract";
            this.Load += new System.EventHandler(this.frmViewBusinessContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewBusi;
        private System.Windows.Forms.TextBox tbBusContact;
        private System.Windows.Forms.TextBox tbBusiName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ColumnHeader colDescript;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lstvEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.ColumnHeader colSerial;
        private System.Windows.Forms.ColumnHeader colManufact;
        private System.Windows.Forms.ColumnHeader colCat;
    }
}