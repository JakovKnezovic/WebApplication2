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
        public ActionResult Student(string ime,string prezime,int godina = 1999)
        {
            ViewBag.Ime = ime;
            ViewBag.Prezime = prezime;
            ViewBag.Godina = godina;
            return View();
        }
    }
}