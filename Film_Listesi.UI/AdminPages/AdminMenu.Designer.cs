namespace Film_Listesi.UI.AdminPages
{
    partial class AdminMenu
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
            this.grpAdminMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminMenu
            // 
            this.grpAdminMenu.Controls.Add(this.btnExit);
            this.grpAdminMenu.Controls.Add(this.btnFilm);
            this.grpAdminMenu.Controls.Add(this.label3);
            this.grpAdminMenu.Controls.Add(this.btnCategory);
            this.grpAdminMenu.Controls.Add(this.label2);
            this.grpAdminMenu.Controls.Add(this.btnUser);
            this.grpAdminMenu.Controls.Add(this.label1);
            this.grpAdminMenu.Location = new System.Drawing.Point(13, 13);
            this.grpAdminMenu.Name = "grpAdminMenu";
            this.grpAdminMenu.Size = new System.Drawing.Size(315, 203);
            this.grpAdminMenu.TabIndex = 0;
            this.grpAdminMenu.TabStop = false;
            this.grpAdminMenu.Text = "Admin Menu";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(44, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(204, 100);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(75, 23);
            this.btnFilm.TabIndex = 5;
            this.btnFilm.Text = "Film";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Click for \"Film\" operations.";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(204, 65);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click for \"Category\" operations.";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(204, 31);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click for \"User\" operations.";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 232);
            this.Controls.Add(this.grpAdminMenu);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.grpAdminMenu.ResumeLayout(false);
            this.grpAdminMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminMenu;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}