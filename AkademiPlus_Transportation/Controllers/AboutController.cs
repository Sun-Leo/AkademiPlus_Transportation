using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutPage()
        {
            return PartialView();
        }
        public PartialViewResult PartialTeam()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuestions()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}