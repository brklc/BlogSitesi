using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurakBlog.Models
{
    public class Categories
    {

        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="Kategori Adı")]
        public string Name { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
