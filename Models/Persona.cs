using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NuevaAplicacionMVC.Models
{
    public class Persona{
        [Required(ErrorMessage="El dato es requerido")]
        public int edad { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
    }

    public class DatosEmail{
        [Required(ErrorMessage="Correo no existe")]
        [Display(Name="Email")]
        public String Email{ get;set;}
        [Required(ErrorMessage="Clave incorrecta")]
        [Display(Name="Clave")]
        public String Clave{ get; set; }
    }
}