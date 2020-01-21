using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapsis.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        public ActionResult Kitaplar()
        {
            return View();
        }

        public ActionResult Kitaplarim()
        {
            return View();
        }

        public ActionResult KitapEkle()
        {
            return View();
        }

    }
}