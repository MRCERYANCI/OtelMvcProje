using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    [Authorize]
    public class MisafirController : Controller
    {
        // GET: Misafir
        DbOtelEntities dbOtelEntities = new DbOtelEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var Mail = (string)Session["Mail"].ToString();
            return View(dbOtelEntities.TblUye.FirstOrDefault(x => x.Mail == Mail));
        }
        [HttpPost]
        public ActionResult Index(TblUye tblUye)
        {
            var KullaniciBilgisi = dbOtelEntities.TblUye.Find(tblUye.ID);
            KullaniciBilgisi.AdSoyad = tblUye.AdSoyad;
            KullaniciBilgisi.Mail = tblUye.Mail;
            KullaniciBilgisi.Telefon = tblUye.Telefon;
            KullaniciBilgisi.Sifre = tblUye.Sifre;
            dbOtelEntities.SaveChanges();
            return View();
        }
        public ActionResult Rezervasyonlar()
        {
            var Mail = (string)Session["Mail"].ToString();
            var MisafirBilgileri = dbOtelEntities.TblMisafir.FirstOrDefault(x => x.Mail == Mail);
            var MisafirId = (int)MisafirBilgileri.MisafirId;
            return View(dbOtelEntities.TblRezervasyon.Where(x => x.Misafir == MisafirId).ToList());
        }

        public ActionResult UpdateProfile(TblUye tblUye)
        {
            var Kullanici = dbOtelEntities.TblUye.Find(tblUye.ID);
            Kullanici.AdSoyad = tblUye.AdSoyad;
            Kullanici.Mail = tblUye.Mail;
            Kullanici.Telefon = tblUye.Telefon;
            Kullanici.Sifre = tblUye.Sifre;
            dbOtelEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

        public ActionResult GelenMesajlar()
        {
            var Mail = (string)Session["Mail"].ToString();
            return View(dbOtelEntities.TblKullaniciAdminMesaj1.Where(x => x.Alıcı == Mail).ToList());
        }

        public ActionResult GidenMesajlar()
        {
            var Mail = (string)Session["Mail"].ToString();
            return View(dbOtelEntities.TblKullaniciAdminMesaj1.Where(x => x.Gonderen == Mail).ToList());
        }
        public ActionResult MesajDetay(int MesajId)
        {
            var mesajDetay = dbOtelEntities.TblKullaniciAdminMesaj1.Find(MesajId);
            return View("MesajDetay", mesajDetay);
        }
        [HttpGet]
        public ActionResult NewMessage()
		{
            return View();
		}
        [HttpPost]
        public ActionResult NewMessage(TblKullaniciAdminMesaj1 tblKullaniciAdminMesaj1)
        {
            tblKullaniciAdminMesaj1.Tarih = DateTime.Parse(DateTime.Now.ToLongTimeString());
            tblKullaniciAdminMesaj1.Gonderen = (string)Session["Mail"];
            dbOtelEntities.TblKullaniciAdminMesaj1.Add(tblKullaniciAdminMesaj1);
            dbOtelEntities.SaveChanges();
            return RedirectToAction("GidenMesajlar");
        }
    }
}