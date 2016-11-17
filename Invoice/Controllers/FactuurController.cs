using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Invoice;
using Invoice.Models;

namespace Invoice.Controllers
{
    public class FactuurController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Factuur
        public ActionResult Index()
        {
            return View(db.factuurs.ToList());
        }

        // GET: Factuur/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            factuur factuur = db.factuurs.Find(id);
            if (factuur == null)
            {
                return HttpNotFound();
            }
            return View(factuur);
        }

        // GET: Factuur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Factuur/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Bezit_ID")] factuur factuur)
        {
            if (ModelState.IsValid)
            {
                db.factuurs.Add(factuur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(factuur);
        }

        // GET: Factuur/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            factuur factuur = db.factuurs.Find(id);
            if (factuur == null)
            {
                return HttpNotFound();
            }
            return View(factuur);
        }

        // POST: Factuur/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Bezit_ID")] factuur factuur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factuur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(factuur);
        }

        // GET: Factuur/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            factuur factuur = db.factuurs.Find(id);
            if (factuur == null)
            {
                return HttpNotFound();
            }
            return View(factuur);
        }

        // POST: Factuur/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            factuur factuur = db.factuurs.Find(id);
            db.factuurs.Remove(factuur);
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
