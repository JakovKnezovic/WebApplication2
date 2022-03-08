using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class MojController : Controller
    {
        // GET: Moj
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko Veleuciliste u Čakovcu";
            return View();
        }
        public ActionResult DrugiIndex()
        {
            ViewBag.Ustanova = "psokgpsgkpsgk";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }
        public ActionResult TreciIndex(string poruka,int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }
        public ActionResult Student()
        {
            ViewBag.Ime = "pokswgfe";
            ViewBag.Prezime = "osjgfo";
            ViewBag.Godina = "jushfi";
            return View();
        }
        public string vrativrijeme()
        {
            return DateTime.Now.ToString();
        }
    }
}