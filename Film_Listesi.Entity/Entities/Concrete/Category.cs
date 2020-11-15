using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.Entity.Entities.Concrete
{
    [Table("Categories")]
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
