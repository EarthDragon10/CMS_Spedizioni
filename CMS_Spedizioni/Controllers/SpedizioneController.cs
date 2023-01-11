using CMS_Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS_Spedizioni.Controllers
{
    public class SpedizioneController : Controller
    {
        // GET: Spedizione
        public ActionResult CercaSpedizione()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CercaSpedizione(Spedizione spedizione)
        {
            Spedizione spedizioneCercata = Spedizione.GetOrdineSpedizione(spedizione.IdSpedizione, spedizione.cliente.CodiceFiscale);
            TempData["RicercaSpedizione"] = spedizioneCercata;
            return RedirectToAction("MostraSingolaSpedizione");
        }

        public ActionResult MostraSingolaSpedizione()
        {
            Spedizione spedizioneCercata = TempData["RicercaSpedizione"] as Spedizione;
            return PartialView("_MostraSingolaSpedizione");
        }
    }
}