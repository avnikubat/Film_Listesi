namespace Film_Listesi.UI.AdminPages
{
    partial class AdminCategory
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
            this.grpAddCategory = new System.Windows.Forms.GroupBox();
            this.btnAddCategoryCreate = new System.Windows.Forms.Button();
            this.txtAddCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdateCategory = new System.Windows.Forms.GroupBox();
            this.btnUpdateCategoryUpdate = new System.Windows.Forms.Button();
            this.txtUpdateCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateCategoryFindById = new System.Windows.Forms.Button();
            this.txtUpdateCategoryFindById = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDeleteCategory = new System.Windows.Forms.GroupBox();
            this.btnDeleteCategoryDelete = new System.Windows.Forms.Button();
            this.txtDeleteCategoryId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpFindByName = new System.Windows.Forms.GroupBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.txtFindByName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpGetAll = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpAddCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateCategory.SuspendLayout();
            this.grpDeleteCategory.SuspendLayout();
            this.grpFindByName.SuspendLayout();
            this.grpGetAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddCategory
            // 
            this.grpAddCategory.Controls.Add(this.btnAddCategoryCreate);
            this.grpAddCategory.Controls.Add(this.txtAddCategoryName);
            this.grpAddCategory.Controls.Add(this.label1);
            this.grpAddCategory.Location = new System.Drawing.Point(13, 13);
            this.grpAddCategory.Name = "grpAddCategory";
            this.grpAddCategory.Size = new System.Drawing.Size(199, 100);
            this.grpAddCategory.TabIndex = 0;
            this.grpAddCategory.TabStop = false;
            this.grpAddCategory.Text = "Add Category";
            // 
            // btnAddCategoryCreate
            // 
            this.btnAddCategoryCreate.Location = new System.Drawing.Point(10, 59);
            this.btnAddCategoryCreate.Name = "btnAddCategoryCreate";
            this.btnAddCategoryCreate.Size = new System.Drawing.Size(183, 23);
            this.btnAddCategoryCreate.TabIndex = 2;
            this.btnAddCategoryCreate.Text = "Create";
            this.btnAddCategoryCreate.UseVisualStyleBackColor = true;
            this.btnAddCategoryCreate.Click += new System.EventHandler(this.btnAddCategoryCreate_Click);
            // 
            // txtAddCategoryName
            // 
            this.txtAddCategoryName.Location = new System.Drawing.Point(93, 29);
            this.txtAddCategoryName.Name = "txtAddCategoryName";
            this.txtAddCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtAddCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUpdateCategory
            // 
            this.grpUpdateCategory.Controls.Add(this.btnUpdateCategoryUpdate);
            this.grpUpdateCategory.Controls.Add(this.txtUpdateCategoryName);
            this.grpUpdateCategory.Controls.Add(this.label3);
            this.grpUpdateCategory.Controls.Add(this.btnUpdateCategoryFindById);
            this.grpUpdateCategory.Controls.Add(this.txtUpdateCategoryFindById);
            this.grpUpdateCategory.Controls.Add(this.label2);
            this.grpUpdateCategory.Location = new System.Drawing.Point(219, 13);
            this.grpUpdateCategory.Name = "grpUpdateCategory";
            this.grpUpdateCategory.Size = new System.Drawing.Size(200, 120);
            this.grpUpdateCategory.TabIndex = 2;
            this.grpUpdateCategory.TabStop = false;
            this.grpUpdateCategory.Text = "Update Category";
            // 
            // btnUpdateCategoryUpdate
            // 
            this.btnUpdateCategoryUpdate.Location = new System.Drawing.Point(9, 91);
            this.btnUpdateCategoryUpdate.Name = "btnUpdateCategoryUpdate";
            this.btnUpdateCategoryUpdate.Size = new System.Drawing.Size(167, 23);
            this.btnUpdateCategoryUpdate.TabIndex = 7;
            this.btnUpdateCategoryUpdate.Text = "Update";
            this.btnUpdateCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateCategoryUpdate.Click += new System.EventHandler(this.btnUpdateCategoryUpdate_Click);
            // 
            // txtUpdateCategoryName
            // 
            this.txtUpdateCategoryName.Location = new System.Drawing.Point(47, 66);
            this.txtUpdateCategoryName.Name = "txtUpdateCategoryName";
            this.txtUpdateCategoryName.Size = new System.Drawing.Size(129, 20);
            this.txtUpdateCategoryName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // btnUpdateCategoryFindById
            // 
            this.btnUpdateCategoryFindById.Location = new System.Drawing.Point(101, 27);
            this.btnUpdateCategoryFindById.Name = "btnUpdateCategoryFindById";
            this.btnUpdateCategoryFindById.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCategoryFindById.TabIndex = 4;
            this.btnUpdateCategoryFindById.Text = "Find By Id";
            this.btnUpdateCategoryFindById.UseVisualStyleBackColor = true;
            this.btnUpdateCategoryFindById.Click += new System.EventHandler(this.btnUpdateCategoryFindById_Click);
            // 
            // txtUpdateCategoryFindById
            // 
            this.txtUpdateCategoryFindById.Location = new System.Drawing.Point(28, 29);
            this.txtUpdateCategoryFindById.Name = "txtUpdateCategoryFindById";
            this.txtUpdateCategoryFindById.Size = new System.Drawing.Size(67, 20);
            this.txtUpdateCategoryFindById.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // grpDeleteCategory
            // 
            this.grpDeleteCategory.Controls.Add(this.btnDeleteCategoryDelete);
            this.grpDeleteCategory.Controls.Add(this.txtDeleteCategoryId);
            this.grpDeleteCategory.Controls.Add(this.label5);
            this.grpDeleteCategory.Location = new System.Drawing.Point(426, 13);
            this.grpDeleteCategory.Name = "grpDeleteCategory";
            this.grpDeleteCategory.Size = new System.Drawing.Size(200, 61);
            this.grpDeleteCategory.TabIndex = 3;
            this.grpDeleteCategory.TabStop = false;
            this.grpDeleteCategory.Text = "Delete Category";
            // 
            // btnDeleteCategoryDelete
            // 
            this.btnDeleteCategoryDelete.Location = new System.Drawing.Point(107, 27);
            this.btnDeleteCategoryDelete.Name = "btnDeleteCategoryDelete";
            this.btnDeleteCategoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategoryDelete.TabIndex = 7;
            this.btnDeleteCategoryDelete.Text = "Delete";
            this.btnDeleteCategoryDelete.UseVisualStyleBackColor = true;
            this.btnDeleteCategoryDelete.Click += new System.EventHandler(this.btnDeleteCategoryDelete_Click);
            // 
            // txtDeleteCategoryId
            // 
            this.txtDeleteCategoryId.Location = new System.Drawing.Point(34, 29);
            this.txtDeleteCategoryId.Name = "txtDeleteCategoryId";
            this.txtDeleteCategoryId.Size = new System.Drawing.Size(67, 20);
            this.txtDeleteCategoryId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id";
            // 
            // grpFindByName
            // 
            this.grpFindByName.Controls.Add(this.btnFindByName);
            this.grpFindByName.Controls.Add(this.txtFindByName);
            this.grpFindByName.Controls.Add(this.label4);
            this.grpFindByName.Location = new System.Drawing.Point(426, 79);
            this.grpFindByName.Name = "grpFindByName";
            this.grpFindByName.Size = new System.Drawing.Size(200, 54);
            this.grpFindByName.TabIndex = 4;
            this.grpFindByName.TabStop = false;
            this.grpFindByName.Text = "Find By Name";
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(119, 16);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(75, 23);
            this.btnFindByName.TabIndex = 10;
            this.btnFindByName.Text = "Find By Name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // txtFindByName
            // 
            this.txtFindByName.Location = new System.Drawing.Point(47, 18);
            this.txtFindByName.Name = "txtFindByName";
            this.txtFindByName.Size = new System.Drawing.Size(67, 20);
            this.txtFindByName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // grpGetAll
            // 
            this.grpGetAll.Controls.Add(this.btnGetAll);
            this.grpGetAll.Location = new System.Drawing.Point(633, 13);
            this.grpGetAll.Name = "grpGetAll";
            this.grpGetAll.Size = new System.Drawing.Size(155, 82);
            this.grpGetAll.TabIndex = 5;
            this.grpGetAll.TabStop = false;
            this.grpGetAll.Text = "Get All";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(38, 29);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(633, 104);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 23);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Get Back Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AdminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpGetAll);
            this.Controls.Add(this.grpFindByName);
            this.Controls.Add(this.grpDeleteCategory);
            this.Controls.Add(this.grpUpdateCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAddCategory);
            this.Name = "AdminCategory";
            this.Text = "AdminCategory";
            this.Load += new System.EventHandler(this.AdminCategory_Load);
            this.grpAddCategory.ResumeLayout(false);
            this.grpAddCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateCategory.ResumeLayout(false);
            this.grpUpdateCategory.PerformLayout();
            this.grpDeleteCategory.ResumeLayout(false);
            this.grpDeleteCategory.PerformLayout();
            this.grpFindByName.ResumeLayout(false);
            this.grpFindByName.PerformLayout();
            this.grpGetAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddCategory;
        private System.Windows.Forms.Button btnAddCategoryCreate;
        private System.Windows.Forms.TextBox txtAddCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdateCategory;
        private System.Windows.Forms.Button btnUpdateCategoryUpdate;
        private System.Windows.Forms.TextBox txtUpdateCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateCategoryFindById;
        private System.Windows.Forms.TextBox txtUpdateCategoryFindById;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDeleteCategory;
        private System.Windows.Forms.Button btnDeleteCategoryDelete;
        private System.Windows.Forms.TextBox txtDeleteCategoryId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpFindByName;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox txtFindByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpGetAll;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnMenu;
    }
}