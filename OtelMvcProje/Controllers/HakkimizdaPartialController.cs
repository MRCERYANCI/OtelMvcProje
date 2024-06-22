using OtelMvcProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProje.Controllers
{
    public class HakkimizdaPartialController : Controller
    {
        // GET: HakkimizdaPartial
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        public PartialViewResult Page1()
        {
            return PartialView(dbOtelEntities.TblHakkimda.Find(1));
        }
        public PartialViewResult Page2()
        {
            return PartialView(dbOtelEntities.TblHizmetler.ToList());
        }
        public PartialViewResult Page3()
        {
            return PartialView(dbOtelEntities.TblTakim.ToList());
        }
        public PartialViewResult Page4()
        {
            return PartialView(dbOtelEntities.TblHakkimda.Find(1));
        }
        public PartialViewResult Page5()
        {
            return PartialView();
        }
        public PartialViewResult Page6()
        {
            return PartialView();
        }
    }
}