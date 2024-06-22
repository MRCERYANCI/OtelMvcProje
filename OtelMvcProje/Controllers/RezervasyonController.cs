using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class RezervasyonController : Controller
    {
        // GET: Rezervasyon
        DbOtelEntities dbOtelEntities = new DbOtelEntities();

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["Mail"] != null)
            {
                return View();
            }
            ViewBag.Durum = "true";
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        public ActionResult Index(TblRezervasyon tblRezervasyon)
        {
            var Mail = (string)Session["Mail"].ToString();
            var MisafirBilgileri = dbOtelEntities.TblMisafir.FirstOrDefault(x => x.Mail == Mail);
            var MisafirId = (int)MisafirBilgileri.MisafirId;

            tblRezervasyon.Misafir = MisafirId;
            tblRezervasyon.Oda = 1;
            tblRezervasyon.Durum = 1008;
            dbOtelEntities.TblRezervasyon.Add(tblRezervasyon);
            dbOtelEntities.SaveChanges();
            return RedirectToAction("Rezervasyonlar", "Misafir");
        
        }
    }
}