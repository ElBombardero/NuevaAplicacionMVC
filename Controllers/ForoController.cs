using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Services;
using NuevaAplicacionMVC.Helpers;

namespace NuevaAplicacionMVC.Controllers
{
    public class ForoController : Controller
    {
        //
        // GET: /Foro/

        public ActionResult Index()
        {
            var DebateService = new DebateService();
            var Debates = DebateService.ObtenerDebate();
            return View(Debates);
        }

    }
}
