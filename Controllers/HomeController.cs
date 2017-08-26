using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Models;

namespace NuevaAplicacionMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArticuloPosteado(){
            return View();
        }

        public ActionResult PostearArticulo(){
            return View();
        }

        public ActionResult NuevaNoticia(){
            Noticia articulo = new Noticia();
            if (Request.Form["Titulo"]!= ""){                
                articulo.Titulo = Request.Form ["Titulo"].ToString();
                articulo.Imagen =Request.Form ["Imagen"].ToString();
                articulo.Contenido =Request.Form ["Contenido"].ToString();
                return View(articulo);
            }
            return RedirectToAction("Mensaje", "Persona");
        }

        public ActionResult Foro(){
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
