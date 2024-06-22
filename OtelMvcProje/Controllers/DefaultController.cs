using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        public ActionResult AnaSayfa()
        {
            return View();
        }
    }
}