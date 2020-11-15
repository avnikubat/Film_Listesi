using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.Entity.Entities.Concrete;
using Film_Listesi.Entity.Entities.Enums;
using Film_Listesi.UI.AdminPages;
using Film_Listesi.UI.MemberPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.UI
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        EfAccountRepository EfAccountRepository = new EfAccountRepository();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool CheckResult=EfAccountRepository.CheckCredention(txtLoginPageUserName.Text, txtLoginPagePassword.Text);
            User user = EfAccountRepository.FindByUserName(txtLoginPageUserName.Text);
            if (CheckResult==true)
            {
                if (user.Role == Role.Admin)
                {
                    AdminMenu adminMenu = new AdminMenu();
                    this.Hide();
                    adminMenu.Show();
                }
                else if (user.Role == Role.Member || user.Role==Role.Director)
                {
                    MemberPage memberPage = new MemberPage();
                    this.Hide();
                    memberPage.Show();
                }
            }
            
            else
            {
                MessageBox.Show("Please enter your name and password correctly.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            this.Hide();
            signUpPage.Show();
        }


    }
}
