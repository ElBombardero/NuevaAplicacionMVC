function OcultarContenido() {
    if ($("#contenido").is(":visible")) {
        $("#contenido").hide("slow");
    } else {
        $("#contenido").show("slow");
    }
}

$(document).ready(function () {
    $('.theinput-2').focus(function () {
        $('.contenedor').css('border-color', 'dodgerblue');
    }).blur(function () {
        $('.contenedor').css('border-color', 'black');
    });
});