using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEgitimi.Controllers
{
    public class Mvc08ViewtoControllerController : Controller
    {
        // GET: Mvc08ViewtoController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String txt1,bool cbOnay, string ddliste)
        {
            //1.Yöntemde Request.Form ile View deki name ler ile değerleri yakalıyoruz.
            /*
            var txtbox = Request.Form["txt1"];
            var ddlist = Request.Form["ddliste"];
            var chb = Request.Form.GetValues("cbOnay")[0];

            ViewBag.mesaj ="TextBox Değeri:"+ txtbox;
            ViewData["ddlistesi"] ="DropDown List Değeri:"+ ddlist;
            
            if (chb=="true")
            {
                TempData["OnayDurumu"] = "Onay Durumu:Seçildi";
            }
            else
            {
                TempData["OnayDurumu"] = "Onay Durumu:Seçilmedi";
            }
            */
            //2.Yöntemde Action un aldığı parametreler ile çalışıyoruz.Not:parametreler View ile aynı olmalı.
            ViewBag.mesaj = "TextBox Değeri:" + txt1;
            ViewData["ddlistesi"] = "DropDown List Değeri:" + ddliste;

            if (cbOnay == true)
            {
                TempData["OnayDurumu"] = "Onay Durumu:Seçildi";
            }
            else
            {
                TempData["OnayDurumu"] = "Onay Durumu:Seçilmedi";
            }
            return View();
        }
    }
}