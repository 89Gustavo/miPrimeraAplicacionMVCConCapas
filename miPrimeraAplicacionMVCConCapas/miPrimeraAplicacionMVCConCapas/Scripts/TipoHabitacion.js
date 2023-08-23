window.onload = function () {
    listarTipoHabitacion();

   
}

function listarTipoHabitacion() {

    pintar({
        url: "TipoHabitacion/ListadoHabitacion",
        id: "divTabla",
        idTabla: "tblTipoHabitacion",
        cabeceras: ["ID", "NOMBRE", "DESCRIPCION"],
        propiedades: ["id","nombre","descripcion"]
    })


    

}
