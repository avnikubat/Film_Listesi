using Film_Listesi.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.UI.AdminPages
{
    public partial class AdminCategory : Form
    {
        public AdminCategory()
        {
            InitializeComponent();
        }

        EfCategoryRepository efCategoryRepository = new EfCategoryRepository();
        private void btnAddCategoryCreate_Click(object sender, EventArgs e)
        {
            efCategoryRepository.CreateCategory(txtAddCategoryName.Text);
            dataGridView1.DataSource = efCategoryRepository.GetActiveCategory();
            efCategoryRepository.Eraser(grpAddCategory);
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efCategoryRepository.GetActiveCategory();
        }

        private void btnUpdateCategoryFindById_Click(object sender, EventArgs e)
        {
            efCategoryRepository.FindById(int.Parse(txtUpdateCategoryFindById.Text),txtUpdateCategoryName);
        }

        private void btnUpdateCategoryUpdate_Click(object sender, EventArgs e)
        {
            efCategoryRepository.UpdateCategory(int.Parse(txtUpdateCategoryFindById.Text), txtUpdateCategoryName.Text);
            dataGridView1.DataSource = efCategoryRepository.GetActiveCategory();
            efCategoryRepository.Eraser(grpUpdateCategory);
        }

        private void btnDeleteCategoryDelete_Click(object sender, EventArgs e)
        {
            efCategoryRepository.DeleteCategory(int.Parse(txtDeleteCategoryId.Text));
            dataGridView1.DataSource = efCategoryRepository.GetActiveCategory();
            efCategoryRepository.Eraser(grpDeleteCategory);
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=efCategoryRepository.FindByName(txtFindByName.Text);
            efCategoryRepository.Eraser(grpFindByName);
            
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efCategoryRepository.GetAll();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }
    }
}
