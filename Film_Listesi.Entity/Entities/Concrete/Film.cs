using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Listesi.Entity.Entities.Concrete
{
    public class Film:BaseEntity
    {
        [Required]
        public string FilmName { get; set; }
        public string Year { get; set; }
        public string IMDBPoint { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
