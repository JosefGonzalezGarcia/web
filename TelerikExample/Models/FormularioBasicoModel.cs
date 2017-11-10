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
        [Required]
        [Display(Name = "Precio maximo")]
        public decimal precioMaximo { get; set; }

        [Required]
        [Display(Name = "Fecha de estreno")]
        public DateTime fecha { get; set; }

        [Display(Name = "Personas a invitar")]
        public List<string> listNombresSelected { get; set; }
        public List<string> listNombres { get; set; }

        public FormularioBasicoModel()
        {
            listNombres = new List<string>();
            listNombres.Add("Anton Vol");
            listNombres.Add("Jesuita Gol");
            listNombres.Add("Golina Patrioski");
            listNombres.Add("Pat Gamorra");
            listNombres.Add("Hem Helsing");
        }


    }
}