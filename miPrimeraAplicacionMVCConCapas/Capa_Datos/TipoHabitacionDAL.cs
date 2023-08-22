﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;
namespace Capa_Datos
{
    public class TipoHabitacionDAL
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
            return listaQuemada;
        }
    }
}
