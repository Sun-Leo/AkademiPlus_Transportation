using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        DbTransportEntities db=new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();   
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var value = db.TblAbout.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.leftTitle1 = "Güvenli Taşımacılık";
            ViewBag.leftTitle2 = "Dünyanın Her Yerine Tüm Kargolar";
            ViewBag.leftTitle3 = "Konumu fark etmeksiniz, doğudan batıya, kuzeyden güneye en uzak noktalara uzman ekibimizle güvenli teslimat yapıyoruz.";
            ViewBag.rightTitle1 = "Taşıma Kolaylığı";
            ViewBag.rightTitle2 = "Kendi ambalajlarımızla kargolarınızı paketliyoruz.";
            ViewBag.rightTitle3 = "Şehir İçi Dağıtım";
            ViewBag.rightTitle4 = "İstediğiniz saatte evlerinize veya belirlediğiniz yere teslimat yapmaktayız.";
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            ViewBag.transportation = db.TblServices.Where(s => s.ServicesID == 1).Select(r => r.ServicesContent).FirstOrDefault();
            ViewBag.livemonitoring = db.TblServices.Where(l => l.ServicesID == 2).Select(m => m.ServicesContent).FirstOrDefault();
            ViewBag.worlwide = db.TblServices.Where(w => w.ServicesID == 3).Select(wr => wr.ServicesContent).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialGallery()
        {
            ViewBag.denizimage = db.TblGallery.Where(d => d.GalleryID == 1).Select(dz => dz.GalleryImage).FirstOrDefault();
            ViewBag.denizcontent = db.TblGallery.Where(dc => dc.GalleryID == 1).Select(dzc => dzc.GalleryContent).FirstOrDefault();
            ViewBag.havaimage = db.TblGallery.Where(h => h.GalleryID == 2).Select(hv => hv.GalleryImage).FirstOrDefault();
            ViewBag.havacontent = db.TblGallery.Where(hc => hc.GalleryID == 2).Select(hci => hci.GalleryContent).FirstOrDefault();
            ViewBag.kuryeimage = db.TblGallery.Where(k => k.GalleryID == 3).Select(kr => kr.GalleryImage).FirstOrDefault();
            ViewBag.kuryecontent = db.TblGallery.Where(kc => kc.GalleryID == 3).Select(krc => krc.GalleryContent).FirstOrDefault();
            ViewBag.karayoluimage = db.TblGallery.Where(kry => kry.GalleryID == 4).Select(kryl => kryl.GalleryImage).FirstOrDefault();
            ViewBag.karayolucontent = db.TblGallery.Where(kryc => kryc.GalleryID == 4).Select(krycn => krycn.GalleryContent).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialSubscribe()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
       
    }
}