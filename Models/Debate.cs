using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaAplicacionMVC.Models
{
    public class Debate
    {
        public string titulo { get; set; }
        public string contenido { get; set; }
        public string contenidoPreview { get; set; }
        public string imagen { get; set; }
        public string autor { get; set; }
        public string fecha { get; set; }
        public Boolean destacar { get; set; }
    }
}