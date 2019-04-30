using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoilerPlate.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // Components
        public ActionResult ComponentButtons()
        {
            return View();
        }

        public ActionResult ComponentCards()
        {
            return View();
        }


        // Utilities
        public ActionResult UtilitiesColors()
        {
            return View();
        }

        public ActionResult UtilitiesBorders()
        {
            return View();
        }

        public ActionResult UtilitiesAnimations()
        {
            return View();
        }

        public ActionResult UtilitiesOther()
        {
            return View();
        }



    }

}

