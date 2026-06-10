namespace MaintenanceModuleForms
{
    partial class Maintenance
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.grpInputEngine = new System.Windows.Forms.GroupBox();
            this.lblCurrentCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentCategory = new System.Windows.Forms.TextBox();
            this.txtValueInput = new System.Windows.Forms.TextBox();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.grpTableViewer = new System.Windows.Forms.GroupBox();
            this.dgvMaintenanceGrid = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConValueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMenu.SuspendLayout();
            this.grpInputEngine.SuspendLayout();
            this.grpTableViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.lstCategories);
            this.grpMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(47, 157);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(402, 344);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "📂 Select Dictionary Type";
            // 
            // lstCategories
            // 
            this.lstCategories.AccessibleDescription = "lstCategories";
            this.lstCategories.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 21;
            this.lstCategories.Items.AddRange(new object[] {
            "Departments",
            "",
            "Positions",
            "",
            "Employment Types",
            "",
            "Requirement Types",
            "",
            "Interview Types",
            "",
            "Assessment Types"});
            this.lstCategories.Location = new System.Drawing.Point(6, 46);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(359, 256);
            this.lstCategories.TabIndex = 0;
            // 
            // grpInputEngine
            // 
            this.grpInputEngine.BackColor = System.Drawing.Color.Transparent;
            this.grpInputEngine.Controls.Add(this.btnDeleteEntry);
            this.grpInputEngine.Controls.Add(this.btnSaveEntry);
            this.grpInputEngine.Controls.Add(this.txtValueInput);
            this.grpInputEngine.Controls.Add(this.txtCurrentCategory);
            this.grpInputEngine.Controls.Add(this.label1);
            this.grpInputEngine.Controls.Add(this.lblCurrentCategory);
            this.grpInputEngine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputEngine.Location = new System.Drawing.Point(494, 157);
            this.grpInputEngine.Name = "grpInputEngine";
            this.grpInputEngine.Size = new System.Drawing.Size(682, 344);
            this.grpInputEngine.TabIndex = 1;
            this.grpInputEngine.TabStop = false;
            this.grpInputEngine.Text = "📝 Contextual Configuration & Input Box";
            // 
            // lblCurrentCategory
            // 
            this.lblCurrentCategory.AutoSize = true;
            this.lblCurrentCategory.Location = new System.Drawing.Point(26, 46);
            this.lblCurrentCategory.Name = "lblCurrentCategory";
            this.lblCurrentCategory.Size = new System.Drawing.Size(151, 25);
            this.lblCurrentCategory.TabIndex = 0;
            this.lblCurrentCategory.Text = "Select Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value / Name:";
            // 
            // txtCurrentCategory
            // 
            this.txtCurrentCategory.Location = new System.Drawing.Point(183, 46);
            this.txtCurrentCategory.Name = "txtCurrentCategory";
            this.txtCurrentCategory.Size = new System.Drawing.Size(352, 31);
            this.txtCurrentCategory.TabIndex = 2;
            // 
            // txtValueInput
            // 
            this.txtValueInput.Location = new System.Drawing.Point(165, 120);
            this.txtValueInput.Name = "txtValueInput";
            this.txtValueInput.Size = new System.Drawing.Size(352, 31);
            this.txtValueInput.TabIndex = 3;
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEntry.Location = new System.Drawing.Point(65, 220);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(164, 33);
            this.btnSaveEntry.TabIndex = 4;
            this.btnSaveEntry.Text = "💾 Save Entry";
            this.btnSaveEntry.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Location = new System.Drawing.Point(340, 220);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(195, 33);
            this.btnDeleteEntry.TabIndex = 5;
            this.btnDeleteEntry.Text = "❌ Delete Selected";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            // 
            // grpTableViewer
            // 
            this.grpTableViewer.BackColor = System.Drawing.Color.Transparent;
            this.grpTableViewer.Controls.Add(this.dgvMaintenanceGrid);
            this.grpTableViewer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTableViewer.Location = new System.Drawing.Point(494, 528);
            this.grpTableViewer.Name = "grpTableViewer";
            this.grpTableViewer.Size = new System.Drawing.Size(682, 233);
            this.grpTableViewer.TabIndex = 2;
            this.grpTableViewer.TabStop = false;
            this.grpTableViewer.Text = "📋 Active Lookup Table Logs";
            // 
            // dgvMaintenanceGrid
            // 
            this.dgvMaintenanceGrid.AllowUserToAddRows = false;
            this.dgvMaintenanceGrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvMaintenanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colConValueName});
            this.dgvMaintenanceGrid.Location = new System.Drawing.Point(31, 50);
            this.dgvMaintenanceGrid.Name = "dgvMaintenanceGrid";
            this.dgvMaintenanceGrid.ReadOnly = true;
            this.dgvMaintenanceGrid.RowHeadersWidth = 62;
            this.dgvMaintenanceGrid.RowTemplate.Height = 28;
            this.dgvMaintenanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceGrid.Size = new System.Drawing.Size(357, 163);
            this.dgvMaintenanceGrid.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 150;
            // 
            // colConValueName
            // 
            this.colConValueName.HeaderText = "Configuration Value Name";
            this.colConValueName.MinimumWidth = 8;
            this.colConValueName.Name = "colConValueName";
            this.colConValueName.ReadOnly = true;
            this.colConValueName.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaintenanceModuleForms.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1205, 799);
            this.Controls.Add(this.grpTableViewer);
            this.Controls.Add(this.grpInputEngine);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMenu.ResumeLayout(false);
            this.grpInputEngine.ResumeLayout(false);
            this.grpInputEngine.PerformLayout();
            this.grpTableViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.GroupBox grpInputEngine;
        private System.Windows.Forms.TextBox txtValueInput;
        private System.Windows.Forms.TextBox txtCurrentCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentCategory;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnSaveEntry;
        private System.Windows.Forms.GroupBox grpTableViewer;
        private System.Windows.Forms.DataGridView dgvMaintenanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConValueName;
    }
}

