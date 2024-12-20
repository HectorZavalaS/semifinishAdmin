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
    public class cgsProgramsController : Controller
    {
        private siixsem_wip_config_dbEntities db = new siixsem_wip_config_dbEntities();

        // GET: cgsPrograms
        public ActionResult Index()
        {
            return View(db.siixsem_cgs_programs_t.ToList());
        }

        // GET: cgsPrograms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_cgs_programs_t siixsem_cgs_programs_t = db.siixsem_cgs_programs_t.Find(id);
            if (siixsem_cgs_programs_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_cgs_programs_t);
        }

        // GET: cgsPrograms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cgsPrograms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "se_id,se_description,se_bin")] siixsem_cgs_programs_t siixsem_cgs_programs_t)
        {
            if (ModelState.IsValid)
            {
                db.siixsem_cgs_programs_t.Add(siixsem_cgs_programs_t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(siixsem_cgs_programs_t);
        }

        // GET: cgsPrograms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_cgs_programs_t siixsem_cgs_programs_t = db.siixsem_cgs_programs_t.Find(id);
            if (siixsem_cgs_programs_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_cgs_programs_t);
        }

        // POST: cgsPrograms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "se_id,se_description,se_bin")] siixsem_cgs_programs_t siixsem_cgs_programs_t)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siixsem_cgs_programs_t).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(siixsem_cgs_programs_t);
        }

        // GET: cgsPrograms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_cgs_programs_t siixsem_cgs_programs_t = db.siixsem_cgs_programs_t.Find(id);
            if (siixsem_cgs_programs_t == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_cgs_programs_t);
        }

        // POST: cgsPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            siixsem_cgs_programs_t siixsem_cgs_programs_t = db.siixsem_cgs_programs_t.Find(id);
            db.siixsem_cgs_programs_t.Remove(siixsem_cgs_programs_t);
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
