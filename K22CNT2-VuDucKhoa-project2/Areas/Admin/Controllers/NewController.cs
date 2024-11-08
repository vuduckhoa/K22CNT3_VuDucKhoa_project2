using K22CNT2_VuDucKhoa_project2.Models;
using K22CNT2_VuDucKhoa_project2.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K22CNT2_VuDucKhoa_project2.Areas.Admin.Controllers
{
    public class NewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/New
        public ActionResult Index()
        {
            var items=db.News.OrderByDescending(x=>x.Id).ToList();
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(New model)
        {
            if(ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.Categorid = 3;
                model.ModifiedDate= DateTime.Now;
                model.Alias= K22CNT2_VuDucKhoa_project2.Models.Commons.Filter.FilterChar(model.Titel);
                db.News.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}