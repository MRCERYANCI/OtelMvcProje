using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class HizmetlerPartialController : Controller
    {
        // GET: HizmetlerPartial
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        public PartialViewResult Page1()
        {
            return PartialView();
        }
        public PartialViewResult Page2()
        {
            return PartialView(dbOtelEntities.TblHizmetler1.ToList());
        }
        public PartialViewResult Page3()
        {
            return PartialView(dbOtelEntities.TblTesisler.ToList());
        }
        public PartialViewResult Page4()
        {
            return PartialView(dbOtelEntities.TblBlog.ToList());
        }
    }
}