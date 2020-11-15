using Film_Listesi.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.DataAccess.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;
        public EfBaseRepository()
        {
            db = new ProjectContext();
        }
    }
}
