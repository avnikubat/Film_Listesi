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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminUser adminUser = new AdminUser();
            this.Hide();
            adminUser.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AdminCategory adminCategory = new AdminCategory();
            this.Hide();
            adminCategory.Show();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            AdminFilm adminFilm = new AdminFilm();
            this.Hide();
            adminFilm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            this.Hide();
            login_Page.Show();
        }

    }
}
