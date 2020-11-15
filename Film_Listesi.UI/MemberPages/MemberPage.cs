using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.UI.AdminPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.UI.MemberPages
{
    public partial class MemberPage : Form
    {
        public MemberPage()
        {
            InitializeComponent();
        }

        EfDilmRepository efDilmRepository = new EfDilmRepository();
        private void MemberPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efDilmRepository.GetActiveFilms();
        }
        public static int id;

        private void btnSelectFilm_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            efDilmRepository.Film_Details(id);
            MemberFilmDetails memberFilmDetails = new MemberFilmDetails();
            memberFilmDetails.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            this.Hide();
            login_Page.Show();
        }


    }
}
