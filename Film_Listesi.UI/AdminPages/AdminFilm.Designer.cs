namespace Film_Listesi.UI.AdminPages
{
    partial class AdminFilm
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
            this.grpAddFilm = new System.Windows.Forms.GroupBox();
            this.cmbAddFilmDirector = new System.Windows.Forms.ComboBox();
            this.cmbAddFilmCategory = new System.Windows.Forms.ComboBox();
            this.txtAddFilmPictureUrl = new System.Windows.Forms.TextBox();
            this.btnAddFilmAdd = new System.Windows.Forms.Button();
            this.btnAddFilmPictureUrl = new System.Windows.Forms.Button();
            this.txtAddFilmCountry = new System.Windows.Forms.TextBox();
            this.txtAddFilmIMDBPoint = new System.Windows.Forms.TextBox();
            this.txtAddFilmYear = new System.Windows.Forms.TextBox();
            this.txtAddFilmName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lebel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFimDetails = new System.Windows.Forms.Button();
            this.ofdAddPicture = new System.Windows.Forms.OpenFileDialog();
            this.grpUpdateFilm = new System.Windows.Forms.GroupBox();
            this.btnUpdateFilm = new System.Windows.Forms.Button();
            this.btnUpdateFindById = new System.Windows.Forms.Button();
            this.txtUpdateFilmId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUpdateFilmDirector = new System.Windows.Forms.ComboBox();
            this.cmbUpdateFilmCategory = new System.Windows.Forms.ComboBox();
            this.txtUpdateFimImageUrl = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUpdateFimCountry = new System.Windows.Forms.TextBox();
            this.txtUpdateFilmImdbPoint = new System.Windows.Forms.TextBox();
            this.txtUpdateFimYear = new System.Windows.Forms.TextBox();
            this.txtUpdateFimName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpDeleteFilm = new System.Windows.Forms.GroupBox();
            this.btnDeleteFilmDelete = new System.Windows.Forms.Button();
            this.txtDeleteFilmId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpAddFilm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateFilm.SuspendLayout();
            this.grpDeleteFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddFilm
            // 
            this.grpAddFilm.Controls.Add(this.cmbAddFilmDirector);
            this.grpAddFilm.Controls.Add(this.cmbAddFilmCategory);
            this.grpAddFilm.Controls.Add(this.txtAddFilmPictureUrl);
            this.grpAddFilm.Controls.Add(this.btnAddFilmAdd);
            this.grpAddFilm.Controls.Add(this.btnAddFilmPictureUrl);
            this.grpAddFilm.Controls.Add(this.txtAddFilmCountry);
            this.grpAddFilm.Controls.Add(this.txtAddFilmIMDBPoint);
            this.grpAddFilm.Controls.Add(this.txtAddFilmYear);
            this.grpAddFilm.Controls.Add(this.txtAddFilmName);
            this.grpAddFilm.Controls.Add(this.label7);
            this.grpAddFilm.Controls.Add(this.label6);
            this.grpAddFilm.Controls.Add(this.label5);
            this.grpAddFilm.Controls.Add(this.label3);
            this.grpAddFilm.Controls.Add(this.label4);
            this.grpAddFilm.Controls.Add(this.lebel2);
            this.grpAddFilm.Controls.Add(this.label1);
            this.grpAddFilm.Location = new System.Drawing.Point(13, 13);
            this.grpAddFilm.Name = "grpAddFilm";
            this.grpAddFilm.Size = new System.Drawing.Size(246, 344);
            this.grpAddFilm.TabIndex = 0;
            this.grpAddFilm.TabStop = false;
            this.grpAddFilm.Text = "Add Film";
            // 
            // cmbAddFilmDirector
            // 
            this.cmbAddFilmDirector.FormattingEnabled = true;
            this.cmbAddFilmDirector.Location = new System.Drawing.Point(84, 280);
            this.cmbAddFilmDirector.Name = "cmbAddFilmDirector";
            this.cmbAddFilmDirector.Size = new System.Drawing.Size(149, 21);
            this.cmbAddFilmDirector.TabIndex = 15;
            // 
            // cmbAddFilmCategory
            // 
            this.cmbAddFilmCategory.FormattingEnabled = true;
            this.cmbAddFilmCategory.Location = new System.Drawing.Point(84, 251);
            this.cmbAddFilmCategory.Name = "cmbAddFilmCategory";
            this.cmbAddFilmCategory.Size = new System.Drawing.Size(149, 21);
            this.cmbAddFilmCategory.TabIndex = 14;
            // 
            // txtAddFilmPictureUrl
            // 
            this.txtAddFilmPictureUrl.Location = new System.Drawing.Point(23, 205);
            this.txtAddFilmPictureUrl.Name = "txtAddFilmPictureUrl";
            this.txtAddFilmPictureUrl.Size = new System.Drawing.Size(210, 20);
            this.txtAddFilmPictureUrl.TabIndex = 13;
            // 
            // btnAddFilmAdd
            // 
            this.btnAddFilmAdd.Location = new System.Drawing.Point(23, 308);
            this.btnAddFilmAdd.Name = "btnAddFilmAdd";
            this.btnAddFilmAdd.Size = new System.Drawing.Size(210, 23);
            this.btnAddFilmAdd.TabIndex = 12;
            this.btnAddFilmAdd.Text = "Add";
            this.btnAddFilmAdd.UseVisualStyleBackColor = true;
            this.btnAddFilmAdd.Click += new System.EventHandler(this.btnAddFilmAdd_Click);
            // 
            // btnAddFilmPictureUrl
            // 
            this.btnAddFilmPictureUrl.Location = new System.Drawing.Point(90, 161);
            this.btnAddFilmPictureUrl.Name = "btnAddFilmPictureUrl";
            this.btnAddFilmPictureUrl.Size = new System.Drawing.Size(143, 23);
            this.btnAddFilmPictureUrl.TabIndex = 11;
            this.btnAddFilmPictureUrl.Text = "Select Image";
            this.btnAddFilmPictureUrl.UseVisualStyleBackColor = true;
            this.btnAddFilmPictureUrl.Click += new System.EventHandler(this.btnAddFilmPictureUrl_Click);
            // 
            // txtAddFilmCountry
            // 
            this.txtAddFilmCountry.Location = new System.Drawing.Point(90, 119);
            this.txtAddFilmCountry.Name = "txtAddFilmCountry";
            this.txtAddFilmCountry.Size = new System.Drawing.Size(143, 20);
            this.txtAddFilmCountry.TabIndex = 10;
            // 
            // txtAddFilmIMDBPoint
            // 
            this.txtAddFilmIMDBPoint.Location = new System.Drawing.Point(90, 89);
            this.txtAddFilmIMDBPoint.Name = "txtAddFilmIMDBPoint";
            this.txtAddFilmIMDBPoint.Size = new System.Drawing.Size(143, 20);
            this.txtAddFilmIMDBPoint.TabIndex = 9;
            // 
            // txtAddFilmYear
            // 
            this.txtAddFilmYear.Location = new System.Drawing.Point(90, 60);
            this.txtAddFilmYear.Name = "txtAddFilmYear";
            this.txtAddFilmYear.Size = new System.Drawing.Size(143, 20);
            this.txtAddFilmYear.TabIndex = 8;
            // 
            // txtAddFilmName
            // 
            this.txtAddFilmName.Location = new System.Drawing.Point(90, 30);
            this.txtAddFilmName.Name = "txtAddFilmName";
            this.txtAddFilmName.Size = new System.Drawing.Size(143, 20);
            this.txtAddFilmName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PictureUrl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IMDB Point";
            // 
            // lebel2
            // 
            this.lebel2.AutoSize = true;
            this.lebel2.Location = new System.Drawing.Point(20, 63);
            this.lebel2.Name = "lebel2";
            this.lebel2.Size = new System.Drawing.Size(29, 13);
            this.lebel2.TabIndex = 1;
            this.lebel2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnFimDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Film";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 135);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnFimDetails
            // 
            this.btnFimDetails.Location = new System.Drawing.Point(7, 14);
            this.btnFimDetails.Name = "btnFimDetails";
            this.btnFimDetails.Size = new System.Drawing.Size(166, 23);
            this.btnFimDetails.TabIndex = 2;
            this.btnFimDetails.Text = "Get Film Details";
            this.btnFimDetails.UseVisualStyleBackColor = true;
            this.btnFimDetails.Click += new System.EventHandler(this.btnFimDetails_Click);
            // 
            // ofdAddPicture
            // 
            this.ofdAddPicture.FileName = "openFileDialog1";
            // 
            // grpUpdateFilm
            // 
            this.grpUpdateFilm.Controls.Add(this.btnUpdateFilm);
            this.grpUpdateFilm.Controls.Add(this.btnUpdateFindById);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFilmId);
            this.grpUpdateFilm.Controls.Add(this.label14);
            this.grpUpdateFilm.Controls.Add(this.cmbUpdateFilmDirector);
            this.grpUpdateFilm.Controls.Add(this.cmbUpdateFilmCategory);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFimImageUrl);
            this.grpUpdateFilm.Controls.Add(this.button2);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFimCountry);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFilmImdbPoint);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFimYear);
            this.grpUpdateFilm.Controls.Add(this.txtUpdateFimName);
            this.grpUpdateFilm.Controls.Add(this.label2);
            this.grpUpdateFilm.Controls.Add(this.label8);
            this.grpUpdateFilm.Controls.Add(this.label9);
            this.grpUpdateFilm.Controls.Add(this.label10);
            this.grpUpdateFilm.Controls.Add(this.label11);
            this.grpUpdateFilm.Controls.Add(this.label12);
            this.grpUpdateFilm.Controls.Add(this.label13);
            this.grpUpdateFilm.Location = new System.Drawing.Point(266, 13);
            this.grpUpdateFilm.Name = "grpUpdateFilm";
            this.grpUpdateFilm.Size = new System.Drawing.Size(220, 379);
            this.grpUpdateFilm.TabIndex = 3;
            this.grpUpdateFilm.TabStop = false;
            this.grpUpdateFilm.Text = "UpdateFilm";
            // 
            // btnUpdateFilm
            // 
            this.btnUpdateFilm.Location = new System.Drawing.Point(6, 337);
            this.btnUpdateFilm.Name = "btnUpdateFilm";
            this.btnUpdateFilm.Size = new System.Drawing.Size(208, 23);
            this.btnUpdateFilm.TabIndex = 34;
            this.btnUpdateFilm.Text = "Update";
            this.btnUpdateFilm.UseVisualStyleBackColor = true;
            this.btnUpdateFilm.Click += new System.EventHandler(this.btnUpdateFilm_Click);
            // 
            // btnUpdateFindById
            // 
            this.btnUpdateFindById.Location = new System.Drawing.Point(81, 24);
            this.btnUpdateFindById.Name = "btnUpdateFindById";
            this.btnUpdateFindById.Size = new System.Drawing.Size(133, 23);
            this.btnUpdateFindById.TabIndex = 33;
            this.btnUpdateFindById.Text = "Find By Id";
            this.btnUpdateFindById.UseVisualStyleBackColor = true;
            this.btnUpdateFindById.Click += new System.EventHandler(this.btnUpdateFindById_Click);
            // 
            // txtUpdateFilmId
            // 
            this.txtUpdateFilmId.Location = new System.Drawing.Point(23, 26);
            this.txtUpdateFilmId.Name = "txtUpdateFilmId";
            this.txtUpdateFilmId.Size = new System.Drawing.Size(52, 20);
            this.txtUpdateFilmId.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Id";
            // 
            // cmbUpdateFilmDirector
            // 
            this.cmbUpdateFilmDirector.FormattingEnabled = true;
            this.cmbUpdateFilmDirector.Location = new System.Drawing.Point(65, 310);
            this.cmbUpdateFilmDirector.Name = "cmbUpdateFilmDirector";
            this.cmbUpdateFilmDirector.Size = new System.Drawing.Size(149, 21);
            this.cmbUpdateFilmDirector.TabIndex = 30;
            // 
            // cmbUpdateFilmCategory
            // 
            this.cmbUpdateFilmCategory.FormattingEnabled = true;
            this.cmbUpdateFilmCategory.Location = new System.Drawing.Point(65, 281);
            this.cmbUpdateFilmCategory.Name = "cmbUpdateFilmCategory";
            this.cmbUpdateFilmCategory.Size = new System.Drawing.Size(149, 21);
            this.cmbUpdateFilmCategory.TabIndex = 29;
            // 
            // txtUpdateFimImageUrl
            // 
            this.txtUpdateFimImageUrl.Location = new System.Drawing.Point(4, 235);
            this.txtUpdateFimImageUrl.Name = "txtUpdateFimImageUrl";
            this.txtUpdateFimImageUrl.Size = new System.Drawing.Size(210, 20);
            this.txtUpdateFimImageUrl.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Select Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUpdateFimCountry
            // 
            this.txtUpdateFimCountry.Location = new System.Drawing.Point(71, 149);
            this.txtUpdateFimCountry.Name = "txtUpdateFimCountry";
            this.txtUpdateFimCountry.Size = new System.Drawing.Size(143, 20);
            this.txtUpdateFimCountry.TabIndex = 26;
            // 
            // txtUpdateFilmImdbPoint
            // 
            this.txtUpdateFilmImdbPoint.Location = new System.Drawing.Point(71, 119);
            this.txtUpdateFilmImdbPoint.Name = "txtUpdateFilmImdbPoint";
            this.txtUpdateFilmImdbPoint.Size = new System.Drawing.Size(143, 20);
            this.txtUpdateFilmImdbPoint.TabIndex = 25;
            // 
            // txtUpdateFimYear
            // 
            this.txtUpdateFimYear.Location = new System.Drawing.Point(71, 90);
            this.txtUpdateFimYear.Name = "txtUpdateFimYear";
            this.txtUpdateFimYear.Size = new System.Drawing.Size(143, 20);
            this.txtUpdateFimYear.TabIndex = 24;
            // 
            // txtUpdateFimName
            // 
            this.txtUpdateFimName.Location = new System.Drawing.Point(71, 60);
            this.txtUpdateFimName.Name = "txtUpdateFimName";
            this.txtUpdateFimName.Size = new System.Drawing.Size(143, 20);
            this.txtUpdateFimName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Director";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PictureUrl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "IMDB Point";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Film Name";
            // 
            // grpDeleteFilm
            // 
            this.grpDeleteFilm.Controls.Add(this.btnDeleteFilmDelete);
            this.grpDeleteFilm.Controls.Add(this.txtDeleteFilmId);
            this.grpDeleteFilm.Controls.Add(this.label15);
            this.grpDeleteFilm.Location = new System.Drawing.Point(493, 13);
            this.grpDeleteFilm.Name = "grpDeleteFilm";
            this.grpDeleteFilm.Size = new System.Drawing.Size(219, 76);
            this.grpDeleteFilm.TabIndex = 4;
            this.grpDeleteFilm.TabStop = false;
            this.grpDeleteFilm.Text = "Delete Film";
            // 
            // btnDeleteFilmDelete
            // 
            this.btnDeleteFilmDelete.Location = new System.Drawing.Point(82, 28);
            this.btnDeleteFilmDelete.Name = "btnDeleteFilmDelete";
            this.btnDeleteFilmDelete.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteFilmDelete.TabIndex = 36;
            this.btnDeleteFilmDelete.Text = "Delete";
            this.btnDeleteFilmDelete.UseVisualStyleBackColor = true;
            this.btnDeleteFilmDelete.Click += new System.EventHandler(this.btnDeleteFilmDelete_Click);
            // 
            // txtDeleteFilmId
            // 
            this.txtDeleteFilmId.Location = new System.Drawing.Point(24, 30);
            this.txtDeleteFilmId.Name = "txtDeleteFilmId";
            this.txtDeleteFilmId.Size = new System.Drawing.Size(52, 20);
            this.txtDeleteFilmId.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Id";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(494, 106);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(218, 42);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Get Back Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AdminFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 599);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpDeleteFilm);
            this.Controls.Add(this.grpUpdateFilm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAddFilm);
            this.Name = "AdminFilm";
            this.Text = "AdminFilm";
            this.Load += new System.EventHandler(this.AdminFilm_Load);
            this.grpAddFilm.ResumeLayout(false);
            this.grpAddFilm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateFilm.ResumeLayout(false);
            this.grpUpdateFilm.PerformLayout();
            this.grpDeleteFilm.ResumeLayout(false);
            this.grpDeleteFilm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddFilm;
        private System.Windows.Forms.TextBox txtAddFilmCountry;
        private System.Windows.Forms.TextBox txtAddFilmIMDBPoint;
        private System.Windows.Forms.TextBox txtAddFilmYear;
        private System.Windows.Forms.TextBox txtAddFilmName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lebel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddFilmPictureUrl;
        private System.Windows.Forms.Button btnAddFilmAdd;
        private System.Windows.Forms.Button btnAddFilmPictureUrl;
        private System.Windows.Forms.ComboBox cmbAddFilmDirector;
        private System.Windows.Forms.ComboBox cmbAddFilmCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog ofdAddPicture;
        private System.Windows.Forms.Button btnFimDetails;
        private System.Windows.Forms.GroupBox grpUpdateFilm;
        private System.Windows.Forms.Button btnUpdateFindById;
        private System.Windows.Forms.TextBox txtUpdateFilmId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUpdateFilmDirector;
        private System.Windows.Forms.ComboBox cmbUpdateFilmCategory;
        private System.Windows.Forms.TextBox txtUpdateFimImageUrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUpdateFimCountry;
        private System.Windows.Forms.TextBox txtUpdateFilmImdbPoint;
        private System.Windows.Forms.TextBox txtUpdateFimYear;
        private System.Windows.Forms.TextBox txtUpdateFimName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdateFilm;
        private System.Windows.Forms.GroupBox grpDeleteFilm;
        private System.Windows.Forms.Button btnDeleteFilmDelete;
        private System.Windows.Forms.TextBox txtDeleteFilmId;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMenu;
    }
}