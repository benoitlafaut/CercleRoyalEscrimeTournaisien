$(document).ready(function () {
    $('.CelluleCouleurHolidays').each(function (index, item) {
        $(this).parent('td').addClass("CelluleCouleurHolidays");
    })
    $('.CelluleCouleurSalleDéjàPrise').each(function (index, item) {
        $(this).parent('td').addClass("CelluleCouleurSalleDéjàPrise");
    })
    $('.CelluleCouleurSabre').each(function (index, item) {
        $(this).parent('td').addClass("CelluleCouleurSabre");
    })
    $('.CelluleCouleurEpee').each(function (index, item) {
        $(this).parent('td').addClass("CelluleCouleurEpee");
    })
    $('.CelluleCouleurFleuret').each(function (index, item) {
        $(this).parent('td').addClass("CelluleCouleurFleuret");
    })

    ActiveFonctionsGsm();
});

function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {
        $('label').css('font-size', '12px')
    }
    else {

    }
}