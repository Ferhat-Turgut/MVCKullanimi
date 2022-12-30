using MvcEgitimi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcEgitimi.Controllers
{
    public class Mvc13ViewResultController : Controller
    {
        // GET: Mvc13ViewResult
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()
        {
            //return Redirect("/Home/Index/");
            return Redirect("https://www.google.com.tr/");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToRoute("Default", new
            {
                controller = "Home",
                action = "About",
                id = 4
            });
        }
        public PartialViewResult KategorileriPartiallaGetir()
        {
            return PartialView("_KategorilerPartial");
        }
        public PartialViewResult KategorileriModelPartiallaGetir()
        {
            List<string> kategoriler = new List<string>()
{
            "Monitörler",
            "Laptoplar",
            "Bilgisayarlar",
            "Mouselar",
            "Kulaklıklar"
            };

            return PartialView("_KategorilerPartial2", kategoriler);
        }
        public FileResult PdfDosyaIndir()
        {
            string DosyaYolu = Server.MapPath("/Pdf/ÖrnekPdf.pdf");
            return new FilePathResult(DosyaYolu, "application/pdf");
        }
        public FileStreamResult MetinDosyasiIndir()
        {
            string metin = "FileResult ile MetinDosyasiIndir";
            MemoryStream memory = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(metin);

            memory.Write(bytes, 0, bytes.Length);
            memory.Position = 0;

            FileStreamResult result = new FileStreamResult(memory, "text/plain");
            result.FileDownloadName = "deneme.txt";

            return result;
        }

        public JavaScriptResult JsResult()
        {
            string js = "alert('JsResult Çalıştı')";
            return JavaScript(js);
        }
        public JavaScriptResult JsButtonClick()
        {
            string js = "function button_click(){alert('JsButtonClick Çalıştı')}";
            return JavaScript(js);
        }
        public JsonResult Index4()
        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Ferhat",
                Soyad = "Turgut",
                KullaniciAdi = "abcde",
                Sifre = "asdf"
            };

            /* Örnek Json Çıktısı
               {
                   "Id":1,
                   "Ad":"Ferhat",
                   "Soyad":"Turgut",
                   "Mail":null,
                   "KullaniciAdi":"abcde",
                   "Sifre":"asdf"
               }

            Örnek Xml Çıktısı
               <kullanici>
                   <Id>1</Id>
                   <Ad>Ferhat</Ad>
                   <Soyad>Turgut</Soyad>
                   <Mail>null</Mail>
                   <KullaniciAdi>abcde</KullaniciAdi>
                   <Sifre>asdf</Sifre>
               </kullanici>
                */
            return Json(kullanici, JsonRequestBehavior.AllowGet);
        }
        public ContentResult XmlContentResult()
        {
            var xml = @"            
             <Kullanici>
                    < Id > 1 </ Id >
                    < Ad > Ferhat </ Ad >
                    < Soyad > Turgut </ Soyad >
                    < Mail > null </ Mail >
                    < KullaniciAdi > abcde </ KullaniciAdi >
                    < Sifre > asdf </ Sifre >
             </Kullanici>";
             //<Kullanici>
             //       < Id > 2 </ Id >
             //       < Ad > Aylin </ Ad >
             //       < Soyad > Köse </ Soyad >
             //       < Mail > null </ Mail >
             //       < KullaniciAdi > abcde </ KullaniciAdi >
             //       < Sifre > asdf </ Sifre >
             //</Kullanici>";
            

            return Content(xml, "application/xml");
        }
    }
}