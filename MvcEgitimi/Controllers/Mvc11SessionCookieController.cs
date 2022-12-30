using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEgitimi.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["kullanici"]!=null)
            {
                ViewBag.kukiDeger = HttpContext.Request.Cookies["kullanici"].Value;
            }
            return View();
        }
        public ActionResult Sessions()
        {
            if (Session["deger"]!=null)
            {
                ViewBag.SessDeger ="Session ="+ Session["deger"];
            }
            else
            {
                ViewBag.SessDeger = "Session Girilmedi.";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Sessions(string text)
        {
            if (Session["deger"] != null)
            {
                Session.Remove("deger");
                // diğer yöntem
                // Session["deger"] = null;
            }
            else
            {
                ViewBag.SessDeger = "Session Girilmedi.";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            Session["deger"] = text;
            // diğer kullanım
            // Session.Add("deger",text);
            return View();
        }

        [HttpPost]
        public ActionResult CookieOlustur(string kuki)
        {
            HttpCookie cookie = new HttpCookie("kullanici","kuki1"); // Cookie oluşturma
            HttpContext.Response.Cookies.Add(cookie);//Oluşturulan Cookie yi cihaza atma
            ViewBag.Kullanici = HttpContext.Request.Cookies["kullanici"].Value; //Oluşan Cookie yi cihazdan okuma
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["kullanici"] != null)
            {
                HttpContext.Response.Cookies["kullanici"].Expires = DateTime.Now.AddSeconds(-3); //Cookie varsa şuandan 3 saniye önde bitir.(sil)
                ViewBag.Kullanici = "Cookie Silindi";
            }


            return RedirectToAction("Index"); // View("Index");
        }
    }
}