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
    public class EfUserRepository : EfBaseRepository, IBaseRepository, IUserRepository
    {
        User user = new User();
        public void AddUser(string FirstName, string LastName, string UserName, string Password, Role role)
        {
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.UserName = UserName;
            user.Password = Password;
            user.Role = role;
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            user = db.Users.FirstOrDefault(x => x.Id == Id);
            user.DeleteDate = DateTime.Now;
            user.Status = Status.Passive;
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

        public void FindById(int Id, TextBox FirstName, TextBox LastName, TextBox UserName, TextBox Password)
        {
            user = db.Users.FirstOrDefault(x => x.Id == Id);
            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            UserName.Text = user.UserName;
            Password.Text = user.Password;
        }

        public List<User> FindByName(string FirstName)
        {
            return db.Users.Where(x => x.FirstName.ToLower().Contains(FirstName.ToLower())).ToList();
        }

        public void FindByUserName(string UserName)
        {
            user=db.Users.FirstOrDefault(x=> x.UserName==UserName);
        }

        public List<User> GetActiveUser()
        {
            return db.Users.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public void GetRole(ComboBox comboBoxAdd, ComboBox comboBoxUpdate, ComboBox comboBoxFind)
        {
            comboBoxAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxAdd.SelectedIndex = 0;
            comboBoxUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxUpdate.SelectedIndex = 0;
            comboBoxFind.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxFind.SelectedIndex = 0;
        }

        public List<User> ListByRole(Role role)
        {
            return db.Users.Where(x => x.Role == role && x.Status != Status.Passive).ToList();
        }

        public void UpDateUser(int Id, string FirstName, string LastName, string UserName, string Password, Role role)
        {
            user = db.Users.FirstOrDefault(x => x.Id == Id);
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.UserName = UserName;
            user.Password = Password;
            user.Role = role;
            user.UpdateDate = DateTime.Now;
            user.Status = Status.Updated;
            db.SaveChanges();
        }
    }
}
