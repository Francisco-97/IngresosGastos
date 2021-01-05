using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IngresosGastos.Data;
using IngresosGastos.Models;

namespace IngresosGastos.Controllers
{
    public class IngresosGastosController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: IngresosGastos
        public ActionResult Index()
        {
            return View(db.IngesosGastos.ToList());
        }

        // GET: IngresosGastos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngresosGastosFASS ingresosGastosFASS = db.IngesosGastos.Find(id);
            if (ingresosGastosFASS == null)
            {
                return HttpNotFound();
            }
            return View(ingresosGastosFASS);
        }

        // GET: IngresosGastos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngresosGastos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descripcion,EsIngresos,valor")] IngresosGastosFASS ingresosGastosFASS)
        {
            if (ModelState.IsValid)
            {
                db.IngesosGastos.Add(ingresosGastosFASS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingresosGastosFASS);
        }

        // GET: IngresosGastos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngresosGastosFASS ingresosGastosFASS = db.IngesosGastos.Find(id);
            if (ingresosGastosFASS == null)
            {
                return HttpNotFound();
            }
            return View(ingresosGastosFASS);
        }

        // POST: IngresosGastos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descripcion,EsIngresos,valor")] IngresosGastosFASS ingresosGastosFASS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingresosGastosFASS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingresosGastosFASS);
        }

        // GET: IngresosGastos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngresosGastosFASS ingresosGastosFASS = db.IngesosGastos.Find(id);
            if (ingresosGastosFASS == null)
            {
                return HttpNotFound();
            }
            return View(ingresosGastosFASS);
        }

        // POST: IngresosGastos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IngresosGastosFASS ingresosGastosFASS = db.IngesosGastos.Find(id);
            db.IngesosGastos.Remove(ingresosGastosFASS);
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
