using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarSystem_Web.Controllers
{
    //[Authorize(Roles = "A,U")] bu kod ile rollendirme yapılır
    public class MusteriController : Controller
    {
        // GET: Musteri
        //DB db_nesnesi = new DB();
        public ActionResult Index()
        {
            //var model=bd_nesnesi.Musteri_tablosu.ToList();

            return View(/*model*/);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View("MusteriForm");
        }
        [HttpPost]
        public ActionResult Kaydet(/*Musteri musteri*/)
        {
           /* if (departman.Id == 0)
            {
                db.Departman.Add(departman);
            }
            else
            {
                var guncellenecekDepartman = db.Departman.Find(departman.Id);
                if (guncellenecekDepartman == null)
                {
                    return HttpNotFound();
                }
                guncellenecekDepartman.Ad = departman.Ad;
            }
            db.SaveChanges();*/
            return RedirectToAction("Index", "Musteri");
        }

        public ActionResult Guncelle(int id)
        {
            /* var model = db.Musteri.Find(id);
            if (model == null)
                return HttpNotFound();*/
            return View("MusteriForm"/*,model*/);
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