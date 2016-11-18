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
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index()
        {
            return View(db.productens.OrderBy(o => o.Prijs).ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producten producten = db.productens.Find(id);
            if (producten == null)
            {
                return HttpNotFound();
            }
            return View(producten);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            var btw0 = new SelectListItem()
            {
                Value = "0",
                Text = "0%"
            };

            var btw6 = new SelectListItem()
            {
                Value = "6",
                Text = "6%"
            };

            var btw21 = new SelectListItem()
            {
                Value = "21",
                Text = "21%"
            };

            items.Add(btw0);
            items.Add(btw6);
            items.Add(btw21);
        
            ViewBag.btw = new SelectList(items, "Value", "Text");

            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Naam,Beschrijving,Prijs,BTW")] producten producten)
        {
            if (ModelState.IsValid)
            {
                db.productens.Add(producten);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<SelectListItem> items = new List<SelectListItem>();

            var btw0 = new SelectListItem()
            {
                Value = "0",
                Text = "0%"
            };

            var btw6 = new SelectListItem()
            {
                Value = "6",
                Text = "6%"
            };

            var btw21 = new SelectListItem()
            {
                Value = "21",
                Text = "21%"
            };

            items.Add(btw0);
            items.Add(btw6);
            items.Add(btw21);

            ViewBag.btw = new SelectList(items, "Value", "Text", producten.BTW);

            return View(producten);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producten producten = db.productens.Find(id);
            if (producten == null)
            {
                return HttpNotFound();
            }

            List<SelectListItem> items = new List<SelectListItem>();

            var btw0 = new SelectListItem()
            {
                Value = "0",
                Text = "0%"
            };

            var btw6 = new SelectListItem()
            {
                Value = "6",
                Text = "6%"
            };

            var btw21 = new SelectListItem()
            {
                Value = "21",
                Text = "21%"
            };

            items.Add(btw0);
            items.Add(btw6);
            items.Add(btw21);

            ViewBag.btw = new SelectList(items, "Value", "Text", producten.BTW);

            return View(producten);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Naam,Beschrijving,Prijs,BTW")] producten producten)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producten).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<SelectListItem> items = new List<SelectListItem>();

            var btw0 = new SelectListItem()
            {
                Value = "0",
                Text = "0%"
            };

            var btw6 = new SelectListItem()
            {
                Value = "6",
                Text = "6%"
            };

            var btw21 = new SelectListItem()
            {
                Value = "21",
                Text = "21%"
            };

            items.Add(btw0);
            items.Add(btw6);
            items.Add(btw21);

            ViewBag.btw = new SelectList(items, "Value", "Text", producten.BTW);

            return View(producten);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producten producten = db.productens.Find(id);
            if (producten == null)
            {
                return HttpNotFound();
            }
            return View(producten);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            producten producten = db.productens.Find(id);
            db.productens.Remove(producten);
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
