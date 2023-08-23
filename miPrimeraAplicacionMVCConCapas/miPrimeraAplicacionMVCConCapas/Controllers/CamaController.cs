using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidad;
using Capa_Negocio;

namespace miPrimeraAplicacionMVCConCapas.Controllers
{
    public class CamaController : Controller
    {
        // GET: Cama
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListarCama() {
            CamaBL obj = new CamaBL();


            return Json(obj.ListarCama(), JsonRequestBehavior.AllowGet);
        }
    }
}