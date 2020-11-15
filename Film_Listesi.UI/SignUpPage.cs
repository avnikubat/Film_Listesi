using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.Entity.Entities.Concrete;
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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        EfAccountRepository efAccountRepository = new EfAccountRepository();
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            efAccountRepository.CreateAccount(txtCreateFirstName.Text, txtCreateLastName.Text, txtCreateUserName.Text, txtCreatePassword.Text);
            Login_Page login_Page = new Login_Page();
            this.Hide();
            login_Page.Show();
        }


    }
}
