using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;
using Capa_Datos;
namespace Capa_Negocio
{
    public class TipoUsuarioBL
    {
        public List<TipoUsuarioCLS> ListarTipoUsuario()
        {
            TipoUsuarioDAL oTipoUsuarioDAL = new TipoUsuarioDAL();
            return oTipoUsuarioDAL.ListarTipoUsuario();
        }
   }
}
