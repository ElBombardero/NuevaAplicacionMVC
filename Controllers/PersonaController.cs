using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Models;

namespace NuevaAplicacionMVC.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Persona(){
            Persona arreglo = new Persona();
            int ProbarSiEsNumero = 0;
            String letra = Request.Form["edad"];
            bool canConvert = int.TryParse(letra, out ProbarSiEsNumero);
            if (canConvert== true ){
                arreglo.edad = Convert.ToInt32(Request.Form["edad"].ToString());
                arreglo.nombre = Request.Form["nombre"].ToString();
                arreglo.apellido = Request.Form["apellido"].ToString();
                return View(arreglo);
            }            
            return View("Mensaje");
        }

        public ActionResult Mensaje(){
            return View();
        }

        public ActionResult index() {
            return View();
        }

        public ActionResult formulario(){
            return View();
        }

        public ActionResult Datos(){
            return View();
        }
    }
}
