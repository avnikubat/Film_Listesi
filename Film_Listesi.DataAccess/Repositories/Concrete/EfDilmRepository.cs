using Film_Listesi.DataAccess.Repositories.Abstraction;
using Film_Listesi.Entity.Entities.Concrete;
using Film_Listesi.Entity.Entities.Enums;
using Film_Listesi.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Concrete
{
    public class EfDilmRepository : EfBaseRepository, IFilmRepository, IBaseRepository
    {
        Film film = new Film();
        public void AddFilm(string Name, string Year, string IMBDPoint, string Country, string PictureUrl, int CategoryId, int UserId)
        {
            film.FilmName = Name;
            film.Year = Year;
            film.IMDBPoint = IMBDPoint;
            film.Country = Country;
            film.ImageUrl = PictureUrl;
            film.CategoryId = CategoryId;
            film.UserId = UserId;
            db.Films.Add(film);
            db.SaveChanges();
        }

        public void DeleteDate(int Id)
        {
            film = db.Films.FirstOrDefault(x => x.Id == Id);
            film.DeleteDate = DateTime.Now;
            film.Status = Status.Passive;
            db.SaveChanges();
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public Film Film_Details(int Id)
        {

            return db.Films.Include("Category").Include("User").FirstOrDefault(x => x.Id == Id);
        }

        public void FindById(int Id, TextBox Name, TextBox Year, TextBox IMBDPoint, TextBox Country, TextBox PictureUrl)
        {
            film = db.Films.FirstOrDefault(x=> x.Id==Id);
            Name.Text=film.FilmName;
            Year.Text = film.Year;
            IMBDPoint.Text = film.IMDBPoint;
            Country.Text = film.Country;
            PictureUrl.Text = film.ImageUrl;

        }

        public List<Category> GetActiveCategory()
        {
            return db.Categories.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<Film> GetActiveFilms()
        {
            return db.Films.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<User> GetActiveUser()
        {
            return db.Users.Where(x => x.Role == Role.Director && x.Status != Status.Passive).ToList();
        }

        public List<Film> GetAll()
        {
            return db.Films.ToList();
        }

        public void UpdateFilm(int Id, string Name, string Year, string IMBDPoint, string Country, string PictureUrl, int CategoryiId, int UserId)
        {
            film = db.Films.FirstOrDefault(x => x.Id == Id);
            film.FilmName = Name;
            film.Year = Year;
            film.IMDBPoint = IMBDPoint;
            film.Country = Country;
            film.ImageUrl = PictureUrl;
            film.CategoryId = CategoryiId;
            film.UserId = UserId;
            film.Status = Status.Updated;
            film.UpdateDate = DateTime.Now;
            db.SaveChanges();
        }

        List<Category> IFilmRepository.GetActiveCategory()
        {
            return db.Categories.Where(x => x.Status != Status.Passive).ToList();
        }
    }
}
