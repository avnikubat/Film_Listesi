namespace Film_Listesi.UI.AdminPages
{
    partial class AdminUser
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
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.btnAddUserCreate = new System.Windows.Forms.Button();
            this.cmbAddUserRole = new System.Windows.Forms.ComboBox();
            this.txtAddUserPassword = new System.Windows.Forms.TextBox();
            this.txtAddUserUserName = new System.Windows.Forms.TextBox();
            this.txtAddUserLastName = new System.Windows.Forms.TextBox();
            this.txtAddUserFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpListOfUser = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdateUser = new System.Windows.Forms.GroupBox();
            this.btnUpdateUserUpdate = new System.Windows.Forms.Button();
            this.btnUpdateUserFindById = new System.Windows.Forms.Button();
            this.txtUpdateUserFindById = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUpdateUserRole = new System.Windows.Forms.ComboBox();
            this.txtUpdateUserPassword = new System.Windows.Forms.TextBox();
            this.txtUpdateUserUserName = new System.Windows.Forms.TextBox();
            this.txtUpdateUserLAstName = new System.Windows.Forms.TextBox();
            this.txtUpdateUserFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.btnDeleteUserDelete = new System.Windows.Forms.Button();
            this.txtDeleteUserId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpFindByRole = new System.Windows.Forms.GroupBox();
            this.cmbFindByRoleRole = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpAddUser.SuspendLayout();
            this.grpListOfUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateUser.SuspendLayout();
            this.grpDeleteUser.SuspendLayout();
            this.grpFindByRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnAddUserCreate);
            this.grpAddUser.Controls.Add(this.cmbAddUserRole);
            this.grpAddUser.Controls.Add(this.txtAddUserPassword);
            this.grpAddUser.Controls.Add(this.txtAddUserUserName);
            this.grpAddUser.Controls.Add(this.txtAddUserLastName);
            this.grpAddUser.Controls.Add(this.txtAddUserFirstName);
            this.grpAddUser.Controls.Add(this.label5);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Location = new System.Drawing.Point(13, 13);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(242, 237);
            this.grpAddUser.TabIndex = 0;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // btnAddUserCreate
            // 
            this.btnAddUserCreate.Location = new System.Drawing.Point(26, 196);
            this.btnAddUserCreate.Name = "btnAddUserCreate";
            this.btnAddUserCreate.Size = new System.Drawing.Size(185, 23);
            this.btnAddUserCreate.TabIndex = 10;
            this.btnAddUserCreate.Text = "Create";
            this.btnAddUserCreate.UseVisualStyleBackColor = true;
            this.btnAddUserCreate.Click += new System.EventHandler(this.btnAddUserCreate_Click);
            // 
            // cmbAddUserRole
            // 
            this.cmbAddUserRole.FormattingEnabled = true;
            this.cmbAddUserRole.Location = new System.Drawing.Point(90, 164);
            this.cmbAddUserRole.Name = "cmbAddUserRole";
            this.cmbAddUserRole.Size = new System.Drawing.Size(121, 21);
            this.cmbAddUserRole.TabIndex = 9;
            // 
            // txtAddUserPassword
            // 
            this.txtAddUserPassword.Location = new System.Drawing.Point(90, 128);
            this.txtAddUserPassword.Name = "txtAddUserPassword";
            this.txtAddUserPassword.PasswordChar = '*';
            this.txtAddUserPassword.Size = new System.Drawing.Size(121, 20);
            this.txtAddUserPassword.TabIndex = 8;
            // 
            // txtAddUserUserName
            // 
            this.txtAddUserUserName.Location = new System.Drawing.Point(90, 97);
            this.txtAddUserUserName.Name = "txtAddUserUserName";
            this.txtAddUserUserName.Size = new System.Drawing.Size(121, 20);
            this.txtAddUserUserName.TabIndex = 7;
            // 
            // txtAddUserLastName
            // 
            this.txtAddUserLastName.Location = new System.Drawing.Point(90, 67);
            this.txtAddUserLastName.Name = "txtAddUserLastName";
            this.txtAddUserLastName.Size = new System.Drawing.Size(121, 20);
            this.txtAddUserLastName.TabIndex = 6;
            // 
            // txtAddUserFirstName
            // 
            this.txtAddUserFirstName.Location = new System.Drawing.Point(90, 36);
            this.txtAddUserFirstName.Name = "txtAddUserFirstName";
            this.txtAddUserFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtAddUserFirstName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // grpListOfUser
            // 
            this.grpListOfUser.Controls.Add(this.dataGridView1);
            this.grpListOfUser.Location = new System.Drawing.Point(13, 257);
            this.grpListOfUser.Name = "grpListOfUser";
            this.grpListOfUser.Size = new System.Drawing.Size(775, 231);
            this.grpListOfUser.TabIndex = 1;
            this.grpListOfUser.TabStop = false;
            this.grpListOfUser.Text = "List Of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUpdateUser
            // 
            this.grpUpdateUser.Controls.Add(this.btnUpdateUserUpdate);
            this.grpUpdateUser.Controls.Add(this.btnUpdateUserFindById);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUserFindById);
            this.grpUpdateUser.Controls.Add(this.label11);
            this.grpUpdateUser.Controls.Add(this.cmbUpdateUserRole);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUserPassword);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUserUserName);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUserLAstName);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUserFirstName);
            this.grpUpdateUser.Controls.Add(this.label6);
            this.grpUpdateUser.Controls.Add(this.label7);
            this.grpUpdateUser.Controls.Add(this.label8);
            this.grpUpdateUser.Controls.Add(this.label9);
            this.grpUpdateUser.Controls.Add(this.label10);
            this.grpUpdateUser.Location = new System.Drawing.Point(261, 13);
            this.grpUpdateUser.Name = "grpUpdateUser";
            this.grpUpdateUser.Size = new System.Drawing.Size(237, 237);
            this.grpUpdateUser.TabIndex = 2;
            this.grpUpdateUser.TabStop = false;
            this.grpUpdateUser.Text = "Update User";
            // 
            // btnUpdateUserUpdate
            // 
            this.btnUpdateUserUpdate.Location = new System.Drawing.Point(27, 207);
            this.btnUpdateUserUpdate.Name = "btnUpdateUserUpdate";
            this.btnUpdateUserUpdate.Size = new System.Drawing.Size(185, 23);
            this.btnUpdateUserUpdate.TabIndex = 23;
            this.btnUpdateUserUpdate.Text = "Update";
            this.btnUpdateUserUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateUserUpdate.Click += new System.EventHandler(this.btnUpdateUserUpdate_Click);
            // 
            // btnUpdateUserFindById
            // 
            this.btnUpdateUserFindById.Location = new System.Drawing.Point(137, 24);
            this.btnUpdateUserFindById.Name = "btnUpdateUserFindById";
            this.btnUpdateUserFindById.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUserFindById.TabIndex = 22;
            this.btnUpdateUserFindById.Text = "Find By Id";
            this.btnUpdateUserFindById.UseVisualStyleBackColor = true;
            this.btnUpdateUserFindById.Click += new System.EventHandler(this.btnUpdateUserFindById_Click);
            // 
            // txtUpdateUserFindById
            // 
            this.txtUpdateUserFindById.Location = new System.Drawing.Point(47, 26);
            this.txtUpdateUserFindById.Name = "txtUpdateUserFindById";
            this.txtUpdateUserFindById.Size = new System.Drawing.Size(82, 20);
            this.txtUpdateUserFindById.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Id";
            // 
            // cmbUpdateUserRole
            // 
            this.cmbUpdateUserRole.FormattingEnabled = true;
            this.cmbUpdateUserRole.Location = new System.Drawing.Point(91, 180);
            this.cmbUpdateUserRole.Name = "cmbUpdateUserRole";
            this.cmbUpdateUserRole.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateUserRole.TabIndex = 19;
            // 
            // txtUpdateUserPassword
            // 
            this.txtUpdateUserPassword.Location = new System.Drawing.Point(91, 144);
            this.txtUpdateUserPassword.Name = "txtUpdateUserPassword";
            this.txtUpdateUserPassword.PasswordChar = '*';
            this.txtUpdateUserPassword.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUserPassword.TabIndex = 18;
            // 
            // txtUpdateUserUserName
            // 
            this.txtUpdateUserUserName.Location = new System.Drawing.Point(91, 113);
            this.txtUpdateUserUserName.Name = "txtUpdateUserUserName";
            this.txtUpdateUserUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUserUserName.TabIndex = 17;
            // 
            // txtUpdateUserLAstName
            // 
            this.txtUpdateUserLAstName.Location = new System.Drawing.Point(91, 83);
            this.txtUpdateUserLAstName.Name = "txtUpdateUserLAstName";
            this.txtUpdateUserLAstName.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUserLAstName.TabIndex = 16;
            // 
            // txtUpdateUserFirstName
            // 
            this.txtUpdateUserFirstName.Location = new System.Drawing.Point(91, 52);
            this.txtUpdateUserFirstName.Name = "txtUpdateUserFirstName";
            this.txtUpdateUserFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUserFirstName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "User Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "First Name";
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.btnDeleteUserDelete);
            this.grpDeleteUser.Controls.Add(this.txtDeleteUserId);
            this.grpDeleteUser.Controls.Add(this.label12);
            this.grpDeleteUser.Location = new System.Drawing.Point(505, 13);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(200, 68);
            this.grpDeleteUser.TabIndex = 3;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Delete User";
            // 
            // btnDeleteUserDelete
            // 
            this.btnDeleteUserDelete.Location = new System.Drawing.Point(118, 24);
            this.btnDeleteUserDelete.Name = "btnDeleteUserDelete";
            this.btnDeleteUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUserDelete.TabIndex = 25;
            this.btnDeleteUserDelete.Text = "Delete";
            this.btnDeleteUserDelete.UseVisualStyleBackColor = true;
            this.btnDeleteUserDelete.Click += new System.EventHandler(this.btnDeleteUserDelete_Click);
            // 
            // txtDeleteUserId
            // 
            this.txtDeleteUserId.Location = new System.Drawing.Point(28, 26);
            this.txtDeleteUserId.Name = "txtDeleteUserId";
            this.txtDeleteUserId.Size = new System.Drawing.Size(82, 20);
            this.txtDeleteUserId.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Id";
            // 
            // grpFindByRole
            // 
            this.grpFindByRole.Controls.Add(this.cmbFindByRoleRole);
            this.grpFindByRole.Controls.Add(this.label13);
            this.grpFindByRole.Location = new System.Drawing.Point(505, 83);
            this.grpFindByRole.Name = "grpFindByRole";
            this.grpFindByRole.Size = new System.Drawing.Size(200, 59);
            this.grpFindByRole.TabIndex = 4;
            this.grpFindByRole.TabStop = false;
            this.grpFindByRole.Text = "Find By Role";
            // 
            // cmbFindByRoleRole
            // 
            this.cmbFindByRoleRole.FormattingEnabled = true;
            this.cmbFindByRoleRole.Location = new System.Drawing.Point(72, 22);
            this.cmbFindByRoleRole.Name = "cmbFindByRoleRole";
            this.cmbFindByRoleRole.Size = new System.Drawing.Size(121, 21);
            this.cmbFindByRoleRole.TabIndex = 21;
            this.cmbFindByRoleRole.SelectedIndexChanged += new System.EventHandler(this.cmbFindByRoleRole_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Choose Role";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(507, 150);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(198, 43);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Get Back Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpFindByRole);
            this.Controls.Add(this.grpDeleteUser);
            this.Controls.Add(this.grpUpdateUser);
            this.Controls.Add(this.grpListOfUser);
            this.Controls.Add(this.grpAddUser);
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.grpListOfUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateUser.ResumeLayout(false);
            this.grpUpdateUser.PerformLayout();
            this.grpDeleteUser.ResumeLayout(false);
            this.grpDeleteUser.PerformLayout();
            this.grpFindByRole.ResumeLayout(false);
            this.grpFindByRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnAddUserCreate;
        private System.Windows.Forms.ComboBox cmbAddUserRole;
        private System.Windows.Forms.TextBox txtAddUserPassword;
        private System.Windows.Forms.TextBox txtAddUserUserName;
        private System.Windows.Forms.TextBox txtAddUserLastName;
        private System.Windows.Forms.TextBox txtAddUserFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpListOfUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdateUser;
        private System.Windows.Forms.Button btnUpdateUserUpdate;
        private System.Windows.Forms.Button btnUpdateUserFindById;
        private System.Windows.Forms.TextBox txtUpdateUserFindById;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUpdateUserRole;
        private System.Windows.Forms.TextBox txtUpdateUserPassword;
        private System.Windows.Forms.TextBox txtUpdateUserUserName;
        private System.Windows.Forms.TextBox txtUpdateUserLAstName;
        private System.Windows.Forms.TextBox txtUpdateUserFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.Button btnDeleteUserDelete;
        private System.Windows.Forms.TextBox txtDeleteUserId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpFindByRole;
        private System.Windows.Forms.ComboBox cmbFindByRoleRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMenu;
    }
}