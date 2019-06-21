using MVCHelpers2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers2.Controllers
{
    public class TextBoxController : Controller
    {
        // GET: TextBox
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TextBox()
        {
            Personel p = new Personel();
            p.ID = 1;
            p.Ad = "Saymen";
            p.Soyad = "Teymen";
            p.DogumTarihi = new DateTime(1989, 07, 15);
            return View(p);
        }
        public ActionResult TextBoxFor(Personel data)
        {
            Personel p = new Personel();
            p.ID = 1;
            p.Ad = "Kral";
            p.Soyad = "King";
            p.Departman = "Amele";
            p.DogumTarihi = new DateTime(1979, 02, 24);
            return View(p);
        }

    }
}