using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        DbOtelEntities dbOtelEntities = new DbOtelEntities();

        public PartialViewResult Footer()
        {
            ViewBag.BosOda = dbOtelEntities.TblOda.Count(x => x.Durum == 1);
            ViewBag.DoluOda = dbOtelEntities.TblOda.Count(x => x.Durum == 1009);
            return PartialView();
        }
        public PartialViewResult NavBar()
        {
            return PartialView();
        }
        public PartialViewResult Script()
        {
            return PartialView();
        }
    }
}