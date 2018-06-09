using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NuevaAplicacionMVC.Helpers
{
    public static class HTMLHelpers
    {
        public static string limitar(this HtmlHelper helper, string valor, int limite)
        {
            if(valor.Length <= limite){
                return valor;
            }else{
                return valor.Substring(0, limite) + "...";
            }
        }
    }
}