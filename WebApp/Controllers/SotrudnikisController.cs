using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp;

namespace WebApp.Controllers
{
    public class SotrudnikisController : Controller
    {
        private OooPs14_dbEntities db = new OooPs14_dbEntities();

        // GET: Sotrudnikis
        public ActionResult Index()
        {
            var sotrudnikis = db.Sotrudnikis.Include(s => s.Dolzhnosti).Include(s => s.Otdely);
            return View(sotrudnikis.ToList());
        }

        // GET: Sotrudnikis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudnikis.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            return View(sotrudniki);
        }

        // GET: Sotrudnikis/Create
        public ActionResult Create()
        {
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnostis, "id_dolzhn", "name_dolzhn");
            ViewBag.id_otd = new SelectList(db.Otdelies, "id_otd", "name_otd");
            return View();
        }

        // POST: Sotrudnikis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_sotr,name_sotr,lastname_sotr,adress_sotr,email_sotr,phone_sotr,id_otd,data_priema,id_dolzhn")] Sotrudniki sotrudniki)
        {
            if (ModelState.IsValid)
            {
                db.Sotrudnikis.Add(sotrudniki);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_dolzhn = new SelectList(db.Dolzhnostis, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdelies, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // GET: Sotrudnikis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudnikis.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnostis, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdelies, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // POST: Sotrudnikis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_sotr,name_sotr,lastname_sotr,adress_sotr,email_sotr,phone_sotr,id_otd,data_priema,id_dolzhn")] Sotrudniki sotrudniki)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sotrudniki).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnostis, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdelies, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // GET: Sotrudnikis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudnikis.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            return View(sotrudniki);
        }

        // POST: Sotrudnikis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sotrudniki sotrudniki = db.Sotrudnikis.Find(id);
            db.Sotrudnikis.Remove(sotrudniki);
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
