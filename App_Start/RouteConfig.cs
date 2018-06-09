using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NuevaAplicacionMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Noticias", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NuevaNoticia",
                url: "NuevaNoticia",
                defaults: new { controller = "Noticia", action = "NuevaNoticia", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Imagen",
                url: "Imagen/{numeroImagen}",
                defaults: new { controller = "Home", action = "Imagen"}
            );
        }
    }
}