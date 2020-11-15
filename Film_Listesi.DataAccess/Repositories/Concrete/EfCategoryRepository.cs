using Film_Listesi.DataAccess.Repositories.Abstraction;
using Film_Listesi.Entity.Entities.Concrete;
using Film_Listesi.Entity.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Concrete
{
    public class EfCategoryRepository : EfBaseRepository, ICategoryRepository, IBaseRepository
    {
        Category category = new Category();
        public void CreateCategory(string categoryName)
        {
            category.Name = categoryName;
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(int Id)
        {
            try
            {
                category = db.Categories.FirstOrDefault(x => x.Id == Id);
                category.DeleteDate = DateTime.Now;
                category.Status = Status.Passive;
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Please type into id information...!");
            }
            
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

        public void FindById(int Id, TextBox textBox)
        {
            category = db.Categories.FirstOrDefault(x => x.Id == Id);
            textBox.Text = category.Name;
        }

        public List<Category> FindByName(string Name)
        {
            return db.Categories.Where(x => x.Name.ToLower() == Name.ToLower()).ToList();
        }

        public List<Category> GetActiveCategory()
        {
            return db.Categories.Where(x=>x.Status!=Status.Passive).ToList();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void UpdateCategory(int Id, string categoryName)
        {
            category = db.Categories.FirstOrDefault(x => x.Id == Id);
            category.Name = categoryName;
            category.UpdateDate = DateTime.Now;
            category.Status = Status.Updated;
            db.SaveChanges();

        }
    }
}
