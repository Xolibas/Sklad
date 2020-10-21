using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklad.Models;

namespace Sklad.Controllers
{
    public class TovarController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Tovar
        public ActionResult Tovar(int id)
        {
            ViewBag.ProductId = id;
            Tovar tovar = context.Tovars.Find(id);
            if (tovar != null)
            {
                return View(tovar);
            }
            return View("Tovar");
        }
    }
}