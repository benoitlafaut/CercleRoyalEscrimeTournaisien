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

    $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").dblclick(function () {
        showText($(this).text());
    });

    $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").click(function () {
        $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").css('color', 'black');
        $(this).css('color', 'blue');
        $("#CurrentRowSelected").val($(this).index());
    });
});

function showText(texte) {
    $('#textEspagnol').html('');
    $("#checkSquareIDEspagnol").next('fieldset').find('tr').css('display', 'none')
    if ($('#checkSquareIDEspagnol').hasClass('fa-check-square')) { TranslateOtherLanguageThanFrench(texte, 'spa', 'textEspagnol'); $("#checkSquareIDEspagnol").next('fieldset').find('tr').css('display', 'block'); }

    $('#textAnglais').html('');
    $("#checkSquareIDAnglais").next('fieldset').find('tr').css('display', 'none')
    if ($('#checkSquareIDAnglais').hasClass('fa-check-square')) { TranslateOtherLanguageThanFrench(texte, 'eng', 'textAnglais'); $("#checkSquareIDAnglais").next('fieldset').find('tr').css('display', 'block'); }

    $('#textAllemand').html('');
    $("#checkSquareIDAllemand").next('fieldset').find('tr').css('display', 'none')
    if ($('#checkSquareIDAllemand').hasClass('fa-check-square')) { TranslateOtherLanguageThanFrench(texte, 'ger', 'textAllemand'); $("#checkSquareIDAllemand").next('fieldset').find('tr').css('display', 'block'); }

    $('#textNeerlandais').html('');
    $("#checkSquareIDNeerlandais").next('fieldset').find('tr').css('display', 'none')
    if ($('#checkSquareIDNeerlandais').hasClass('fa-check-square')) { TranslateOtherLanguageThanFrench(texte, 'dut', 'textNeerlandais'); $("#checkSquareIDNeerlandais").next('fieldset').find('tr').css('display', 'block'); }

    $('#textFrancais').html('');
    $("#checkSquareIDFrancais").next('fieldset').find('tr').css('display', 'none')
    if ($('#checkSquareIDFrancais').hasClass('fa-check-square')) { $("#textFrancais").text(texte); $("#checkSquareIDFrancais").next('fieldset').find('tr').css('display', 'block'); }


    $("#popUp").dialog({
        modal: true,
        resizable: false,
        width: $(window).width() * 0.95,
        height: $(window).height() * 0.8,
    });
}

function ListenAll() {
    if ($("#CurrentRowSelected").val() == '') { return; }

    setInterval(function () { ListenSentence(); }, 3000);
}

function ListenSentence() {
    if (responsiveVoice.isPlaying()) { return; }

    var index = $("#CurrentRowSelected").val();
    index = parseInt(index) + 1;
    $("#CurrentRowSelected").val(index);
    var text = $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").eq(index).find('span')[0].innerText;

    responsiveVoice.speak(text, 'French Male');

   

    $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").css('color', 'black');
    $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").eq(index).css('color', 'blue');

    $(document).scrollTop($(document).scrollTop() + 30);
    var topDialog = $(".ui-dialog").css('top');

    $(".ui-dialog").css('top', parseInt(topDialog) + 30);

    $("#bodyReadEpub20042023").find("#tableReadEpub").find("tr").eq(index).dblclick();

}

function TranslateOtherLanguageThanFrench(texteToTranslate, langueDestination, outputElement) {
    $('#' + outputElement).val('');

    if (texteToTranslate == '' || texteToTranslate == ' ') { return; }

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

            $('#' + outputElement).html(splittedFormatted);

            var playOutputElement = "Play" + outputElement;
            $("#" + playOutputElement).removeAttr('onclick');
            $("#" + playOutputElement).on("click", function () {
                ListenOnlySentence(splittedFormatted, outputElement);
            });
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
    $.startloading();
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

            newLink.click();
            //modal.style.display = "none";

            alert('le fichier a été transformé et téléchargé.')
        },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        },
        always: function (response) {
            $.endloading();
        }
    });
}

function ChargerEpubNew20042023() {
  
    let allfilesSelect = $("#inputFile").get(0).files;       
    var data = new FormData();
    for (var i = 0; i < allfilesSelect.length; i++) {
        data.append(allfilesSelect[i].name, allfilesSelect[i]);
    }
   

    $.ajax({
        url: "/MainPage/ChargerEpubNew20042023",
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: false,
        contentType: false,
        success: function (result) {
            $('#bodyReadEpub20042023').html(result.modelEpub20042023);
            ActiveFonctionsGsm();
        },
        failure: function (response) { },
        error: function (response) { }
    });
}