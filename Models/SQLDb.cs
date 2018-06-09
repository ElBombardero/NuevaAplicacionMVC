using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NuevaAplicacionMVC.Models
{
    public class SQLDb : DbContext
    {
        public SQLDb() : base("name=MMAnewEntities1")
        {

        }
        public DbSet<noticias> Noticias { get; set; }
    }
}