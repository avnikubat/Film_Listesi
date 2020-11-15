using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.Entity.Entities.Concrete;
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
    public partial class MemberFilmDetails : Form
    {
        public MemberFilmDetails()
        {
            InitializeComponent();
        }
        EfDilmRepository efDilmRepository = new EfDilmRepository();
        int filmId = MemberPage.id;
        private void MemberFilmDetails_Load(object sender, EventArgs e)
        {
            Film film = efDilmRepository.Film_Details(filmId);
            lblFilmName.Text = film.FilmName;
            lblYear.Text = film.Year;
            lblIMDBPoint.Text = film.IMDBPoint;
            lblCountry.Text = film.Country;
            lblCategory.Text = film.Category.Name;
            lblDirector.Text = film.User.FirstName + " " + film.User.LastName;

            pictureBox1.Image = Image.FromFile(film.ImageUrl);
        }


    }
}
