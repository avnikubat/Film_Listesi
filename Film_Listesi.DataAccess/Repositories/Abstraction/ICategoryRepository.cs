using Film_Listesi.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Abstraction
{
    public interface ICategoryRepository
    {
        void CreateCategory(string categoryName);
        void UpdateCategory(int Id, string categoryName);
        void DeleteCategory(int Id);
        void FindById(int Id, TextBox textBox);

        List<Category> GetActiveCategory();
        List<Category> FindByName(string categoryName);
        List<Category> GetAll();
    }
}
