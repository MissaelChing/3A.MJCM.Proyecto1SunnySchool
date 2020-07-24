// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).on('Sumit', '#Login', function (e) {
    e.preventDefault();
    $.ajax({
        beforeSend: function () {
            $('#Login button[type=sumit]').prop('disable', true);

        },
        type: this.method,
        url: this.action,
        data: $(this).serialize(),
        success: function (data) {
            alert("ha iniciado con exito, Bienvenido" + data.Nombre);

        },
        error: function (xhr, status) {
            alert(xhr.responponsiveJSON.Message);
        },
        complete: function () {

        }
    })
});