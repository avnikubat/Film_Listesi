using Film_Listesi.Entity.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.Entity.Entities.Concrete
{
    [Table("Users")]
    public class User:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
