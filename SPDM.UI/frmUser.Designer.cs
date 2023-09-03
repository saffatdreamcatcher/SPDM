namespace SPDM.UI
{
    partial class frmUser
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLockOutEnabled = new System.Windows.Forms.Label();
            this.chkLockOutEnabled = new System.Windows.Forms.CheckBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.gvUser = new System.Windows.Forms.DataGridView();
            this.resetbtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockoutEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockoutEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accessFailedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 88);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(262, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(262, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(43, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(37, 94);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 16);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblLockOutEnabled
            // 
            this.lblLockOutEnabled.AutoSize = true;
            this.lblLockOutEnabled.Location = new System.Drawing.Point(596, 90);
            this.lblLockOutEnabled.Name = "lblLockOutEnabled";
            this.lblLockOutEnabled.Size = new System.Drawing.Size(107, 16);
            this.lblLockOutEnabled.TabIndex = 7;
            this.lblLockOutEnabled.Text = "LockOutEnabled";
            this.lblLockOutEnabled.Visible = false;
            // 
            // chkLockOutEnabled
            // 
            this.chkLockOutEnabled.AutoSize = true;
            this.chkLockOutEnabled.Location = new System.Drawing.Point(749, 88);
            this.chkLockOutEnabled.Name = "chkLockOutEnabled";
            this.chkLockOutEnabled.Size = new System.Drawing.Size(18, 17);
            this.chkLockOutEnabled.TabIndex = 8;
            this.chkLockOutEnabled.UseVisualStyleBackColor = true;
            this.chkLockOutEnabled.Visible = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(649, 129);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(54, 16);
            this.lblIsActive.TabIndex = 11;
            this.lblIsActive.Text = "IsActive";
            this.lblIsActive.Visible = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(749, 127);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(18, 17);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.Visible = false;
            // 
            // gvUser
            // 
            this.gvUser.AutoGenerateColumns = false;
            this.gvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.lockoutEndDateDataGridViewTextBoxColumn,
            this.lockoutEnabledDataGridViewCheckBoxColumn,
            this.accessFailedCountDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.isNewDataGridViewCheckBoxColumn,
            this.Edit,
            this.Delete});
            this.gvUser.DataSource = this.userBindingSource;
            this.gvUser.Location = new System.Drawing.Point(152, 260);
            this.gvUser.Name = "gvUser";
            this.gvUser.RowHeadersWidth = 51;
            this.gvUser.RowTemplate.Height = 24;
            this.gvUser.Size = new System.Drawing.Size(1338, 404);
            this.gvUser.TabIndex = 13;
            this.gvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUser_CellClick);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(263, 190);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(91, 32);
            this.resetbtn.TabIndex = 27;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 190);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 32);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epUser
            // 
            this.epUser.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1488, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = ":";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = ":";
            this.label3.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "ResetPassword";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "InActive";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 80;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Visible = false;
            this.createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // lockoutEndDateDataGridViewTextBoxColumn
            // 
            this.lockoutEndDateDataGridViewTextBoxColumn.DataPropertyName = "LockoutEndDate";
            this.lockoutEndDateDataGridViewTextBoxColumn.HeaderText = "LockoutEndDate";
            this.lockoutEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lockoutEndDateDataGridViewTextBoxColumn.Name = "lockoutEndDateDataGridViewTextBoxColumn";
            this.lockoutEndDateDataGridViewTextBoxColumn.Visible = false;
            this.lockoutEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lockoutEnabledDataGridViewCheckBoxColumn
            // 
            this.lockoutEnabledDataGridViewCheckBoxColumn.DataPropertyName = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.HeaderText = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lockoutEnabledDataGridViewCheckBoxColumn.Name = "lockoutEnabledDataGridViewCheckBoxColumn";
            this.lockoutEnabledDataGridViewCheckBoxColumn.Visible = false;
            this.lockoutEnabledDataGridViewCheckBoxColumn.Width = 125;
            // 
            // accessFailedCountDataGridViewTextBoxColumn
            // 
            this.accessFailedCountDataGridViewTextBoxColumn.DataPropertyName = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.HeaderText = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accessFailedCountDataGridViewTextBoxColumn.Name = "accessFailedCountDataGridViewTextBoxColumn";
            this.accessFailedCountDataGridViewTextBoxColumn.Visible = false;
            this.accessFailedCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isNewDataGridViewCheckBoxColumn
            // 
            this.isNewDataGridViewCheckBoxColumn.DataPropertyName = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.HeaderText = "IsNew";
            this.isNewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isNewDataGridViewCheckBoxColumn.Name = "isNewDataGridViewCheckBoxColumn";
            this.isNewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isNewDataGridViewCheckBoxColumn.Visible = false;
            this.isNewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SPDM.DLL.Entities.User);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1521, 676);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvUser);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.chkLockOutEnabled);
            this.Controls.Add(this.lblLockOutEnabled);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLockOutEnabled;
        private System.Windows.Forms.CheckBox chkLockOutEnabled;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.DataGridView gvUser;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockoutEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockoutEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessFailedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}