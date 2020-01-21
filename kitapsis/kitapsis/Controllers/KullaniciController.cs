using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapsis.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(string kullaniciAdi, string sifre)
        {
            return RedirectToAction("Kitaplar", "Kitap");
        }

        public ActionResult Cikis()
        {
            return RedirectToAction("Giris");
        }
    }
}