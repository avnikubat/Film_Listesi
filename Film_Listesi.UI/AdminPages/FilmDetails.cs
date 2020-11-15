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

namespace Film_Listesi.UI.AdminPages
{
    public partial class FilmDetails : Form
    {
        public FilmDetails()
        {
            InitializeComponent();
        }
        EfDilmRepository efDilmRepository = new EfDilmRepository();
        int filmId = AdminFilm.id;
        private void FilmDetails_Load(object sender, EventArgs e)
        {
            Film film = efDilmRepository.Film_Details(filmId);
            lblName.Text = film.FilmName;
            lblYear.Text = film.Year;
            lblIMDBPoint.Text = film.IMDBPoint;
            lblCountry.Text = film.Country;
            lblCategory.Text = film.Category.Name;
            lblDirector.Text = film.User.FirstName + " " + film.User.LastName;

            pictureBox1.Image = Image.FromFile(film.ImageUrl);
        }


    }
}
