using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firma2.Models.Entity;

namespace firma2.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        DbisTAKİPEntities db = new DbisTAKİPEntities();
        public ActionResult AktifCagrilar()
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            var cagrılar = db.CAGRIFIRMA.Where(x=> x.Durum == true && x.CAGRIFIRMA1 == id).ToList();
            return View(cagrılar);
        }
        public ActionResult PasifCagrilar()
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            var cagrılar = db.CAGRIFIRMA.Where(x => x.Durum == false && x.CAGRIFIRMA1 == id).ToList();
            return View(cagrılar);
        }
        [HttpGet]
        public ActionResult YeniCagri()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniCagri(CAGRIFIRMA p)
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            p.Durum = true;
            p.TARİH = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CAGRIFIRMA1 = id;
            db.CAGRIFIRMA.Add(p);
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        public ActionResult CagrıDetay(int id)
        {
            var cagrı = db.CAGRIDETAY.Where(x => x.CAGRI == id).ToList();
            return View(cagrı);
        }
        public ActionResult CagrıGetir(int id)
        {
            var cagri = db.CAGRIFIRMA.Find(id);
            return View("CagrıGetir",cagri);
        }
        public ActionResult CagriDuzenle(CAGRIFIRMA p)
        {
            var cagri = db.CAGRIFIRMA.Find(p.ID);
            cagri.KONU = p.KONU;
            cagri.ACIKLAMA = p.ACIKLAMA;
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        [HttpGet]
        public ActionResult Profilidüzenle()
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            var profil = db.COMPANIES.Where(x => x.ID == id).FirstOrDefault();
            return View(profil);
        }
        public ActionResult AnaSayfa()
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            var toplamcagrı = db.CAGRIFIRMA.Where(x => x.CAGRIFIRMA1 == id).Count();
            var aktifcagrı = db.CAGRIFIRMA.Where(x => x.CAGRIFIRMA1 == id && x.Durum == true).Count();
            var pasifcagrı = db.CAGRIFIRMA.Where(x => x.CAGRIFIRMA1 == id && x.Durum == false).Count();
            var yetkili = db.COMPANIES.Where(x => x.ID == id).Select(y => y.NAME).FirstOrDefault();
            var sektor = db.COMPANIES.Where(x => x.ID == id).Select(y => y.SECTOR).FirstOrDefault();
            ViewBag.c1 = toplamcagrı;
            ViewBag.c2 = aktifcagrı;
            ViewBag.c3 = pasifcagrı;
            ViewBag.c4 = yetkili;
            ViewBag.c5 = sektor;
            return View();
        }
        public PartialViewResult Partial1()
        {
            // true okunmamış mesaj - false okunmuş mesaj
            var mail = (string)Session["MAİL"];
            var mesajlar = db.MESAJLAR.Where(x => x.ALICI == mail && x.DURUM== true).ToList();
            var toplam = db.MESAJLAR.Where(x => x.ALICI == mail && x.DURUM == true).Count();
            ViewBag.c6 = toplam;
            return PartialView(mesajlar);
            
        }
        public PartialViewResult Partial2()
        {
            var mail = (string)Session["MAİL"];
            var id = db.COMPANIES.Where(x => x.MAİL == mail).Select(y => y.ID).FirstOrDefault();
            var cagrılar = db.CAGRIFIRMA.Where(x => x.CAGRIFIRMA1 == id).ToList();
            return PartialView(cagrılar);
        }
    }
}