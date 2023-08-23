window.onload = function () {
    listarTipoHabitacion();


}

function listarTipoHabitacion() {

    pintar({
        url: "TipoUsuario/ListaTipoUsuario",
        id: "divTabla",
        idTabla: "tblTipoUsuario",
        cabeceras: ["ID", "NOMBRE", "DESCRIPCION"],
        propiedades: ["id", "nombre", "descripcion"]
    })




}
