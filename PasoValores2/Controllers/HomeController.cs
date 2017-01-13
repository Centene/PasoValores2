using PasoValores2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasoValores2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Facturacion()
        {
            EFactura factura = new EFactura();
            factura.Fecha = DateTime.Now.Date.ToString();
            return View(factura);
        }
        [HttpPost]
        public ActionResult Facturacion(string Serie, DateTime fecha)
        {
            EFacturaController otrafra = new EFacturaController();

            string fechita;
            EFactura factura = new EFactura();
            factura.Serie = Serie;
            fechita = fecha.ToShortDateString();
            

            return RedirectToAction("Index", "EFactura", new { serie= Serie, fechafra = fechita});
        }
    }
}