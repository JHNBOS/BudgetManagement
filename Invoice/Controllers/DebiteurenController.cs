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
    public class DebiteurenController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Debiteuren
        public ActionResult Index()
        {
            return View(db.debiteurens.ToList());
        }

        // GET: Debiteuren/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debiteuren debiteuren = db.debiteurens.Find(id);
            if (debiteuren == null)
            {
                return HttpNotFound();
            }
            return View(debiteuren);
        }

        // GET: Debiteuren/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Debiteuren/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Voornaam,Achternaam,Straat,Nummer,Postcode,Plaats,Land,Email,Telefoon")] debiteuren debiteuren)
        {
            if (ModelState.IsValid)
            {
                db.debiteurens.Add(debiteuren);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(debiteuren);
        }

        // GET: Debiteuren/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debiteuren debiteuren = db.debiteurens.Find(id);
            if (debiteuren == null)
            {
                return HttpNotFound();
            }
            return View(debiteuren);
        }

        // POST: Debiteuren/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Voornaam,Achternaam,Straat,Nummer,Postcode,Plaats,Land,Email,Telefoon")] debiteuren debiteuren)
        {
            if (ModelState.IsValid)
            {
                db.Entry(debiteuren).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(debiteuren);
        }

        // GET: Debiteuren/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debiteuren debiteuren = db.debiteurens.Find(id);
            if (debiteuren == null)
            {
                return HttpNotFound();
            }
            return View(debiteuren);
        }

        // POST: Debiteuren/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            debiteuren debiteuren = db.debiteurens.Find(id);
            db.debiteurens.Remove(debiteuren);
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
