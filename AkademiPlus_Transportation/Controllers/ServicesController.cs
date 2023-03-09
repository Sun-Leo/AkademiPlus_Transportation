using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeatures()
        {
            return PartialView();   
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}