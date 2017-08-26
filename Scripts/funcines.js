function OcultarContenido() {
    if ($("#contenido").is(":visible")) {
        $("#contenido").hide("slow");
    } else {
        $("#contenido").show("slow");
    }
}

