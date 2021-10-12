namespace MsiSneakAttack
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msiInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msiInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.packageNameDataGridViewTextBoxColumn,
            this.installDateDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.installLocationDataGridViewTextBoxColumn,
            this.installSourceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.msiInfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(2203, 1037);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn.Width = 247;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 255;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionDataGridViewTextBoxColumn.Width = 170;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayNameDataGridViewTextBoxColumn.Width = 247;
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            this.packageNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            this.packageNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            this.packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageNameDataGridViewTextBoxColumn.Width = 260;
            // 
            // installDateDataGridViewTextBoxColumn
            // 
            this.installDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.installDateDataGridViewTextBoxColumn.DataPropertyName = "InstallDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.installDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.installDateDataGridViewTextBoxColumn.HeaderText = "InstallDate";
            this.installDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.installDateDataGridViewTextBoxColumn.Name = "installDateDataGridViewTextBoxColumn";
            this.installDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.installDateDataGridViewTextBoxColumn.Width = 211;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDataGridViewTextBoxColumn.Width = 202;
            // 
            // installLocationDataGridViewTextBoxColumn
            // 
            this.installLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.installLocationDataGridViewTextBoxColumn.DataPropertyName = "InstallLocation";
            this.installLocationDataGridViewTextBoxColumn.HeaderText = "InstallLocation";
            this.installLocationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.installLocationDataGridViewTextBoxColumn.Name = "installLocationDataGridViewTextBoxColumn";
            this.installLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.installLocationDataGridViewTextBoxColumn.Width = 262;
            // 
            // installSourceDataGridViewTextBoxColumn
            // 
            this.installSourceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.installSourceDataGridViewTextBoxColumn.DataPropertyName = "InstallSource";
            this.installSourceDataGridViewTextBoxColumn.HeaderText = "InstallSource";
            this.installSourceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.installSourceDataGridViewTextBoxColumn.Name = "installSourceDataGridViewTextBoxColumn";
            this.installSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.installSourceDataGridViewTextBoxColumn.Width = 240;
            // 
            // msiInfoBindingSource
            // 
            this.msiInfoBindingSource.DataSource = typeof(MsiSneakAttack.MsiInfo);
            this.msiInfoBindingSource.Sort = "ProductName,InstallDate";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2203, 1037);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "MSI Sneak Attack - Remove those Pesky installs!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msiInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource msiInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installSourceDataGridViewTextBoxColumn;
    }
}
