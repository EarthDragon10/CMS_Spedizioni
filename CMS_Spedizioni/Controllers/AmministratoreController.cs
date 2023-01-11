using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS_Spedizioni.Controllers
{
    public class AmministratoreController : Controller
    {
        // GET: Amministratore
        public ActionResult Login()
        {
            return View();
        }
    }
}