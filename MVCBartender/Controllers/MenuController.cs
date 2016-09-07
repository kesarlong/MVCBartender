using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{ 
    public class MenuController : Controller
    {
        private MVCBartenderContext db = new MVCBartenderContext();
        // GET: Menu
        public ActionResult Index()
        {
            var data = db.Cocktails.Select(p => p).OrderBy(p => p.CocktailName);
            return View(data);
        }
    }
}