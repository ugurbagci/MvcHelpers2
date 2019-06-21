using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers2.Controllers
{
    public class BeginFormController : Controller
    {
 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BeginForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BeginForm(int id)
        {
            return View();
        }

        public ActionResult PostAction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostAction(int id)
        {
            return View();
        }

    }
}