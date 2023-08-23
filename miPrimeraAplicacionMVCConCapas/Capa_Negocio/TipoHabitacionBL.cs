using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using Capa_Entidad;
namespace Capa_Negocio
{
    public class TipoHabitacionBL
    {
        public List<TipoHabitacionCLS> ListarDatosQuemados()
        {
            TipoHabitacionDAL oTipoHabitacionDAL = new TipoHabitacionDAL();
            return oTipoHabitacionDAL.ListarDatosQuemados();
        }
        public List<TipoHabitacionCLS> ListarTiposHabitacion()
        {
            TipoHabitacionDAL oTipoHabitacionDAL = new TipoHabitacionDAL();
            return oTipoHabitacionDAL.ListarTiposHabitacion();
        }
        public List<TipoHabitacionCLS> FiltrarTipoHabitacion(String nombreHabitacion) {
            TipoHabitacionDAL oTipoHabitacionDAL = new TipoHabitacionDAL();
            return oTipoHabitacionDAL.FiltrarTipoHabitacion(nombreHabitacion);

        }
    }
}
