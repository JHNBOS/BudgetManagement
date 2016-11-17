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
    public class ToewijzenController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private List<debiteuren> AvailableDebs()
        {
            var debiteur = db.debiteurens.ToList();

            return debiteur;
        }

        private List<producten> AvailableProducts()
        {
            var product = db.productens.ToList();

            return product;
        }

       
        // GET: Toewijzen
        public ActionResult Index()
        {
            var bezitproduct = db.bezits.Include(c => c.debiteuren).Include(c => c.producten);

            return View(bezitproduct.ToList());
        }

        // GET: Toewijzen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bezit bezit = db.bezits.Find(id);
            if (bezit == null)
            {
                return HttpNotFound();
            }
            return View(bezit);
        }

        // GET: Toewijzen/Create
        public ActionResult Create()
        {
            bezit Bezit = new bezit();

            IEnumerable<SelectListItem> selectList = from c in AvailableDebs()
                                                     select new SelectListItem
                                                     {
                                                         Value = c.ID.ToString(),
                                                         Text = c.Voornaam + " " + c.Achternaam
                                                     };

            IEnumerable<SelectListItem> selectList2 = from c in AvailableProducts()
                                                      select new SelectListItem
                                                      {
                                                          Value = c.ID.ToString(),
                                                          Text = c.Naam
                                                      };

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text");
            ViewBag.Product_ID = new SelectList(selectList2, "Value", "Text");

            return View();
        }

        // POST: Toewijzen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Deb_ID,Product_ID")] bezit bezit)
        {
            
            if (ModelState.IsValid)
            {
                db.bezits.Add(bezit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            IEnumerable<SelectListItem> selectList = from c in AvailableDebs()
                                                     select new SelectListItem
                                                     {
                                                         Value = c.ID.ToString(),
                                                         Text = c.Voornaam + " " + c.Achternaam
                                                     };

            IEnumerable<SelectListItem> selectList2 = from c in AvailableProducts()
                                                      select new SelectListItem
                                                      {
                                                          Value = c.ID.ToString(),
                                                          Text = c.Naam
                                                      };

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text", bezit.Deb_ID);
            ViewBag.Product_ID = new SelectList(selectList2, "Value", "Text", bezit.Product_ID);

            return View(bezit);
        }

        // GET: Toewijzen/Edit/5
        public ActionResult Edit(int? id)
        {
            bezit Bezit = new bezit();

            ViewBag.product = new SelectList(db.productens, "ID", "Naam", Bezit.Product_ID);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bezit bezit = db.bezits.Find(id);
            if (bezit == null)
            {
                return HttpNotFound();
            }
            return View(bezit);
        }

        // POST: Toewijzen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Deb_ID,Product_ID")] bezit bezit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bezit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bezit);
        }

        // GET: Toewijzen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bezit bezit = db.bezits.Find(id);
            if (bezit == null)
            {
                return HttpNotFound();
            }
            return View(bezit);
        }

        // POST: Toewijzen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bezit bezit = db.bezits.Find(id);
            db.bezits.Remove(bezit);
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
