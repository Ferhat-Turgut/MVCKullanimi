using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEgitimi.Models;
namespace MvcEgitimi.Controllers
{
    public class Mvc09ModelBindingController : Controller
    {
        // GET: Mvc09ModelBinding
        public ActionResult Index()
        {
            var SayfaModeli = new AnasayfaViewModel
            {
                AdresNesnesi =new Adres { Sehir="İstanbul",Ilce="Beşiktaş",AcikAdres="Pınar Mah."},
                KullaniciNesnesi =new Kullanici { Ad = "Ferhat", Soyad = "Turgut", Mail = "turgutferhat.ft@gmail.com",KullaniciAdi="Ft3065",Sifre="3065" }
            };
            return View(SayfaModeli);
        }
        public ActionResult Kullanici()
        {
            Kullanici Kullanici = new Kullanici() 
            {
                Ad="Ferhat", Soyad="Turgut",Mail="turgutferhat.ft@gmail.com"
            };                         
            
            return View(Kullanici);
        }
        [HttpPost]
        public ActionResult Kullanici(Kullanici Kullanici)
        {
            ViewBag.AdSifre = "Kullanıcı Adı =" + Kullanici.KullaniciAdi + " Şifresi= " + Kullanici.Sifre;
            ViewData["AdSoyad"] = "Ad=" + Kullanici.Ad + " Soyad=" + Kullanici.Soyad;
            TempData["Email"] = "Email=" + Kullanici.Mail;
            return View();
        }
        public ActionResult Adres()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adres(Adres adres)
        {
            ViewBag.Sehir = "Şehir =" + adres.Sehir;
            ViewData["Ilce"] = "İlçe=" + adres.Ilce;
            TempData["AcikAdres"] = "Açık Adres=" + adres.AcikAdres;
            return View();
        }
    }
}