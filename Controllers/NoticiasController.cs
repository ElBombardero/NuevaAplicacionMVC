using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevaAplicacionMVC.Models;

namespace NuevaAplicacionMVC.Controllers
{
    public class NoticiasController : Controller
    {
        private NuevaAplicacionMVCContext db = new NuevaAplicacionMVCContext();
        private SQLDb SQL = new SQLDb();

        //
        // GET: /Noticias/

        public ActionResult Index()
        {
            return View(SQL.Noticias.ToList());
        }

        public ActionResult noticiasDB() {
            return View(SQL.Noticias.ToList());
        }

        public ActionResult verArticulo(int id = 0)
        {
            ViewBag.id = id;
            noticias noticias = SQL.Noticias.Find(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        public ActionResult CrearArticulo(string id)
        {
            ViewBag.Admin = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearArticulo(noticias noticia)
        {
            if (ModelState.IsValid)
            {
                SQL.Noticias.Add(noticia);
                SQL.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noticia);
        }

        //
        // GET: /Noticias/Details/5

        public ActionResult Details(int id = 0)
        {
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        //
        // GET: /Noticias/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Noticias/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.Noticias.Add(noticia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        //
        // GET: /Noticias/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        //
        // POST: /Noticias/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noticia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noticia);
        }

        //
        // GET: /Noticias/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Noticia noticia = db.Noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        //
        // POST: /Noticias/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Noticia noticia = db.Noticias.Find(id);
            db.Noticias.Remove(noticia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}