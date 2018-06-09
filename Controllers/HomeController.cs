using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Models;
using NuevaAplicacionMVC.Services;

namespace NuevaAplicacionMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var NoticiasService = new NoticiasService();
            var modelo = NoticiasService.ObtenerNoticias();
            return View(modelo);
        }

        public ActionResult ArticuloPosteado(){
            return View();
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

        public ActionResult Imagen(int numeroImagen)
        {
            var imagen = numeroImagen + numeroImagen;
            ViewBag.Imagen = imagen;
            return View();
        }
    }
}
