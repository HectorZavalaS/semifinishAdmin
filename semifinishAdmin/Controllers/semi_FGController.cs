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
    public class semi_FGController : Controller
    {
        private siixsem_wip_config_dbEntities db = new siixsem_wip_config_dbEntities();

        // GET: semi_FG
        public ActionResult Index()
        {
            var siixsem_semi_fg_td = db.siixsem_semi_fg_td.Include(s => s.siixsem_cgs_programs_t).Include(s => s.siixsem_models_t).Include(s => s.siixsem_semifinish_t);
            return View(siixsem_semi_fg_td.ToList());
        }

        // GET: semi_FG/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_semi_fg_td siixsem_semi_fg_td = db.siixsem_semi_fg_td.Find(id);
            if (siixsem_semi_fg_td == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_semi_fg_td);
        }

        // GET: semi_FG/Create
        public ActionResult Create()
        {
            ViewBag.se_id_cgs_prg = new SelectList(db.siixsem_cgs_programs_t, "se_id", "se_description");
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id", "se_description");
            ViewBag.se_id_fg = new SelectList(db.siixsem_semifinish_t, "se_id", "se_description");
            return View();
        }

        // POST: semi_FG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "se_id,se_id_model,se_id_fg,se_id_cgs_prg")] siixsem_semi_fg_td siixsem_semi_fg_td)
        {
            if (ModelState.IsValid)
            {
                db.siixsem_semi_fg_td.Add(siixsem_semi_fg_td);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.se_id_cgs_prg = new SelectList(db.siixsem_cgs_programs_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_cgs_prg);
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_model);
            ViewBag.se_id_fg = new SelectList(db.siixsem_semifinish_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_fg);
            return View(siixsem_semi_fg_td);
        }

        // GET: semi_FG/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_semi_fg_td siixsem_semi_fg_td = db.siixsem_semi_fg_td.Find(id);
            if (siixsem_semi_fg_td == null)
            {
                return HttpNotFound();
            }
            ViewBag.se_id_cgs_prg = new SelectList(db.siixsem_cgs_programs_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_cgs_prg);
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_model);
            ViewBag.se_id_fg = new SelectList(db.siixsem_semifinish_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_fg);
            return View(siixsem_semi_fg_td);
        }

        // POST: semi_FG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "se_id,se_id_model,se_id_fg,se_id_cgs_prg")] siixsem_semi_fg_td siixsem_semi_fg_td)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siixsem_semi_fg_td).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.se_id_cgs_prg = new SelectList(db.siixsem_cgs_programs_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_cgs_prg);
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_model);
            ViewBag.se_id_fg = new SelectList(db.siixsem_semifinish_t, "se_id", "se_description", siixsem_semi_fg_td.se_id_fg);
            return View(siixsem_semi_fg_td);
        }

        // GET: semi_FG/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_semi_fg_td siixsem_semi_fg_td = db.siixsem_semi_fg_td.Find(id);
            if (siixsem_semi_fg_td == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_semi_fg_td);
        }

        // POST: semi_FG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            siixsem_semi_fg_td siixsem_semi_fg_td = db.siixsem_semi_fg_td.Find(id);
            db.siixsem_semi_fg_td.Remove(siixsem_semi_fg_td);
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
