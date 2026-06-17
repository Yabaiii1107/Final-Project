namespace HR_Project.HR_System
{
    partial class Maintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.lblCategoriesTitle = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblCurrentCategory = new System.Windows.Forms.Label();
            this.txtCurrentCategory = new System.Windows.Forms.TextBox();
            this.lblValueName = new System.Windows.Forms.Label();
            this.txtValueInput = new System.Windows.Forms.TextBox();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvMaintenanceGrid = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConValueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(803, 39);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙  Maintenance";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelContent.Controls.Add(this.btnBack);
            this.panelContent.Controls.Add(this.panelCategories);
            this.panelContent.Controls.Add(this.panelInput);
            this.panelContent.Controls.Add(this.panelGrid);
            this.panelContent.Location = new System.Drawing.Point(0, 43);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(803, 476);
            this.panelContent.TabIndex = 2;
            // 
            // panelCategories
            // 
            this.panelCategories.BackColor = System.Drawing.Color.White;
            this.panelCategories.Controls.Add(this.lblCategoriesTitle);
            this.panelCategories.Controls.Add(this.lstCategories);
            this.panelCategories.Location = new System.Drawing.Point(16, 16);
            this.panelCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(187, 299);
            this.panelCategories.TabIndex = 0;
            // 
            // lblCategoriesTitle
            // 
            this.lblCategoriesTitle.AutoSize = true;
            this.lblCategoriesTitle.Location = new System.Drawing.Point(11, 9);
            this.lblCategoriesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriesTitle.Name = "lblCategoriesTitle";
            this.lblCategoriesTitle.Size = new System.Drawing.Size(82, 13);
            this.lblCategoriesTitle.TabIndex = 0;
            this.lblCategoriesTitle.Text = "Select Category";
            // 
            // lstCategories
            // 
            this.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Items.AddRange(new object[] {
            "Departments",
            "Positions",
            "Employment Types",
            "Requirement Types",
            "Interview Types",
            "Assessment Types"});
            this.lstCategories.Location = new System.Drawing.Point(11, 29);
            this.lstCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(165, 247);
            this.lstCategories.TabIndex = 1;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.lblInputTitle);
            this.panelInput.Controls.Add(this.lblCurrentCategory);
            this.panelInput.Controls.Add(this.txtCurrentCategory);
            this.panelInput.Controls.Add(this.lblValueName);
            this.panelInput.Controls.Add(this.txtValueInput);
            this.panelInput.Controls.Add(this.btnSaveEntry);
            this.panelInput.Controls.Add(this.btnDeleteEntry);
            this.panelInput.Location = new System.Drawing.Point(219, 25);
            this.panelInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(387, 143);
            this.panelInput.TabIndex = 1;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Location = new System.Drawing.Point(11, 9);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(96, 13);
            this.lblInputTitle.TabIndex = 0;
            this.lblInputTitle.Text = "Configuration Input";
            // 
            // lblCurrentCategory
            // 
            this.lblCurrentCategory.AutoSize = true;
            this.lblCurrentCategory.Location = new System.Drawing.Point(11, 35);
            this.lblCurrentCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentCategory.Name = "lblCurrentCategory";
            this.lblCurrentCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCurrentCategory.TabIndex = 1;
            this.lblCurrentCategory.Text = "Category:";
            // 
            // txtCurrentCategory
            // 
            this.txtCurrentCategory.Location = new System.Drawing.Point(80, 32);
            this.txtCurrentCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentCategory.Name = "txtCurrentCategory";
            this.txtCurrentCategory.ReadOnly = true;
            this.txtCurrentCategory.Size = new System.Drawing.Size(201, 20);
            this.txtCurrentCategory.TabIndex = 2;
            // 
            // lblValueName
            // 
            this.lblValueName.AutoSize = true;
            this.lblValueName.Location = new System.Drawing.Point(11, 68);
            this.lblValueName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueName.Name = "lblValueName";
            this.lblValueName.Size = new System.Drawing.Size(76, 13);
            this.lblValueName.TabIndex = 3;
            this.lblValueName.Text = "Value / Name:";
            // 
            // txtValueInput
            // 
            this.txtValueInput.Location = new System.Drawing.Point(101, 65);
            this.txtValueInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValueInput.Name = "txtValueInput";
            this.txtValueInput.Size = new System.Drawing.Size(201, 20);
            this.txtValueInput.TabIndex = 4;
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.Location = new System.Drawing.Point(80, 100);
            this.btnSaveEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(93, 23);
            this.btnSaveEntry.TabIndex = 5;
            this.btnSaveEntry.Text = "💾  Save Entry";
            this.btnSaveEntry.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(185, 100);
            this.btnDeleteEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteEntry.TabIndex = 6;
            this.btnDeleteEntry.Text = "🗑  Delete Selected";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.lblGridTitle);
            this.panelGrid.Controls.Add(this.dgvMaintenanceGrid);
            this.panelGrid.Location = new System.Drawing.Point(219, 172);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(387, 187);
            this.panelGrid.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Location = new System.Drawing.Point(11, 9);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(73, 13);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Lookup Table";
            // 
            // dgvMaintenanceGrid
            // 
            this.dgvMaintenanceGrid.AllowUserToAddRows = false;
            this.dgvMaintenanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaintenanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colConValueName});
            this.dgvMaintenanceGrid.Location = new System.Drawing.Point(11, 29);
            this.dgvMaintenanceGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMaintenanceGrid.Name = "dgvMaintenanceGrid";
            this.dgvMaintenanceGrid.ReadOnly = true;
            this.dgvMaintenanceGrid.RowHeadersVisible = false;
            this.dgvMaintenanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceGrid.Size = new System.Drawing.Size(365, 144);
            this.dgvMaintenanceGrid.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 80;
            // 
            // colConValueName
            // 
            this.colConValueName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colConValueName.HeaderText = "Value Name";
            this.colConValueName.MinimumWidth = 8;
            this.colConValueName.Name = "colConValueName";
            this.colConValueName.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 512);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelCategories.ResumeLayout(false);
            this.panelCategories.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Label lblCategoriesTitle;
        private System.Windows.Forms.ListBox lstCategories;

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblCurrentCategory;
        private System.Windows.Forms.TextBox txtCurrentCategory;
        private System.Windows.Forms.Label lblValueName;
        private System.Windows.Forms.TextBox txtValueInput;
        private System.Windows.Forms.Button btnSaveEntry;
        private System.Windows.Forms.Button btnDeleteEntry;

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvMaintenanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConValueName;
        private System.Windows.Forms.Button btnBack;
    }
}
