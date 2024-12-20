using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using semifinishAdmin.Models;

namespace semifinishAdmin.Controllers
{
    public class modelosController : Controller
    {
        private siixsem_wip_config_dbEntities db = new siixsem_wip_config_dbEntities();

        // GET: modelos
        public ActionResult Index()
        {
            return View(db.siixsem_models_t.ToList());
        }

        // GET: modelos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_models_t siixsem_models_t = db.siixsem_models_t.Find(id);
            if (siixsem_models_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_models_t);
        }

        // GET: modelos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: modelos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "se_id,se_description,se_serial_pn_1,se_serial_pn_2,se_serial_pn_3,se_serial_pn_4,se_serial_pn_5,se_created_date")] siixsem_models_t siixsem_models_t)
        {
            if (ModelState.IsValid)
            {
                db.siixsem_models_t.Add(siixsem_models_t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(siixsem_models_t);
        }

        // GET: modelos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_models_t siixsem_models_t = db.siixsem_models_t.Find(id);
            if (siixsem_models_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_models_t);
        }

        // POST: modelos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "se_id,se_description,se_serial_pn_1,se_serial_pn_2,se_serial_pn_3,se_serial_pn_4,se_serial_pn_5,se_created_date")] siixsem_models_t siixsem_models_t)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siixsem_models_t).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(siixsem_models_t);
        }

        // GET: modelos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_models_t siixsem_models_t = db.siixsem_models_t.Find(id);
            if (siixsem_models_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_models_t);
        }

        // POST: modelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            siixsem_models_t siixsem_models_t = db.siixsem_models_t.Find(id);
            db.siixsem_models_t.Remove(siixsem_models_t);
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
