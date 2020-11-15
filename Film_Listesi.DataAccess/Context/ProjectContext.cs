using Film_Listesi.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=OKYANUS35\SQLEXPRESS;Database=FilmListesi;Uid=AvniKubat;PWD=avniK_28;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
