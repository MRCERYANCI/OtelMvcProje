using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblUye tblUye)
        {
            var LoginOlanKullanici = dbOtelEntities.TblUye.FirstOrDefault(x => x.Mail == tblUye.Mail && x.Sifre == tblUye.Sifre);
            if (LoginOlanKullanici != null)
            {
                //Giriş Komutları
                FormsAuthentication.SetAuthCookie(LoginOlanKullanici.Mail, false);
                Session["Mail"] = LoginOlanKullanici.Mail;
                return RedirectToAction("Index", "Misafir");
            }
            else
                return View();
        }
    }
}