using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikExample.Models
{
    public class FormularioBasicoModel
    {
        [Required]
        [Display(Name ="Nombre del usuario")]
        public string nombre { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email del usuario")]
        public string email { get; set; }

    }
}