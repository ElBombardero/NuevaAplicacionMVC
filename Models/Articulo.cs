using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NuevaAplicacionMVC.Models
{
    public class Noticia{
        [Required(ErrorMessage = "Se requiere este dato")]
        public String Titulo { get; set; }
        public String Contenido { get; set; }
        public String Imagen { get; set; }
    }
}