using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.Project.Entites.Concrete
{
    public class Category : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId { get; set; }

        [Required]
        [Display(Name = "Kategori Adı")]
        [MaxLength(200)]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Kategori Açıklaması")]
        [MaxLength(500)]
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
