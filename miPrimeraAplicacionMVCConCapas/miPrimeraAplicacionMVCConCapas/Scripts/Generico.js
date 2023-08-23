function pintar(objConfiguracion) {

    var raiz = document.getElementById("hdfOculto").value;
    var urlAbsoluta = window.location.protocol + "//"
        + window.location.host + raiz + objConfiguracion.url;

    //console.log(urlAbsoluta);

    fetch(urlAbsoluta)
        .then(res => res.json())
        .then(res => {
            var contenido = "";
            contenido += `<table id='${objConfiguracion.idTabla}' class='display nowrap' style='width: 100%'><thead>`
            contenido += "<tr>"
            for (var j = 0; j < objConfiguracion.cabeceras.length; j++) {
                contenido += "<th>" + objConfiguracion.cabeceras[j]+"</th>"
            }
            contenido += " </thead></tr> <tbody>"
            var fila;
            var propiedadActual;
            for (var i = 0; i < res.length; i++) {
                fila = res[i];
                contenido += "<tr>"
                for (var j = 0; j < objConfiguracion.propiedades.length; j++) {
                    propiedadActual = objConfiguracion.propiedades[j]

                    contenido += "<td>" + fila[propiedadActual] + "</td>"
                }
              

                contenido += "</tr>"
            }
            contenido += "</tbody></table>"


            document.getElementById(objConfiguracion.id).innerHTML = contenido;

            var id = "tblTipoHabitacion"
            new DataTable("#" + objConfiguracion.idTabla, {
                responsive: true,
                language: {
                    url: 'https://cdn.datatables.net/plug-ins/1.13.6/i18n/es-ES.json',
                }


            });
        })

}