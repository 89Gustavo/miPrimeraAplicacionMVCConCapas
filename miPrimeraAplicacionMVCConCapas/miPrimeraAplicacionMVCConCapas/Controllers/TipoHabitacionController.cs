using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidad;
using Capa_Negocio;

namespace miPrimeraAplicacionMVCConCapas.Controllers
{
    public class TipoHabitacionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListaQueda() {
            TipoHabitacionBL obj = new TipoHabitacionBL();


            return Json(obj.ListarDatosQuemados(), JsonRequestBehavior.AllowGet);
        
        }
    }
}