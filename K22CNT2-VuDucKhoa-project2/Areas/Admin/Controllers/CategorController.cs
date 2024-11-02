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
             
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}