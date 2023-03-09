﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var value1 = db.TblCustomer.Count();
            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.citySelect = db.TblCustomer.Where(x => x.CustomerID == 2).Select(y => y.CustomerCity).FirstOrDefault();
            ViewData["Deger"] = "Gizem Emniyetli";
            ViewBag.transportation = db.TblAbout.Where(t => t.AboutID == 2).Select(r => r.AboutContent).FirstOrDefault();
            return View();
        }
    }
}