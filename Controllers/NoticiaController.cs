using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Models;
using NuevaAplicacionMVC.Services;

namespace NuevaAplicacionMVC.Controllers
{
    public class NoticiaController : Controller
    {
        //
        // GET: /Noticia/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuevaNoticia()
        {

            var NoticiasService = new NoticiasService();
            if (Request["titulo"] != "")
            {
                var titulo = Request["titulo"].ToString();
                var imagen = Request["imagen"].ToString();
                var contenido = Request["contenido"].ToString();

                var modelo = NoticiasService.ObtenerNoticia(titulo, imagen, contenido);
                return View(modelo);
            }
            return RedirectToAction("Mensaje", "Persona");
        }

        public ActionResult PostearNoticia()
        {
            return View();
        }

        public ActionResult create() {
            return View();
        }

    }
}
