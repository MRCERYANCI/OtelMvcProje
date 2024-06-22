using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblUye tblUye)
        {
            dbOtelEntities.TblUye.Add(tblUye);
            dbOtelEntities.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}