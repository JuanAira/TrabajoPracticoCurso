using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class CategoriasModel
    {
        public int Id { get; set; } 

        [Display(Name = "Nombre de categoría")]
        [Required]
        [MaxLength(250)]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        [MinLength(10)]
        [MaxLength(450)]
        public string Descripcion { get; set; }
    }
}