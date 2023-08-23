window.onload = function () {
    listarTipoHabitacion();


}

function listarTipoHabitacion() {

    pintar({
        url: "Cama/ListarCama",
        id: "divTabla",
        idTabla: "tblCama",
        cabeceras: ["ID", "NOMBRE", "DESCRIPCION"],
        propiedades: ["id", "nombre", "descripcion"]
    })
}
