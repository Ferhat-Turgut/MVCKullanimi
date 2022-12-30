using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MvcEgitimi.Models;

namespace MvcEgitimi.Controllers
{
    public class Mvc14CRUDController : Controller
    {
        UrunDBContext context = new UrunDBContext();
        // GET: Mvc14CRUD
        public ActionResult Index(string kelime)
        {
            if (!string.IsNullOrEmpty(kelime))
            {
                return View(context.Products.Where(p=>p.UrunAdi.Contains(kelime)).ToList());
            }
            
            return View(context.Products.ToList());
        }

        // GET: Mvc14CRUD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mvc14CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mvc14CRUD/Create
        [HttpPost]
        public ActionResult Create(Products products)
        {
            try
            {
                // TODO: Add insert logic here
                context.Products.Add(products);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mvc14CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.Products.Find(id));
        }

        // POST: Mvc14CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products products)
        {
            try
            {
                // TODO: Add update logic here
                context.Entry(products).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(products);
            }
        }

        // GET: Mvc14CRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Products.Find(id));
        }

        // POST: Mvc14CRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Products products)
        {
            try
            {
                // TODO: Add delete logic here
                var silinecekUrun = context.Products.Find(id);
                context.Products.Remove(silinecekUrun);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
