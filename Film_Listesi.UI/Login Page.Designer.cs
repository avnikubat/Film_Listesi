namespace Film_Listesi.UI
{
    partial class Login_Page
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
            this.grpLogPage = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginPagePassword = new System.Windows.Forms.TextBox();
            this.txtLoginPageUserName = new System.Windows.Forms.TextBox();
            this.grpLogPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogPage
            // 
            this.grpLogPage.Controls.Add(this.btnSignUp);
            this.grpLogPage.Controls.Add(this.btnSignIn);
            this.grpLogPage.Controls.Add(this.label2);
            this.grpLogPage.Controls.Add(this.label1);
            this.grpLogPage.Controls.Add(this.txtLoginPagePassword);
            this.grpLogPage.Controls.Add(this.txtLoginPageUserName);
            this.grpLogPage.Location = new System.Drawing.Point(12, 12);
            this.grpLogPage.Name = "grpLogPage";
            this.grpLogPage.Size = new System.Drawing.Size(236, 142);
            this.grpLogPage.TabIndex = 0;
            this.grpLogPage.TabStop = false;
            this.grpLogPage.Text = "Login Page";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(124, 105);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(99, 23);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(26, 105);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(92, 23);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // txtLoginPagePassword
            // 
            this.txtLoginPagePassword.Location = new System.Drawing.Point(98, 72);
            this.txtLoginPagePassword.Name = "txtLoginPagePassword";
            this.txtLoginPagePassword.PasswordChar = '*';
            this.txtLoginPagePassword.Size = new System.Drawing.Size(125, 20);
            this.txtLoginPagePassword.TabIndex = 1;
            // 
            // txtLoginPageUserName
            // 
            this.txtLoginPageUserName.Location = new System.Drawing.Point(98, 35);
            this.txtLoginPageUserName.Name = "txtLoginPageUserName";
            this.txtLoginPageUserName.Size = new System.Drawing.Size(125, 20);
            this.txtLoginPageUserName.TabIndex = 0;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 178);
            this.Controls.Add(this.grpLogPage);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.grpLogPage.ResumeLayout(false);
            this.grpLogPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogPage;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPagePassword;
        private System.Windows.Forms.TextBox txtLoginPageUserName;
    }
}