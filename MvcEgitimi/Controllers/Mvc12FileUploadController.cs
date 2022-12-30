using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcEgitimi.Controllers
{
    public class Mvc12FileUploadController : Controller
    {
        // GET: Mvc12FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase YuklenecekDosya)
        {
            if (YuklenecekDosya!=null && YuklenecekDosya.ContentLength>0)
            {
                var extension = Path.GetExtension(YuklenecekDosya.FileName);
                if (extension == ".jpg" || extension == ".png")
                {
                    //1.Yöntem-> Rastgele dosya adı oluşturularak yükleme
                    //var folder = Server.MapPath("/Images"); //Kayıt yolu
                    //var randomFileName = Path.GetRandomFileName(); //Rastgele dosya ismi oluşturma
                    //var fileName = Path.ChangeExtension(randomFileName, extension); //Dosya adı ile Uzantısını birleştirerek dosya isminin son halini oluşturur.

                    //var path = Path.Combine(folder, fileName);

                    //2.Yöntem-> Yüklenen dosya adı ile yükleme

                    var fileName = Path.GetFileName(YuklenecekDosya.FileName);
                    var path = Path.Combine(Server.MapPath("/Images"),fileName);

                    YuklenecekDosya.SaveAs(path);
                    ViewBag.ResimAdi = fileName;
                }
                else ViewData["message"] = "Yüklenecek dosya .jpg veya .png formatında olmalıdır!";
            }
            return View();
        }
    }
}