using NuevaAplicacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaAplicacionMVC.Services
{
    public class NoticiasService
    {
        public NuevaAplicacionMVC.Models.Noticia ObtenerNoticia(String tituloObtenido, String imagenObtenida, String contenidoObtenido)
        {
            return new NuevaAplicacionMVC.Models.Noticia(){
                titulo = tituloObtenido,
                imagen = imagenObtenida,
                contenido = contenidoObtenido,
                contenidoPreview = ""
            };
        }

        public List<NuevaAplicacionMVC.Models.Noticia> ObtenerNoticias()
        {
            var Noticia1 = new Noticia()
            {
                titulo = "Luke Rochold",
                imagen = "http://images.entertainment.ie/images_content/rectangle/620x372/LukeRockholdMain.jpg",
                contenido = "contenido contenido 1",
                autor = "Alberto"
            };
            var Noticia2 = new Noticia()
            {
                titulo = "Aldo vs Holloway 2",
                imagen = "https://usatmmajunkie.files.wordpress.com/2017/12/max-holloway-jose-aldo-ufc-2181.jpg",
                contenido = "contenido contenido2",
                autor = "Jose"
            };
            var Noticia3 = new Noticia()
            {
                titulo = "Yoel Romero el tipo que esta dando la verdadera para en las MMA",
                imagen = "http://assets2.sportsnet.ca/wp-content/uploads/2016/11/romero_yoel-1040x572.jpg",
                contenido = "yoel romero Yoel Romero yoel romero Yoel Romeroyoel romero Yoel Romero yoel romero Yoel Romeroyoel romero Yoel Romero yoel romero Yoel Romeroyoel romero Yoel Romeroyoel romero Yoel Romeroyoel romero Yoel Romeroyoel romero Yoel Romero yoel romero Yoel Romeroyoel romero Yoel Romeroyoel romero Yoel Romeroyoel romero Yoel Romero,yoel romero Yoel Romero. Yoel Romero yoel romero Yoel Romero yoel romero Yoel Romero yoel romero Yoel Romero yoel romero Yoel Romero.",
                autor = "Jose"
            };
            var Noticia4 = new Noticia()
            {
                titulo = "Cyborg vs Holm",
                imagen = "https://media.gettyimages.com/photos/cris-cyborg-of-brazil-and-holly-holm-face-off-during-the-ufc-219-picture-id899626056",
                contenido = "contenido contenido 4",
                autor = "Alberto"
            };
            var Noticia5 = new Noticia()
            {
                titulo = "Cyborg se la pone a Holm",
                imagen = "https://media.gettyimages.com/photos/cris-cyborg-of-brazil-punches-holly-holm-in-their-womens-bout-during-picture-id899974228",
                contenido = "contenido contenido 5",
                autor = "Maria"
            };
            var Noticia6 = new Noticia()
            {
                titulo = "Rumble Johnson deja loco a Manuwa de un golopon",
                imagen = "https://usatmmajunkie.files.wordpress.com/2015/09/anthony-johnson-jimi-manuwa-ufc-1911.jpg",
                contenido = "contenido contenido 6",
                autor = "Alberto"
            };
            return new List<Noticia> { Noticia1, Noticia2, Noticia3, Noticia4, Noticia5, Noticia6 };
        }
    }
}