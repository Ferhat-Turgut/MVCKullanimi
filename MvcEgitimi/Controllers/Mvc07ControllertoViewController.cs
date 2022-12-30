using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEgitimi.Controllers
{
    public class Mvc07ControllertoViewController : Controller
    {
        // GET: Mvc07ControllertoView
        public ActionResult Index()
        {
            ViewBag.KategoriAdi = "Bilgisayar";
            ViewData["UrunAdi"] = "Lenovo Laptop";
            TempData["UrunFiyat"] = 4850;
            return View();
        }
    }
}