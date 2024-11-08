$(document).ready(function () {
    ActiveFonctionsGsm();

    document.getElementById('inputFile').addEventListener('change', function (e) {
        if (e.target.files[0]) {
            if (e.target.files[0].name.split('.').pop().toLowerCase() == "epub") {
                CreateFileEpubNew20042023();
            }
            else {
                ChargerEpubNew20042023();
            }
        }
    });    

    document.getElementById('imgPhotoConvert').addEventListener('click', function (e) {
        $("#inputFile").click();
    });
    document.getElementById('imgPhotoOpen').addEventListener('click', function (e) {
        $("#inputFile").click();
    });

    changeInputRange();
});





function TranslateOtherLanguageThanFrench(texteToTranslate, langueDestination, outputElement) {
    $('#' + outputElement).val('');

    if (texteToTranslate == '' || texteToTranslate == ' ' || texteToTranslate == ' ') { return; }

    var data = JSON.stringify({
        format: "text",
        from: "fra",
        input: texteToTranslate,
        to: langueDestination,
        options: { sentenceSplitter: true, origin: "translation.web", contextResults: true, languageDetection: true }
    })

    $.ajax({
        url: 'https://api.reverso.net/translate/v1/translation',
        type: "POST",
        data: data,
        dataType: 'json',
        jsonp: 'oncomplete',
        contentType: "application/json",
        complete: function (request, status) {
            var splittedFormatted = '';

            for (var j = 0; j < request.responseJSON.translation.length; j++) {
                splittedFormatted += request.responseJSON.translation[j].replace("#", "").trim();
            }

            $('#' + outputElement).val(splittedFormatted);   
            ChangeTailleTextArea(outputElement);
        },
        success: function (result, status) {
        },
        error: function (a, b, c) {
            alert(b + '-' + c);
        }
    });
}
function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {
        $('label').css('font-size', '12px');
        $('span').css('font-size', '12px');
    }
}
function CreateFileEpubNew20042023() {
   //$("#idContainer").addClass("loading"); 
    var formData = new FormData();

    var allfilesSelect = $("#inputFile").get(0).files;
    if (allfilesSelect.length == 0) { alert('il n y a pas de fichier selectionné'); return; }
    if (allfilesSelect[0].name.split('.').pop().toLowerCase() != "epub") { alert('le fichier n est pas un fichier epub.'); return; }

    for (var i = 0; i < allfilesSelect.length; i++) {
        formData.append(allfilesSelect[i].name, allfilesSelect[i]);
    }

    $.ajax({
        url: "/Home/Transform",
        type: 'POST',
        cache: false,
        contentType: false,
        processData: false,
        data: formData,
        complete: function (response) {
            const FileName = $("#inputFile").get(0).files[0].name.toLowerCase().replace(".epub", ".epublaf");

            var dataArray = response.responseJSON.split('||');

            const textToBLOB = new Blob([dataArray.join("\r\n")], { type: 'text/plain' });

            let newLink = document.createElement("a");
            newLink.download = FileName;

            if (window.webkitURL != null) {
                newLink.href = window.webkitURL.createObjectURL(textToBLOB);
            }
            else {
                newLink.href = window.URL.createObjectURL(textToBLOB);
                newLink.style.display = "none";
                document.body.appendChild(newLink);
            }

            //$("#idContainer").removeClass("loading"); 
            newLink.click();
            alert('le fichier a été transformé et téléchargé.')
        },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        },
        always: function (response) {
        }
    });
}

function ChargerEpubNew20042023() {

    let allfilesSelect = $("#inputFile").get(0).files;
    var data = new FormData();
    for (var i = 0; i < allfilesSelect.length; i++) {
        data.append(allfilesSelect[i].name, allfilesSelect[i]);
    }


    $(".ToDelete").remove();


    $.ajax({
        url: "/MainPage/ChargerEpubNew28012024",
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: false,
        contentType: false,
        success: function (result) {
            $.each(result.rowsToRead, function (i, l) {
                $('<input>', {
                    type: 'hidden',
                    id: "rowsToRead_" + i + "_",
                    name: "rowsToRead_" + i + "_",
                    class: "ToDelete",
                    value: result.rowsToRead[i]
                }).appendTo('#idContainer');
            });

            $("#inputRange").attr('max', result.rowsToRead.length);
            $("#inputRange").val('0');
            changeInputRange();
        },
        failure: function (response) { },
        error: function (response) { }        
    });

  
}