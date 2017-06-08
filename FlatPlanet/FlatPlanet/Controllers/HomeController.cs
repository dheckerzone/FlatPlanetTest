using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlatPlanet.Data;
using FlatPlanet.Data.Models;
using Microsoft.Ajax.Utilities;

namespace FlatPlanet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new ClickCounterContext())
            {
                return View(ctx.ClickCounters.FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Count()
        {
            using (var ctx = new ClickCounterContext())
            {
                var counter = ctx.ClickCounters.FirstOrDefault();

                if (counter?.Counter < 10)
                {
                    counter.IfNotNull(clickCounter => clickCounter.Counter += 1);

                    ctx.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Home");
        }

    }
}