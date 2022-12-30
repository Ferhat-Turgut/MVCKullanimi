using MvcEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEgitimi.Controllers
{
    public class Mvc10ModelValidationController : Controller
    {
        // GET: Mvc10ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UyeBilgileri = $"Üye Adı:{uye.Ad} <hr> Üye Soyadı:{uye.Soyad} <hr> Email:{uye.Mail}" +
                    $" <hr> Üye TC:{uye.TCKimlikNo} <hr> Kullanıcı Adı:{uye.KullaniciAdi} <hr> Şifre:{uye.Sifre} <hr> Doğum Tarihi:{uye.DogumTarihi} <hr>"  ;
            }
            return View();
        }
        public ActionResult UyeDuzenle(int id)
        {
            Uye uye = new Uye() 
            {
                Ad="Ferhat",Soyad="Turgut",Mail="turgutferhat.ft@gmail.com",DogumTarihi="27.02.1995"
            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult UyeDuzenle(Uye uye)
        {
            
            return View(uye);
        }
        public ActionResult UyeListele()
        {
            var UyeListesi = new List<Uye>() 
            {
            new Uye(){Ad="Ferhat",Soyad="Turgut",Mail="turgutferhat.ft@gmail.com",DogumTarihi="27.02.1995"},
            new Uye(){Ad="Yusuf",Soyad="Aslan",Mail="Yusuf@gmail.com",DogumTarihi="27.02.1997"},
            new Uye(){Ad="Aylin",Soyad="Köse",Mail="Aylin@gmail.com",DogumTarihi="27.02.1992"},

        };
            return View(UyeListesi);
        }

        public ActionResult UyeSil(int id)
        {
            Uye uye = new Uye() {Id=id, Ad = "Ferhat", Soyad = "Turgut", Mail = "turgutferhat.ft@gmail.com", DogumTarihi = "27.02.1995" };
            

            return View(uye);
        }
    }
}