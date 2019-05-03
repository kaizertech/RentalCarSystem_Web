using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarSystem_Web.Controllers
{
    public class KiralamaController : Controller
    {
        // GET: Kiralama
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Yeni()
        {
            return View();
        }
    }
}