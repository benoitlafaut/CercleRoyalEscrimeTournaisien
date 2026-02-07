function passToPreviousPhoto() {
    $("#imagePhoto").animate({
        opacity: 0.1,
    }, 500, function () {
        position = +$("#CurrentPhoto").val() - 1;
        if (position == -1) { position = $("#ImagesPathCount").val() - 1; }        

        var NamePath = 'ImagesPath_' + position + '_';
        var url = $("#" + NamePath).val();
        $("#imagePhoto").prop('src', url);
        $("#imagePhoto").css("opacity", "1");
        $("#CurrentPhoto").val(position);

        var NamePathWithoutDossier = 'ImagesPathWithoutDossier_' + position + '_';
        var urlWithoutDossier = $("#" + NamePathWithoutDossier).val();
        $("#fileNamePhoto").text(urlWithoutDossier);
    });
}

function passToNextPhoto() {
    $("#imagePhoto").animate({
        opacity: 0.1,
    }, 500, function () {
        position = +$("#CurrentPhoto").val() + 1;
        if (position == $("#ImagesPathCount").val()) { position = 0; }

        var NamePath = 'ImagesPath_' + position + '_';
        var url = $("#" + NamePath).val();
        $("#imagePhoto").prop('src', url);
        $("#imagePhoto").css("opacity", "1");
        $("#CurrentPhoto").val(position);

        var NamePathWithoutDossier = 'ImagesPathWithoutDossier_' + position + '_';
        var urlWithoutDossier = $("#" + NamePathWithoutDossier).val();
        $("#fileNamePhoto").text(urlWithoutDossier);
    });
}