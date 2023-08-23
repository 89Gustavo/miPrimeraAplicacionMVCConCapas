using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidad;
using Capa_Negocio;
namespace miPrimeraAplicacionMVCConCapas.Controllers
{
    public class TipoUsuarioController : Controller
    {
        // GET: TipoUsuario
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListaTipoUsuario() {

            TipoUsuarioBL obj = new TipoUsuarioBL();

            return Json(obj.ListarTipoUsuario(),JsonRequestBehavior.AllowGet);
        }
    }
}