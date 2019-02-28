using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetManiaWeb.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult login()
        {
            return View();
        }

        public ActionResult form_user()
        {
            return View();
        }
    }
}