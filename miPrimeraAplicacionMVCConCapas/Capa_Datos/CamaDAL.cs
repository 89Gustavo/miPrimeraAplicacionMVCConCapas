using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_Entidad;

using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CamaDAL:CandenaDAL
    {
        public List<CamaCLS> ListarCama()
        {
            List<CamaCLS> listaCama = new List<CamaCLS>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("uspListarCama", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null)
                        {
                            listaCama = new List<CamaCLS>();
                            CamaCLS oTipoHabitacionCLS;
                            int posId = drd.GetOrdinal("IIDCAMA");
                            int posNombre = drd.GetOrdinal("NOMBRE");
                            int posDescripcion = drd.GetOrdinal("DESCRIPCION");
                            while (drd.Read())
                            {
                                oTipoHabitacionCLS = new CamaCLS();
                                oTipoHabitacionCLS.id = drd.GetInt32(posId);
                                oTipoHabitacionCLS.nombre = drd.GetString(posNombre);
                                oTipoHabitacionCLS.descripcion = drd.GetString(posDescripcion);
                                listaCama.Add(oTipoHabitacionCLS);
                            }
                        }
                    }
                    cn.Close();
                }
                catch (Exception e)
                {
                    cn.Close();
                }
            }

            return listaCama;
        }
    }
}
