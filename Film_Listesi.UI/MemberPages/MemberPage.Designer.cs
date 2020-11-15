namespace Film_Listesi.UI.MemberPages
{
    partial class MemberPage
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
            this.grpMemberShow = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectFilm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMemberShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMemberShow
            // 
            this.grpMemberShow.Controls.Add(this.dataGridView1);
            this.grpMemberShow.Location = new System.Drawing.Point(13, 13);
            this.grpMemberShow.Name = "grpMemberShow";
            this.grpMemberShow.Size = new System.Drawing.Size(775, 232);
            this.grpMemberShow.TabIndex = 0;
            this.grpMemberShow.TabStop = false;
            this.grpMemberShow.Text = "Select Film";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelectFilm
            // 
            this.btnSelectFilm.Location = new System.Drawing.Point(20, 252);
            this.btnSelectFilm.Name = "btnSelectFilm";
            this.btnSelectFilm.Size = new System.Drawing.Size(193, 23);
            this.btnSelectFilm.TabIndex = 2;
            this.btnSelectFilm.Text = "Film Details";
            this.btnSelectFilm.UseVisualStyleBackColor = true;
            this.btnSelectFilm.Click += new System.EventHandler(this.btnSelectFilm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelectFilm);
            this.Controls.Add(this.grpMemberShow);
            this.Name = "MemberPage";
            this.Text = "MemberPage";
            this.Load += new System.EventHandler(this.MemberPage_Load);
            this.grpMemberShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelectFilm;
        private System.Windows.Forms.Button btnExit;
    }
}