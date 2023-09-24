using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using firma2.Models.Entity;

namespace firma2.Controllers
{
    public class LoginController : Controller
    {
        DbisTAKİPEntities db = new DbisTAKİPEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(COMPANIES p)
        {
            var bilgiler = db.COMPANIES.FirstOrDefault(x => x.MAİL == p.MAİL && x.PASSWORD == p.PASSWORD);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAİL, false);
                Session["MAİL"] = bilgiler.MAİL.ToString();
                return RedirectToAction("AnaSayfa", "Default");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}