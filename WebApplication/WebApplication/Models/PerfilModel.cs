using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class PerfilModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required]
        public string Apellido { get; set; }

        [Display(Name = "Nombre de usuario")]
        [Required]
        public string NombreUsuario { get; set; }

     //Ver lo de la foto de perfil
    }
}