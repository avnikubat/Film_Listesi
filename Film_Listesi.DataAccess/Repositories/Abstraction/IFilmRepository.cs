using Film_Listesi.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Abstraction
{
    public interface IFilmRepository
    {
        void AddFilm(string Name, string Year, string IMBDPoint, string Country, string PictureUrl, int CategoryId, int UserId);
        void UpdateFilm(int Id, string Name, string Year, string IMBDPoint, string Country, string PictureUrl, int CategoryiId, int UserId);
        void DeleteDate(int Id);
        void FindById(int Id, TextBox Name, TextBox Year, TextBox IMBDPoint, TextBox Country, TextBox PictureUrl);

        List<Film> GetActiveFilms();
        List<Film> GetAll();
        Film Film_Details(int Id);
        List<Category> GetActiveCategory();
        List<User> GetActiveUser();
    }
}
