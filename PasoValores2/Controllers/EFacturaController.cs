using PasoValores2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PasoValores2.Controllers
{
    public class EFacturaController : Controller
    {
        static string FECHAFRA;
        static string SERIE;
        // GET: EFactura
        public ActionResult Index(string serie, string fechafra )
        {
            EFactura fra = new EFactura();
            FECHAFRA = fechafra;
            SERIE = serie;
            fra.Fecha = FECHAFRA;
            fra.Serie = SERIE;
            fra.Importe = 0;

            return View(fra);
        }
        [HttpPost]
        public ActionResult Index(int? importe)
        {
            EFactura fra = new EFactura();
            fra.Fecha = FECHAFRA;
            fra.Serie = SERIE;
            fra.Importe = Convert.ToInt32(importe);
            return View();
        }
    }
}