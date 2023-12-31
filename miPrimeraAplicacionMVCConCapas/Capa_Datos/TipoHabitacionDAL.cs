﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class TipoHabitacionDAL:CandenaDAL
    {
        public List<TipoHabitacionCLS> ListarDatosQuemados() {
            List<TipoHabitacionCLS> listaQuemada = new List<TipoHabitacionCLS>();

            listaQuemada.Add(new TipoHabitacionCLS
            {
                id = 1,
                nombre = "Simple",
                descripcion = "Solo para uno"
            });
            listaQuemada.Add(new TipoHabitacionCLS
            {
                id = 2,
                nombre = "Doble",
                descripcion = "Solo para casados"

            });

            listaQuemada.Add(new TipoHabitacionCLS
            {
                id = 3,
                nombre = "Triple",
                descripcion = "dos adulto y un ninio"

            });
            listaQuemada.Add(new TipoHabitacionCLS
            {
                id = 4,
                nombre = "cuadruple",
                descripcion = "dos adulto y dos ninio"

            });
            return listaQuemada;
        }
        public List<TipoHabitacionCLS> ListarTiposHabitacion()
        {
            List<TipoHabitacionCLS> lista = new List<TipoHabitacionCLS>();

            
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                

                try {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("uspListarTipoHabitacion",cn)) {

                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null) {
                            lista = new List<TipoHabitacionCLS>();
                            TipoHabitacionCLS oTipoHabitacionCLS;
                            int posId = drd.GetOrdinal("IIDTIPOHABILITACION");
                            int posNombre = drd.GetOrdinal("NOMBRE");
                            int posDescripcion = drd.GetOrdinal("DESCRIPCION");
                            while (drd.Read())
                            {
                                oTipoHabitacionCLS = new TipoHabitacionCLS();
                                oTipoHabitacionCLS.id = drd.IsDBNull(posId) ? 0 : drd.GetInt32(posId);
                                oTipoHabitacionCLS.nombre = drd.IsDBNull(posNombre) ? "" : drd.GetString(posNombre);
                                oTipoHabitacionCLS.descripcion = drd.IsDBNull(posDescripcion) ? "" : drd.GetString(posDescripcion);
                                lista.Add(oTipoHabitacionCLS);
                            }
                            
                        }
                       
                    }
                    cn.Close();

                }
                catch (Exception e) {
                    cn.Close();
                }
            }

            return lista;
        }

        public List<TipoHabitacionCLS> FiltrarTipoHabitacion(String nombreHabitacion)
        {
            List<TipoHabitacionCLS> lista = new List<TipoHabitacionCLS>();


            using (SqlConnection cn = new SqlConnection(cadena))
            {


                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("uspFiltarTipoHabitacion", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombrehabitacion",nombreHabitacion);
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null)
                        {
                            lista = new List<TipoHabitacionCLS>();
                            TipoHabitacionCLS oTipoHabitacionCLS;
                            int posId = drd.GetOrdinal("IIDTIPOHABILITACION");
                            int posNombre = drd.GetOrdinal("NOMBRE");
                            int posDescripcion = drd.GetOrdinal("DESCRIPCION");
                            while (drd.Read())
                            {
                                oTipoHabitacionCLS = new TipoHabitacionCLS();
                                oTipoHabitacionCLS.id = drd.IsDBNull(posId) ? 0 : drd.GetInt32(posId);
                                oTipoHabitacionCLS.nombre = drd.IsDBNull(posNombre) ? "" : drd.GetString(posNombre);
                                oTipoHabitacionCLS.descripcion = drd.IsDBNull(posDescripcion) ? "" : drd.GetString(posDescripcion);
                                lista.Add(oTipoHabitacionCLS);
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

            return lista;
        }
    }
}
