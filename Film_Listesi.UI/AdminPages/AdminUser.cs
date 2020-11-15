using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.Entity.Entities.Enums;
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
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }
        EfUserRepository efUserRepository = new EfUserRepository();
        private void btnAddUserCreate_Click(object sender, EventArgs e)
        {
            efUserRepository.AddUser(txtAddUserFirstName.Text, txtAddUserLastName.Text,txtAddUserUserName.Text,txtAddUserPassword.Text, (Role)Enum.Parse(typeof(Role), cmbAddUserRole.Text));
            dataGridView1.DataSource = efUserRepository.GetActiveUser();
            efUserRepository.Eraser(grpAddUser);

        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efUserRepository.GetActiveUser();
            efUserRepository.GetRole(cmbAddUserRole, cmbUpdateUserRole, cmbFindByRoleRole);
        }

        private void btnUpdateUserFindById_Click(object sender, EventArgs e)
        {
            efUserRepository.FindById(int.Parse(txtUpdateUserFindById.Text), txtUpdateUserFirstName, txtUpdateUserLAstName, txtUpdateUserUserName, txtUpdateUserPassword);

        }

        private void btnUpdateUserUpdate_Click(object sender, EventArgs e)
        {
            efUserRepository.UpDateUser(int.Parse(txtUpdateUserFindById.Text), txtUpdateUserFirstName.Text, txtUpdateUserLAstName.Text, txtUpdateUserUserName.Text, txtUpdateUserPassword.Text,(Role)Enum.Parse(typeof(Role),cmbUpdateUserRole.Text));
            dataGridView1.DataSource = efUserRepository.GetActiveUser();
            efUserRepository.Eraser(grpUpdateUser);
        }

        private void btnDeleteUserDelete_Click(object sender, EventArgs e)
        {
            efUserRepository.DeleteUser(int.Parse(txtDeleteUserId.Text));
            dataGridView1.DataSource = efUserRepository.GetActiveUser();
            efUserRepository.Eraser(grpDeleteUser);
        }

        private void cmbFindByRoleRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = efUserRepository.ListByRole((Role)Enum.Parse(typeof(Role), cmbFindByRoleRole.Text));

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }
    }
}
