$(document).ready(function () {
    var SelectedLanguage = $("#SelectedLanguage").val();
    var SelectedNameDossier = $("#SelectedNameDossier").val();
    var SelectedIndexDossier = $("#SelectedIndexDossier").val();
    var SelectedIndexFile = $("#SelectedIndexFile").val();
    var urlMp3 = "../DossierExterieurAVS/mp3/" + SelectedLanguage + "/" + SelectedNameDossier + "/" + SelectedIndexDossier + "/" + SelectedIndexFile + ".mp3";
    $("#elementAudio").attr('src', urlMp3);    

    $("#elementAudio").bind("ended", function ()
    {
        SelectedIndexFile = Number(SelectedIndexFile) + 1;
        var urlMp3 = "../DossierExterieurAVS/mp3/" + SelectedLanguage + "/" + SelectedNameDossier + "/" + SelectedIndexDossier + "/" + SelectedIndexFile + ".mp3";
        $("#elementAudio").attr('src', urlMp3);    
        $("#SelectedIndexFile").val(SelectedIndexFile);
        $("#elementAudio")[0].play();
    });

});
function chargerson() {
    var SelectedLanguage = $("#SelectedLanguage").val();
    var SelectedNameDossier = $("#SelectedNameDossier").val();
    var SelectedIndexDossier = $("#SelectedIndexDossier").val();
    var SelectedIndexFile = $("#SelectedIndexFile").val();


    $.get('/MainPage/ChangeCurrentSon/' + '?selectedLanguage=' + SelectedLanguage + '&selectedNameDossier=' + SelectedNameDossier + '&selectedIndexDossier=' + SelectedIndexDossier + '&selectedIndexFile=' + SelectedIndexFile)
        .done(function (data) {      
        }).always(function () {          
        })



    var urlMp3 = "../DossierExterieurAVS/mp3/" + SelectedLanguage + "/" + SelectedNameDossier + "/" + SelectedIndexDossier + "/" + SelectedIndexFile + ".mp3";


    $.ajax({
        url: urlMp3,
        type: 'HEAD',
        error: function () {
            $("#SelectedFile").val('File not found');
            $("#elementAudio")[0].pause();
            $("#elementAudio").attr('src', '');
        },
        success: function () {
            $("#elementAudio").attr('src', urlMp3);
            $("#elementAudio")[0].play();
            $("#SelectedFile").val(urlMp3);            
        }
    });
}

