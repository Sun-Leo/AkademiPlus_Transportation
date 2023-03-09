using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        // GET: Category
        DbTransportEntities db = new DbTransportEntities();

        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory p)
        {
            var ktg = db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory kt)
        {
            var value = db.TblCategory.Find(kt.CategoryID);
            value.CategoryName = kt.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}