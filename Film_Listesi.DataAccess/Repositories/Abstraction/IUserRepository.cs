using Film_Listesi.Entity.Entities.Concrete;
using Film_Listesi.Entity.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Abstraction
{
    public interface IUserRepository
    {
        void AddUser(string FirstName, string LastName, string UserName, string Password, Role role);
        void UpDateUser(int Id, string FirstName, string LastName, string UserName, string Password, Role role);
        void DeleteUser(int Id);
        void FindById(int Id, TextBox FirstName, TextBox LastName, TextBox UserName, TextBox Password);

        void FindByUserName(string UserName);

        List<User> GetActiveUser();
        List<User> GetAll();
        List<User> FindByName(string FirstName);
        void GetRole(ComboBox comboBoxAdd, ComboBox comboBoxUpdate, ComboBox comboBoxFind);
        List<User> ListByRole(Role role);
    }
}
