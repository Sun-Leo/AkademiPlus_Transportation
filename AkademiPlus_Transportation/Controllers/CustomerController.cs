using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        DbTransportEntities db=new DbTransportEntities();

        //var values = db.TblCustomer.Where(x=>x.CustomerCity=="Ankara").Tolist(); kod kısmında arama işlemi yapabiliriz.

        public ActionResult Index()
        {
            var values = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").ToList();
            
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            
            return View();    
        }
        [HttpPost]
        public ActionResult AddCustomer(TblCustomer tblCustomer)
        {
            db.TblCustomer.Add(tblCustomer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var value = db.TblCustomer.Find(id);
            db.TblCustomer.Remove(value);   
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var value = db.TblCustomer.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(TblCustomer cs)
        {
            var value = db.TblCustomer.Find(cs.CustomerID);
            value.CustomerName = cs.CustomerName;
            value.CustomerSurname = cs.CustomerSurname;
            value.CustomerCity = cs.CustomerCity;
            value.CustomerPhone = cs.CustomerPhone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}