$(document).ready(function () {
    ActiveFonctionsGsm();
});

function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {

        $("#bodyAccueil").css('margin', '10px 10px 10px 10px');
        $("#bodyAccueil").css('overflow', 'scroll');

    }
}
function showPopup(url) {
    if (url == undefined) { return; }
    var src = url;
    $("#imgModal").attr('src', src);
    $("#imgModal").css("display", "block");


    $("#popUp").dialog({
        modal: true,
        resizable: false,
        //width: $(window).width() * 0.95,
        //height: $(window).height() * 0.8,
    });
}


