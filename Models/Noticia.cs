using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NuevaAplicacionMVC.Models
{
    public class Noticia
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Se requiere este dato")]
        public string titulo { get; set; }
        public string imagen { get; set; }
        public string contenido { get; set; }
        public string contenidoPreview { get; set; }
        public string autor { get; set; }
    }
}