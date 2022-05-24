namespace Industrial_Informatics_Project.Windows.Admin_Windows
{
    partial class User_Overview
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
            this.components = new System.ComponentModel.Container();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iI_ProjectDataSet = new Industrial_Informatics_Project.II_ProjectDataSet();
            this.usersTableAdapter = new Industrial_Informatics_Project.II_ProjectDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AutoGenerateColumns = false;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.isAdminDataGridViewTextBoxColumn});
            this.usersGridView.DataSource = this.usersBindingSource;
            this.usersGridView.Location = new System.Drawing.Point(12, 12);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(553, 150);
            this.usersGridView.TabIndex = 2;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // isAdminDataGridViewTextBoxColumn
            // 
            this.isAdminDataGridViewTextBoxColumn.DataPropertyName = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.HeaderText = "isAdmin";
            this.isAdminDataGridViewTextBoxColumn.Name = "isAdminDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.iI_ProjectDataSet;
            // 
            // iI_ProjectDataSet
            // 
            this.iI_ProjectDataSet.DataSetName = "II_ProjectDataSet";
            this.iI_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // User_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 194);
            this.Controls.Add(this.usersGridView);
            this.Name = "User_Overview";
            this.Text = "User_Overview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onUserOverviewClosed);
            this.Load += new System.EventHandler(this.User_Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView usersGridView;
        private II_ProjectDataSet iI_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private II_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdminDataGridViewTextBoxColumn;
    }
}