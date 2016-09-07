using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{
    public class CocktailsController : Controller
    {
        private MVCBartenderContext db = new MVCBartenderContext();

        // GET: Cocktails
        public ActionResult Index()
        {
            return View(db.Cocktails.ToList());
        }

        // GET: Cocktails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cocktail cocktail = db.Cocktails.Find(id);
            if (cocktail == null)
            {
                return HttpNotFound();
            }
            return View(cocktail);
        }

        // GET: Cocktails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cocktails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CocktailID,CocktailName,Description,Price,Image")] Cocktail cocktail)
        {
            if (ModelState.IsValid)
            {
                db.Cocktails.Add(cocktail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cocktail);
        }

        // GET: Cocktails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cocktail cocktail = db.Cocktails.Find(id);
            if (cocktail == null)
            {
                return HttpNotFound();
            }
            return View(cocktail);
        }

        // POST: Cocktails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CocktailID,CocktailName,Description,Price,Image")] Cocktail cocktail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cocktail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cocktail);
        }

        // GET: Cocktails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cocktail cocktail = db.Cocktails.Find(id);
            if (cocktail == null)
            {
                return HttpNotFound();
            }
            return View(cocktail);
        }

        // POST: Cocktails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cocktail cocktail = db.Cocktails.Find(id);
            db.Cocktails.Remove(cocktail);
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
