var myTimeoutSetBlackText;

$(document).ready(function () {
    ActiveFonctionsGsm();

    $("#SliderLine").roundSlider({
        circleShape: "half-top",
        sliderType: "default",
        value: "0"
    });

});

function ClickListenSentence() {
    $('#CurrentSentenceToListen').val('-1');
    intervalListenSentence = setInterval(function () { ListenSentence(); }, 3000);
    modal.style.display = "none";
}


function ListenSentence() {
    if (responsiveVoice.isPlaying()) { return; }

    if ($('#CurrentSentenceToListen').val() != '-1') {
        $('.classLabelSentence').eq($('#CurrentSentenceToListen').val()).css('color', 'green');
    }

    var currentSentenceToListen = Number($('#CurrentSentenceToListen').val()) + 1;

    if ($('.classLabelSentence').eq(currentSentenceToListen).parent().css('display') == 'none') {
        currentSentenceToListen = Number(currentSentenceToListen) + 1;
    }

    var element = $('.classLabelSentence').eq(currentSentenceToListen);




    if (element.length == 0) {
        clearInterval(intervalListenSentence);
        $('#CurrentSentenceToListen').val('-1')
        changeCurrentLigne_New_112022('true', 'false', '-1');
        ClickListenSentence();
        return;
    }

    element.css('color', 'red');

    let textToSpeak = element.html();

    textToSpeak = textToSpeak.replaceAll('  \u2022  ', '');
    textToSpeak = textToSpeak.replaceAll('.', '. ');
    textToSpeak = textToSpeak.replaceAll('&nbsp;', ' ');

    responsiveVoice.speak(textToSpeak.substring(4), currentLanguage(textToSpeak))

    $('#CurrentSentenceToListen').val(currentSentenceToListen);
}

function ListenOnlySentence(textToSpeak, element) {
    if (responsiveVoice.isPlaying()) { event.stopPropagation(); return; }
    $('#' + element).css('color', 'green');
    textToSpeak = textToSpeak.replace("&#39", "'");
    responsiveVoice.speak(textToSpeak.substring(4), currentLanguage(textToSpeak));
    event.stopPropagation();

    myTimeoutSetBlackText = setInterval(() => {
        setBlackText(element)
    }, 1000);
}

function setBlackText(element) {



    if (!responsiveVoice.isPlaying()) {

        $('#' + element).css('color', 'black');
        clearTimeout(myTimeoutSetBlackText);
    }
}

function currentLanguage(textToSpeak) {
    let strThreeFirstChars = textToSpeak.substring(0, 3)
    switch (strThreeFirstChars) {
        case "FR:":
            return "French Male";
            
        case "EN:":
            return "UK English Male";
            
        case "DE:":
            return "Deutsch Male";
            
        case "ES:":
            return "Spanish Female";
            
        case "NL:":
            return "Dutch Female";
            
    }
}

function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {
        $(".classLabelSentence").css('font-size', '9px');
        $(".classFontSize17").css('font-size', '9px!important');
        $(".btn-group").css('zoom', '0.6')
        $(".classLabelSentence").css('line-height', '13px');
        $(".form-group").css('margin-bottom', '0px')
        $("#divForIcones").eq(0).css('height', '24%')
        $(".modal-content").css('width', '97%');
        $(".modal-content").css('top', '6%');

        $('.form-group').each(function (index, item) {
            $(this).css('zoom', '0.5');
        })
        $('.form-group').find('option').each(function (index, item) {
            $(this).css('font-size', '30px');
        })
    }
    else {
        $(".classLabelSentence").css('font-size', '16px');
        $(".classFontSize17").css('font-size', '16px!important');
        $(".btn-group").css('zoom', '')
        $(".classLabelSentence").css('line-height', '15px');
        $(".form-group").css('margin-bottom', '15px')
        $("#divForIcones").eq(0).css('height', '9%')
        $(".modal-content").css('width', '25%');
        $(".modal-content").css('top', '24%');
    }
}

function CreateFileEpub() {
    var formData = new FormData();
    formData.append('name', $("#txtName").val());

    var allfilesSelect = $("#GetFile").get(0).files;
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
            const FileName = $("#GetFile").get(0).files[0].name.toLowerCase().replace(".epub", ".epublaf");

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
            modal.style.display = "none";

            alert('le fichier a été transformé et téléchargé.')
        },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        }
    });
}

function ChargerEpub(url, IsToListenNew, addLines) {
    $("#translateText").val('');
    $("#translateTextToListen").val('');
    let allfilesSelect = $("#GetFile").get(0).files;

    if (allfilesSelect.length != 0)
    {        
        let lastFive = allfilesSelect[0].name.substr(allfilesSelect[0].name.length - 4);
        if (lastFive == ".mp3") {
            let fileToUpload = $('#GetFile').prop('files')[0];
            let sound = document.getElementById('audioElement1');
            sound.src = URL.createObjectURL(fileToUpload);
            sound.play();
            modal.style.display = "none";
            return;
        }
    }

    if (allfilesSelect.length == 0) {
        var data = $("#Epub_20221112 :input").serializeArray();
        var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
        var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';
        data.push({ name: "IsToListenNew", value: IsToListenNew });
        data.push({ name: "addLines", value: addLines });
    }
    else {
        var data = new FormData();
        for (var i = 0; i < allfilesSelect.length; i++) {
            data.append(allfilesSelect[i].name, allfilesSelect[i]);
        }
        data.append('IsToListenNew', IsToListenNew);
        data.append('addLines', addLines);


        var processdata = false;
        var contentType = false;
    }

    $.ajax({
        url: url,
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: processdata,
        contentType: contentType,
        success: function (result) {
            showResul(result);
            $("#GetFile").val('');
            $("#Espagnol").prop('checked', false);
            $("#Allemand").prop('checked', false);
            $("#Anglais").prop('checked', false);
            $("#Neerlandais").prop('checked', false);
            modal.style.display = "none";
        },
        failure: function (response) { },
        error: function (response) { }
    });
}

function showResul(result) {
    $('#PartRead_New_112022DIV').html(result.modelViewEpubFile);
    $("#PartRead_New_112022DIV").css('display', 'block');
    $("#ParamsView_112022").css('display', 'none');
    TranslateResult();
    $("#counterRowsEpub").html($("#CurrentLigne").val() + "/" + $("#RowsEpubCount").val())

    $("#SliderLine").roundSlider({
        circleShape: "half-top",
        sliderType: "default",
        value: $("#CurrentLigne").val(),
        max: $("#RowsEpubCount").val()
    });

    ActiveFonctionsGsm();
}

function changeSliderLine() {
    changeCurrentLigne_New_112022('false', 'false', $("#SliderLine").text());
}

function TranslateResult() {
    for (var i = 0; i < 15; i++) {
        var textFR = $("#PhrasesFrancaises_" + i + "_").html();

        if (textFR != undefined) {
            textFR = textFR.replace('FR: ', '');
        }

        if (textFR != undefined && textFR != '') {
            var elementEspagnol = "#PhrasesEspagnoles_" + i + "_";
            var elementAnglais = "#PhrasesAnglaises_" + i + "_";
            var elementAllemand = "#PhrasesAllemandes_" + i + "_";
            var elementNeerlandais = "#PhrasesNeerlandaises_" + i + "_";

            if ($("#Espagnol").prop('checked') == true) {
                TranslateOtherLanguageThanFrench(textFR, 'spa', elementEspagnol);
            }

            if ($("#Anglais").prop('checked') == true) {
                TranslateOtherLanguageThanFrench(textFR, 'eng', elementAnglais);
            }

            if ($("#Allemand").prop('checked') == true) {
                TranslateOtherLanguageThanFrench(textFR, 'ger', elementAllemand);
            }

            if ($("#Neerlandais").prop('checked') == true) {
                TranslateOtherLanguageThanFrench(textFR, 'dut', elementNeerlandais);
            }
        }
    }
}

function TranslateOtherLanguageThanFrench(texteToTranslate, langueDestination, outputElement) {
    $(outputElement).val('');

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

            $(outputElement).html(interpreteLangueDestination(langueDestination) + splittedFormatted);

            var playOutputElement = "Play" + outputElement.replace("#", "");
            $("#" + playOutputElement).removeAttr('onclick');
            $("#" + playOutputElement).on("click", function () {
                ListenOnlySentence(interpreteLangueDestination(langueDestination) + splittedFormatted, outputElement.replace("#", ""));
            });
        },
        success: function (result, status) {
        },
        error: function (a, b, c) {
            alert(b + '-' + c);
        }
    });
}

function interpreteLangueDestination(langueDestination) {
    switch (langueDestination) {
        case "spa":
            return 'ES: ';
            break;
        case "eng":
            return 'EN: ';
            break;
        case "ger":
            return 'DE: ';
            break;
        case "dut":
            return 'NL: ';
            break;
    }
}

function chargerListeThemes() {
    if ($("#ThemeSelected").val() != '') {

        var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
        var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';
        var data = $("#Epub_20221112 :input").serializeArray();
        data.push({ name: "ThemeSelected", value: $("#ThemeSelected").val() });

        $.ajax({
            url: "/Home/ChargerListeThemes",
            type: 'POST',
            cache: false,
            data: data,
            dataType: 'json',
            processData: processdata,
            contentType: contentType,
            success: function (result) {
                showResul(result);
                modal.style.display = "none";
            },
            error: function (response) {
                alert("Error. " + response.responseText);
            }
        });
    }
}

function ChargerEpubChoisi() {
    if ($("#BouquinSelected").val() != '') {

        var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
        var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';
        var data = $("#Epub_20221112 :input").serializeArray();
        data.push({ name: "BouquinSelected", value: $("#BouquinSelected").val() });

        $.ajax({
            url: "/Home/ChargerEpubChoisi",
            type: 'POST',
            cache: false,
            data: data,
            dataType: 'json',
            processData: processdata,
            contentType: contentType,
            success: function (result) {
                showResul(result);
                modal.style.display = "none";
            },
            error: function (response) {
                alert("Error. " + response.responseText);
            }
        });
    }
}

function changeCurrentLigne_New_112022(isNext, isPrevious, numeroPage) {
    $('#cover-spin').show(0);
    var data = $("#Epub_20221112 :input").serializeArray();
    var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
    var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';

    data.push({ name: "isNext", value: isNext });
    data.push({ name: "isPrevious", value: isPrevious });
    data.push({ name: "numeroPage", value: numeroPage });

    $.ajax({
        url: '/Home/ChangeEpub_New_112022',
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: processdata,
        contentType: contentType,
        success: function (result) {
            showResul(result);
            modal.style.display = "none";
            $(window).scrollTop(0);
            $('#cover-spin').hide(0);
        },
        failure: function (response) { },
        error: function (response) { }
    });
}
