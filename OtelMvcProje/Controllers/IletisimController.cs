using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(TblMesaj tblMesaj)
        {
            dbOtelEntities.TblMesaj.Add(tblMesaj);
            dbOtelEntities.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}