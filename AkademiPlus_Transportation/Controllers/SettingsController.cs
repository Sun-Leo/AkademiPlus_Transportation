using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["UserName"];
            var uservalue = db.TblAdmin.Where(x => x.UserName == values.ToString()).FirstOrDefault();
            return View(uservalue);
        }
        [HttpPost]
        public ActionResult Index(TblAdmin tblAdmin)
        {
            var value = db.TblAdmin.Find(tblAdmin.AdminID);
            value.UserName= tblAdmin.UserName;
            value.Password= tblAdmin.Password;
            value.AdminRole= tblAdmin.AdminRole;
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}