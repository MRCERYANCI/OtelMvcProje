using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class IletisimPartialController : Controller
    {
        // GET: IletisimPartial
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        public PartialViewResult Page1()
        {
            return PartialView();
        }
        public PartialViewResult Page2()
        {
            return PartialView(dbOtelEntities.TblIletisim.Find(1));
        }
        public PartialViewResult Page3()
        {
            return PartialView();
        }

    }
}