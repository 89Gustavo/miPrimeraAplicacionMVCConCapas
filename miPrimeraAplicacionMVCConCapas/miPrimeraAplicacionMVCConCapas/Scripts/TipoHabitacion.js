window.onload = function () {
    listarTipoHabitacion();

   
}

function listarTipoHabitacion() {

    fetch("TipoHabitacion/ListaQueda")
        .then(res => res.json())
        .then(res => {
            var contenido = "";
            contenido += "<table id='tblTipoHabitacion' class='display nowrap' style='width: 100%'><thead>"
                contenido += "<tr>"
                    contenido += "<th>ID</th>"
                    contenido += "<th>NOMBRE</th>"
            contenido += "<th>DESCRIPCION</th>"
            contenido += " </thead></tr> <tbody>"
            var fila;
            for (var i = 0; i < res.length; i++) {
                fila = res[i];
                contenido += "<tr>"
                contenido += "<td>"+fila.id+"</td>"
                contenido += "<td>"+fila.nombre+"</td>"
                contenido += "<td>" + fila.descripcion + "</td>"
               
                contenido += "</tr>"
            }
            contenido += "</tbody></table>"

      
            document.getElementById("divTabla").innerHTML = contenido;
            
            var id ="tblTipoHabitacion"
            new DataTable("#"+id, {
                responsive: true,
                language: {
                    url: 'https://cdn.datatables.net/plug-ins/1.13.6/i18n/es-ES.json',
                }


            });
        })


}
