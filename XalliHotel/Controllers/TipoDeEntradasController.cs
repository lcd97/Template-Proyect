using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XalliHotel.Models;

namespace XalliHotel.Controllers
{
    public class TipoDeEntradasController : Controller
    {
        private Hotel db = new Hotel();

        // GET: TipoDeEntradas
        public ActionResult Index()
        {
            return View(db.TiposDeEntrada.ToList());
        }

        // GET: TipoDeEntradas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeEntrada tipoDeEntrada = db.TiposDeEntrada.Find(id);
            if (tipoDeEntrada == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeEntrada);
        }

        // GET: TipoDeEntradas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeEntradas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,codTE,descTE,estadoTE")] TipoDeEntrada tipoDeEntrada)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeEntrada.Add(tipoDeEntrada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDeEntrada);
        }

        // GET: TipoDeEntradas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeEntrada tipoDeEntrada = db.TiposDeEntrada.Find(id);
            if (tipoDeEntrada == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeEntrada);
        }

        // POST: TipoDeEntradas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,codTE,descTE,estadoTE")] TipoDeEntrada tipoDeEntrada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDeEntrada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDeEntrada);
        }

        // GET: TipoDeEntradas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeEntrada tipoDeEntrada = db.TiposDeEntrada.Find(id);
            if (tipoDeEntrada == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeEntrada);
        }

        // POST: TipoDeEntradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeEntrada tipoDeEntrada = db.TiposDeEntrada.Find(id);
            db.TiposDeEntrada.Remove(tipoDeEntrada);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
