using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BurakBlog.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        [Required]
        [Display(Name = "Başlık")]
        [StringLength(2000)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }

        [Required]
        [Display(Name = "İçerik Yazısı")]
        [StringLength(4000)]
        public string Article { get; set; }

        [Display(Name = "Video")]
        [StringLength(2000)]
        public string Video { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }

    }
}
