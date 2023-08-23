using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Datos
{
    public class TipoUsuarioDAL:CamaDAL
    {
        public List<TipoUsuarioCLS> ListarTipoUsuario() {
            List<TipoUsuarioCLS> listarTipoUsuario = new List<TipoUsuarioCLS>();
            using (SqlConnection cn = new SqlConnection(cadena)) 
            {
                try {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("uspListarTipoUsuario", cn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader drd =   cmd.ExecuteReader();
                        if (drd != null) {
                            listarTipoUsuario = new List<TipoUsuarioCLS>();
                            TipoUsuarioCLS oTipoUsuarioCLS;
                            int posId = drd.GetOrdinal("IIDTIPOUSUARIO");
                            int posNombre =  drd.GetOrdinal("NOMBRE");
                            int psDescripcion = drd.GetOrdinal("DESCRIPCION");
                            while (drd.Read()) {
                                oTipoUsuarioCLS = new TipoUsuarioCLS();
                                oTipoUsuarioCLS.id = drd.IsDBNull(posId)?0:drd.GetInt32(posId);
                                oTipoUsuarioCLS.nombre = drd.IsDBNull(posNombre)? "": drd.GetString(posNombre);
                                oTipoUsuarioCLS.descripcion = drd.IsDBNull(psDescripcion) ? "" : drd.GetString(psDescripcion);
                                listarTipoUsuario.Add(oTipoUsuarioCLS);
                            }
                        }
                    }
                        cn.Close();

                } catch (Exception E) {
                    cn.Close();
                }   
            
            }
                return listarTipoUsuario;
        
        }
    }
}
