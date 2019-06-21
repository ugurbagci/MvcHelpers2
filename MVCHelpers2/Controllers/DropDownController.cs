using MVCHelpers2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers2.Controllers
{
    public class DropDownController : Controller
    {
        


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DropDownList()
        {
            List<Sehirler> sehirler = new List<Sehirler>()
            {
                new Sehirler {ID=1,SehirAdi="Antalya"},
                new Sehirler { ID=2,SehirAdi="Istanbul"},
                new Sehirler {ID=3,SehirAdi="İzmir"},
                new Sehirler{ ID=4,SehirAdi="Eskişehir"}
            };
            ViewBag.SehirID = new SelectList(sehirler.ToList(), "ID", "SehirAdi");
            return View();
        }
        public ActionResult DropDownListFor()
        {
            List<Sehirler> sehirler = new List<Sehirler>()
            {
                new Sehirler {ID=1,SehirAdi="Antalya"},
                new Sehirler { ID=2,SehirAdi="Istanbul"},
                new Sehirler {ID=3,SehirAdi="İzmir"},
                new Sehirler{ ID=4,SehirAdi="Eskişehir"}
            };

            Sehirler sehir = new Sehirler();
            sehir.ID = 1;
            sehir.SehirAdi = "Antalya";
            return View(sehir);

        }
    }
}