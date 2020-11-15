using Film_Listesi.DataAccess.Repositories.Abstraction;
using Film_Listesi.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Concrete
{
    public class EfAccountRepository : EfBaseRepository, IAccountRepository, IBaseRepository
    {
        public bool CheckCredention(string UserName, string Password)
        {
            return db.Users.Any(x =>  x.UserName==UserName && x.Password==Password);
        }

        User user = new User();
        public void CreateAccount(string FirstName, string LastName, string UserName, string Password)
        {
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.UserName = UserName;
            user.Password = Password;
            user.Role = Entity.Entities.Enums.Role.Member;
            db.Users.Add(user);
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

        public User FindByUserName(string UserName)
        {
            return db.Users.FirstOrDefault(x => x.UserName == UserName);
        }
    }
}
