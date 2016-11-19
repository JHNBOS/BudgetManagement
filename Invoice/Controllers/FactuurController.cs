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
            var invoices = db.factuurs.Include(i => i.debiteuren).Include(j => j.producten);

            return View(invoices.OrderBy(o => o.Datum).ToList());
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

        private List<debiteuren> AvailableDebs()
        {
            var bezit = db.bezits.ToList();
            var debiteur = bezit.Select(d => d.Deb_ID).Distinct().ToList();

            List<debiteuren> debList = new List<debiteuren>();

            debiteuren empty = new debiteuren();
            empty.Voornaam = "";
            empty.Achternaam = "";
            empty.Email = "";
            empty.Telefoon = "";
            empty.Straat = "";
            empty.Nummer = "";
            empty.Postcode = "";
            empty.Plaats = "";
            empty.Land = "";

            debList.Add(empty);

            for (int i = 0; i < debiteur.Count; i++)
            {
                int ID = (int)debiteur[i];

                debiteuren deb = db.debiteurens.Where(d => d.ID == ID).SingleOrDefault();

                debList.Add(deb);
            }

            return debList;
        }

        private List<producten> AvailableProducts()
        {
            var bezit = db.bezits.ToList();
            var product = bezit.Select(d => d.Product_ID).ToList();

            List<producten> productList = new List<producten>();

            producten empty = new producten();
            empty.Naam = "";
            empty.Prijs = null;
            empty.BTW = null;
            empty.Beschrijving = "";

            productList.Add(empty);

            for (int i = 0; i < product.Count; i++)
            {
                int ID = (int)product[i];

                producten pro = db.productens.Where(d => d.ID == ID).SingleOrDefault();

                productList.Add(pro);
            }

            return productList;
        }

        // GET: Factuur/Create
        public ActionResult Create()
        {
            
            IEnumerable<SelectListItem> selectList = from c in AvailableDebs()
                                                     select new SelectListItem
                                                     {
                                                         Value = c.ID.ToString(),
                                                         Text = c.Voornaam + " " + c.Achternaam
                                                     };

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text");
            ViewBag.ProductList = AvailableProducts();

            return View();
        }

        // POST: Factuur/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Deb_ID,Product_ID,Prijs,Datum")] factuur factuur)
        {
            if (ModelState.IsValid)
            {
                db.factuurs.Add(factuur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            
            var debiteur = db.debiteurens.ToList();
            IEnumerable<SelectListItem> selectList = from c in debiteur
                                                     select new SelectListItem
                                                     {
                                                         Value = c.ID.ToString(),
                                                         Text = c.Voornaam + " " + c.Achternaam
                                                     };

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text", factuur.Deb_ID);
            ViewBag.ProductList = AvailableProducts();

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

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text", factuur.Deb_ID);
            ViewBag.Product_ID = new SelectList(selectList2, "Value", "Text", factuur.Product_ID);

            return View(factuur);
        }

        // POST: Factuur/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Deb_ID,Product_ID,Prijs,Datum")] factuur factuur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factuur).State = EntityState.Modified;
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

            ViewBag.Deb_ID = new SelectList(selectList, "Value", "Text", factuur.Deb_ID);
            ViewBag.Product_ID = new SelectList(selectList2, "Value", "Text", factuur.Product_ID);

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
