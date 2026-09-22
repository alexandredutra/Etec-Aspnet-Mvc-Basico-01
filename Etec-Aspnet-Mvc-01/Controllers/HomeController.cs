using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Etec_Aspnet_Mvc_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Sua página de descrição do aplicativo.";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Sua página de contato.";

            return View();
        }
    }
}