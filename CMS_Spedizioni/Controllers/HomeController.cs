using CMS_Spedizioni.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS_Spedizioni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Cliente> ListaCilenti = Cliente.GetListaClienti();
            return View(ListaCilenti);
        }
    }
}