using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklad.Models;

namespace Sklad.Controllers
{
    public class AddController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Add
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Tovar tovar)
        {
            if (tovar.Name == null || tovar.Count == 0 || tovar.Price == 0 || tovar.Vlas == null)
            {
                Response.Write("<script>window.alert('Заповніть всі поля!');</script>");
                return View();
            }
            else
            {
                Response.Write("<script>window.alert('Препарат успішно додано!');</script>");
                db.Tovars.Add(tovar);
                db.SaveChanges();
                return RedirectToAction("../home/");
            }
        }
    }
}