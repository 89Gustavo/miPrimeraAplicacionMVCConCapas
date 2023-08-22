window.onload = function () {
    listarTipoHabitacion();
}

function listarTipoHabitacion() {

    fetch("TipoHabitacion/ListaQueda")
        .then(res => res.json())
        .then(res => {
            var contenido = "";
            contenido += "<table class='table'>"
                contenido += "<tr>"
                    contenido += "<th>ID</th>"
                    contenido += "<th>NOMBRE</th>"
                    contenido += "<th>DESCRIPCION</th>"
            contenido += "</tr>"
            var fila;
            for (var i = 0; i < res.length; i++) {
                fila = res[i];
                contenido += "<tr>"
                contenido += "<td>"+fila.id+"</td>"
                contenido += "<td>"+fila.nombre+"</td>"
                contenido += "<td>"+fila.descripcion+"</td>"
                contenido += "</tr>"
            }
            contenido += "</table>"

            document.getElementById("divTabla").innerHTML = contenido;

            //alert(res)
        })
}