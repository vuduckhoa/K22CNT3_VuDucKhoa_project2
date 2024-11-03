using K22CNT2_VuDucKhoa_project2.Models;
using K22CNT2_VuDucKhoa_project2.Models.EF;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K22CNT2_VuDucKhoa_project2.Areas.Admin.Controllers
{
    public class CategorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Categor
        public ActionResult Index()
        {
            var items = db.Categors;
            return View(items);
        }
        public ActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Categor model) 
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = K22CNT2_VuDucKhoa_project2.Models.Commons.Filter.FilterChar(model.Title);
                db.Categors.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = db.Categors.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categor model)
        {
            if (ModelState.IsValid)
            {
                db.Categors.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.Alias = K22CNT2_VuDucKhoa_project2.Models.Commons.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x=>x.Title).IsModified=true;
                db.Entry(model).Property(x=>x.Descriptio).IsModified=true;
                db.Entry(model).Property(x=>x.Alias).IsModified=true;
                db.Entry(model).Property(x=>x.SeoDescriptio).IsModified=true;
                db.Entry(model).Property(x=>x.SeoKeyWords).IsModified=true;
                db.Entry(model).Property(x=>x.SeoTitle).IsModified=true;
                db.Entry(model).Property(x=>x.Position).IsModified=true;
                db.Entry(model).Property(x=>x.ModifiedDate).IsModified=true;
                db.Entry(model).Property(x=>x.ModifierBy).IsModified=true;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categors.Find(id);
            if (item == null)
            {
                //var DeleteItem=db.Set<Categor>.Attach(item);//
                db.Categors.Remove(item);
                db.SaveChanges();
                return Json(new { success=true });
            }
            return Json(new { success = false });

        }
    }
}