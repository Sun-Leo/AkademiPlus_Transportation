using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    [Authorize]
    public class AdminMainPageController : Controller
    {
        // GET: AdminMainPage
        DbTransportEntities db = new DbTransportEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}