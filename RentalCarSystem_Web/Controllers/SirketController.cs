using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarSystem_Web.Controllers
{
    public class SirketController : Controller
    {
        // GET: Sirket
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Yeni()
        {
            return View("SirketForm");
        }
        [HttpPost]
        public ActionResult Kaydet(/*Sirket sirket*/)
        {
            /* if (sirket.Sirket_ID == 0)
             {
                 db.Sirket.Add(arac);
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
            return RedirectToAction("Index", "Sirket");
        }
        public ActionResult Guncelle(int id)
        {
            /* var model = db.Musteri.Find(id);
            if (model == null)
                return HttpNotFound();*/
            return View("SirketForm"/*,model*/);
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