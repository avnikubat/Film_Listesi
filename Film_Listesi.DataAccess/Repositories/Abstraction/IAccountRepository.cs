using Film_Listesi.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.DataAccess.Repositories.Abstraction
{
    public interface IAccountRepository
    {
        void CreateAccount(string FirstName, string LastName, string UserName, string Password);
        bool CheckCredention(string UserName, string Password);
        User FindByUserName(string UserName);
    }
}
