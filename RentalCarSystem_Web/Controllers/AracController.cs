using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarSystem_Web.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Yeni()
        {
            return View("AracForm");
        }
        [HttpPost]
        public ActionResult Kaydet(/*Arac arac*/)
        {
            /* if (arac.Arac_ID == 0)
             {
                 db.Arac.Add(arac);
             }
             else
             {
                 var guncellenecekArac = db.Arac.Find(arac.Id);
                 if (guncellenecekArac== null)
                 {
                     return HttpNotFound();
                 }
                 guncellenecekArac.Ad = arac.Ad;
             }
             db.SaveChanges();*/
            return RedirectToAction("Index", "Arac");
        }
        public ActionResult Guncelle(int id)
        {
            /* var model = db.Musteri.Find(id);
            if (model == null)
                return HttpNotFound();*/
            return View("AracForm"/*,model*/);
        }
        public ActionResult Sil(int id)
        {
            /*
            var silinecekDepartman = db.Departman.Find(id);
            if (silinecekDepartman == null)
                return HttpNotFound();
            db.Departman.Remove(silinecekDepartman);
            db.SaveChanges();
            */
            return RedirectToAction("Index");
        }
    }
}