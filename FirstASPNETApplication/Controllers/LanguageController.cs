using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstASPNETApplication.Models;

namespace FirstASPNETApplication.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Language()
        {
            var language = new Language() { name="English"};

            return View(language);
        }

        public ActionResult Edit(int id)
        {
            return Content("Hello "+ id);
        }

        public ActionResult Bydate(int year,int month)
        {
            return Content("Year="+year+" Month="+month);
        }
    }
}