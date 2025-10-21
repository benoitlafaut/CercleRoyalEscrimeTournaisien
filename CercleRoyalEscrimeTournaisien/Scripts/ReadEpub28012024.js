$(document).ready(function () {
    var touchRegionElement = document.getElementById('htmlId');
    var outputElement = document.getElementById('output');

    touchRegionElement.addEventListener('touchstart', function (e) {
        $("#PositionDepartMouse").val(e.touches[0].clientX);
    });

    window.addEventListener('pointerdown', function (e) {
        $("#PositionDepartMouse").val(e.clientX);
    });

    touchRegionElement.addEventListener('touchend', function (e) {
        var direction = e.changedTouches[0].clientX - $("#PositionDepartMouse").val();
        ChangeDirection(direction);
    });

    window.addEventListener('pointerup', function (e) {
        var direction = e.clientX - $("#PositionDepartMouse").val();
        ChangeDirection(direction);
    });

    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
        $(".separatorMarge").addClass("MargeMobile");
        $(".imgGsm").addClass('zoomImgForMobile');
    }
    else {
        $(".separatorMarge").addClass("MargePc");
        $(".imgGsm").addClass('zoomImgForPC');
    }

    ChangeLanguage();
    ActiveFonctionsGsm();
    changeInputRange();

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

    setTimeout(function () {
        $("div.bootstrap-select").css('width', '25px');
        $("div.bootstrap-select").css('display', 'block');
        $("div.bootstrap-select").find('button.selectpicker').css('max-height', '18px');
    }, 500);

    $(".dropdown-menu.open.show").find('a').on("click", function () {

    });
});
function ChangeLanguage() {

    

    checkChangeForLangue('selectFR', 'divTextAreaFrance');
    checkChangeForLangue('selectEN', 'divTextAreaAngleterre');
    checkChangeForLangue('selectES', 'divTextAreaEspagne');
    checkChangeForLangue('selectNL', 'divTextAreaPaysBas');
    checkChangeForLangue('selectDE', 'divTextAreaAllemagne');
    checkChangeForLangue('selectIT', 'divTextAreaItalie');

    $("#divLabelStartListen").css("display", "block");
    if ($("#selectFR option:selected").index() == 0
        && $("#selectEN option:selected").index() == 0
        && $("#selectES option:selected").index() == 0
        && $("#selectNL option:selected").index() == 0
        && $("#selectDE option:selected").index() == 0
        && $("#selectIT option:selected").index() == 0) {
        $("#divLabelStartListen").css("display", "none");
    }

    if ($("#IsLivreCharge").val() == 'False') {
        $("#divLabelStartListen").css("display", "none");
    }

    ChargerLignesDuLivreEtTraductions();


    setTimeout(function () {
        $(".bootstrap-select .btn:focus").each(function (index, item) {
            $(this).css('outline', 'none');
        });
        $(".bootstrap-select .btn").each(function (index, item) {
            $(this).css('outline', 'none');
        });
    }, 1600);
}

function changeIsLectureWithLangue() {
    alert('coucou');
}
function checkChangeForLangue(selectElement, divElement) {
    $("#" + divElement).css('display', 'none');
    $("#" + selectElement).prev('label').css('color', 'black');
    switch ($("#" + selectElement + " option:selected").index()) {
        case 1:
        case 3:
            $("#" + divElement).css('display', 'block');
            $("#" + selectElement).prev('label').css('color', 'blue');
            break;
        case 2:
            $("#" + selectElement).prev('label').css('color', 'blue');
            break;
    }
}


function ListenSentence28012024(index) {
    switch (index) {
        case "1":
            ListenSentenceWithParameters('French Male', 'TextAreaFrance', 'elementIForTextAreaFrance');
            break;
        case "2":
            ListenSentenceWithParameters('UK English Female', 'TextAreaAngleterre', 'elementIForTextAreaAngleterre');
            break;
        case "3":
            ListenSentenceWithParameters('Spanish Latin American Female', 'TextAreaEspagne', 'elementIForTextAreaEspagne');
            break;
        case "4":
            ListenSentenceWithParameters('Dutch Male', 'TextAreaPaysBas', 'elementIForTextAreaPaysBas');
            break;
        case "5":
            ListenSentenceWithParameters('Deutsch Female', 'TextAreaAllemagne', 'elementIForTextAreaAllemagne');
            break;
        case "6":
            ListenSentenceWithParameters('Italian Female', 'TextAreaItalie', 'elementIForTextAreaItalie');
            break;
    }
}

function StartListen() {
    $("#divLabelStartListen").css('color', 'blue');

    if (responsiveVoice.isPlaying()) { return false; }

    switch ($("#CurrentStepToListen").val()) {
        case "1":
            speakElementWithChangeCurrentStep('#TextAreaFrance', 'French Male', '2', $("#selectFR option:selected").index());
            break;
        case "2":
            speakElementWithChangeCurrentStep('#TextAreaAngleterre', 'UK English Female', '3', $("#selectEN option:selected").index());
            break;
        case "3":
            speakElementWithChangeCurrentStep('#TextAreaEspagne', 'Spanish Latin American Female', '4', $("#selectES option:selected").index());
            break;
        case "4":
            speakElementWithChangeCurrentStep('#TextAreaPaysBas', 'Dutch Male', '5', $("#selectNL option:selected").index());
            break;
        case "5":
            speakElementWithChangeCurrentStep('#TextAreaAllemagne', 'Deutsch Female', '6', $("#selectDE option:selected").index());
            break;
        case "6":
            speakElementWithChangeCurrentStep('#TextAreaItalie', 'Italian Female', '7', $("#selectIT option:selected").index());
            break;
        case "7":
            imgPhotoarrowrightClick();
            $("#CurrentStepToListen").val('1');
            break;
    }
}

function speakElementWithChangeCurrentStep(element, voice, index, optionElementSelectionne) {
    if (optionElementSelectionne != 2 && optionElementSelectionne != 3) {
        $("#CurrentStepToListen").val(index);
        return false;
    }
    responsiveVoice.speak($(element).val(), voice, {
        onend: function () {
            $("#CurrentStepToListen").val(index)
        },
        onerror: function (e) {
            alert(e);
        }
    });
}
function ListenSentenceWithParameters(voice, elementDivText, elementSonId) {
    if (responsiveVoice.isPlaying()) {
        setTimeout(function () {
            ListenSentenceWithParameters(voice, elementDivText, elementSonId);
        }, 1600);

        return;
    }

    responsiveVoice.speak($('#' + elementDivText).val(), voice, {
        onend: function () {
            $("#" + elementSonId).css('color', 'black');
        },
        onstart: function () {
            $("#" + elementSonId).css('color', 'blue');
        },
        onerror: function (e) {
            alert(e);
        }
    });
}

function ChangeDirection(direction) {
    let directionMax = 650;
    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
        directionMax = 50;
    }
    let directionMaxNegatif = directionMax * -1;

    if (direction < directionMaxNegatif || direction > directionMax) {
        if (direction < directionMaxNegatif) {
            imgPhotoarrowLeftClick();
        }
        if (direction > directionMax) {
            imgPhotoarrowrightClick();
        }
    }
}
function showTooltip() {
    let text = $("#inputRange").val() + "/" + $("#inputRange").attr('max');
    $("#indexCurseur").text(text);
    $("#inputRange").attr('title', $("#inputRange").val());
}

function ClearAllInstance() {
    for (i = 0; i < 1000; i++) {
        window.clearInterval(i);
    }
}

function imgPhotoFlagFrancaisSonClick() {
    ClearAllInstance();
    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($('#TextAreaFrance').val(), 'French Male', {
            onend: function () {
                imgPhotoFlagFrancaisSonClick();
            },
            onerror: function (e) {
                alert(e);
            }
        });
    }, 1600);
}

function imgPhotoFlagAngleterresonClick() {
    ClearAllInstance();

    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($("#TextAreaAngleterre").val(), 'UK English Female', {
            onend: function () {
                imgPhotoFlagAngleterresonClick();
            }
        });
    }, 1600);
}

function imgPhotoFlagEspagnesonClick() {
    ClearAllInstance();

    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($("#TextAreaEspagne").val(), 'Spanish Latin American Female', {
            onend: function () {
                imgPhotoFlagEspagnesonClick();
            }
        });
    }, 1600);
}

function imgPhotoFlagPaysBassonlick() {
    ClearAllInstance();

    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($("#TextAreaPaysBas").val(), 'Dutch Male', {
            onend: function () {
                imgPhotoFlagPaysBassonlick();
            }
        });
    }, 1600);
}

function imgPhotoFlagAllemagnesonClick() {
    ClearAllInstance();

    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($("#TextAreaAllemagne").val(), 'Deutsch Female', {
            onend: function () {
                imgPhotoFlagAllemagnesonClick();
            }
        });
    }, 1600);
}

function imgPhotoFlagItaliesonClick() {
    ClearAllInstance();

    imgPhotoarrowrightClick();
    setTimeout(function () {
        responsiveVoice.speak($("#TextAreaItalie").val(), 'Italian Female', {
            onend: function () {
                imgPhotoFlagItaliesonClick();
            }
        });
    }, 1600);
}

function imgPhotoarrowLeftClick() {
    var indexDepart = $("#inputRange").val();
    var indexFin = parseInt(indexDepart) - 1;
    $("#inputRange").prop("value", indexFin);
    changeInputRange();
}

function imgPhotoarrowrightClick() {
    var indexDepart = $("#inputRange").val();
    var indexFin = parseInt(indexDepart) + 1;
    $("#inputRange").prop("value", indexFin);
    changeInputRange();
    if ($("#TextAreaFrance").val() == "--") { imgPhotoarrowrightClick(); }
    ChangeTailleTextArea("TextAreaFrance");
}

function ChangeTailleTextArea(element) {
    $("#" + element).height(80);
    var tailleScroll = ($("#" + element)[0].scrollHeight - 80) / 10;
    var tailledivTextAreaFrance = 80 + (10 * tailleScroll);
    $("#" + element).height(tailledivTextAreaFrance);
}

function imgPhotoFlagAllemagneClick() {
    ShowOrHideElement('divTextAreaAllemagne');
    ConvertDisplaySon('imgPhotoFlagAllemagne', 'imgPhotoFlagAllemagneson');
    ConvertDisplay('imgPhotoFlagAllemagne');
}

function imgPhotoFlagItalieClick() {
    ShowOrHideElement('divTextAreaItalie');
    ConvertDisplaySon('imgPhotoFlagItalie', 'imgPhotoFlagItalieson');
    ConvertDisplay('imgPhotoFlagItalie');
}

function imgPhotoFlagAngleterreClick() {
    ShowOrHideElement('divTextAreaAngleterre');
    ConvertDisplaySon('imgPhotoFlagAngleterre', 'imgPhotoFlagAngleterreson');
    ConvertDisplay('imgPhotoFlagAngleterre');
}

function imgPhotoFlagEspagneClick() {
    ShowOrHideElement('divTextAreaEspagne');
    ConvertDisplaySon('imgPhotoFlagEspagne', 'imgPhotoFlagEspagneson');
    ConvertDisplay('imgPhotoFlagEspagne');
}

function imgPhotoFlagPaysBasClick() {
    ShowOrHideElement('divTextAreaPaysBas');
    ConvertDisplaySon('imgPhotoFlagPaysBas', 'imgPhotoFlagPaysBasson');
    ConvertDisplay('imgPhotoFlagPaysBas');
}

function ConvertDisplay(element) {
    if ($("#" + element).hasClass('classDisplay')) {
        $("#" + element).removeClass('classDisplay');
    }
    else {
        $("#" + element).addClass('classDisplay');
    }
}

function ConvertDisplaySon(element1, element2) {
    if ($("#" + element1).hasClass('classDisplay')) {
        $("#" + element2).css('display', 'inline-block');
    }
    else {
        $("#" + element2).css('display', 'none');
    }
}

function ShowOrHideElement(element) {
    if ($("#" + element).css('display') == 'block') {
        $("#" + element).css('display', 'none');
        $("#" + element).next('hr').css('display', 'none');
    }
    else {
        $("#" + element).css('display', 'block');
        $("#" + element).next('hr').css('display', 'block');
        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
            $('hr').css('margin-top', '8px');
            $('hr').css('margin-bottom', '8px');
        }
        else {
            $('hr').css('margin-top', '20px');
            $('hr').css('margin-bottom', '20px');
        }

        setTimeout(function () {
            changeInputRange();
        }, 100);
    }
}
function changeInputRange() {
    ChargerLignesDuLivreEtTraductions();    
    ChangeLanguage();
}

function ChargerLignesDuLivreEtTraductions() {
    var indexDepart = $("#inputRange").val();
    var indexFin = parseInt(indexDepart) + 100;
    var textToShow = "";

    if ($("#rowsToRead_" + indexDepart + "_").val() == "" || $("#rowsToRead_" + indexDepart + "_").val() == undefined) { return; }

    $("#ShowOrHidePartOfBookID").val('');

    for (i = indexDepart; i < indexFin; i++) {
        textToShow = textToShow + i + ". " + $("#rowsToRead_" + i + "_").val() + "\r\n" + "\r\n";
    }

    $("#ShowOrHidePartOfBookID").val(textToShow);

    $("#TextAreaFrance").val($("#rowsToRead_" + indexDepart + "_").val())
    if (!$("#imgPhotoFlagEspagne").hasClass("classDisplay")) { TranslateOtherLanguageThanFrench($("#rowsToRead_" + indexDepart + "_").val(), 'spa', 'TextAreaEspagne'); }
    if (!$("#imgPhotoFlagAngleterre").hasClass("classDisplay")) { TranslateOtherLanguageThanFrench($("#rowsToRead_" + indexDepart + "_").val(), 'eng', 'TextAreaAngleterre'); }
    if (!$("#imgPhotoFlagAllemagne").hasClass("classDisplay")) { TranslateOtherLanguageThanFrench($("#rowsToRead_" + indexDepart + "_").val(), 'ger', 'TextAreaAllemagne'); }
    if (!$("#imgPhotoFlagPaysBas").hasClass("classDisplay")) { TranslateOtherLanguageThanFrench($("#rowsToRead_" + indexDepart + "_").val(), 'dut', 'TextAreaPaysBas'); }
    if (!$("#imgPhotoFlagItalie").hasClass("classDisplay")) { TranslateOtherLanguageThanFrench($("#rowsToRead_" + indexDepart + "_").val(), 'ita', 'TextAreaItalie'); }

    $("#ShowOrHidePartOfBookID").scrollTop(0);
    $("#IsLivreCharge").val('True');
}
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
    let formData = new FormData();

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

            let dataArray = response.responseJSON.split('||');

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
    let data = new FormData();
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
            $("#inputRange").val(0);
            changeInputRange();
        },
        failure: function (response) { },
        error: function (response) { }        
    }); 
}