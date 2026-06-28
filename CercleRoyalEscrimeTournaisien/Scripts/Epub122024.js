var timeouts = [];

$(document).ready(function () {
   
    const rv = window.responsiveVoice;

    rv.init({
        apiKey: 'K1W6MsiA',
    });

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
        $("#Epub122024_Body").css('margin-bottom', '');
    }


    document.getElementById('inputFile').addEventListener('change', function (e) {
        if (e.target.files[0]) {
            if (e.target.files[0].name.split('.').pop().toLowerCase() == "epub") {
                ConvertEpub();
            }
            else {
                ChargerEpub('0');
            }
        }
    });


    document.getElementById('SpanConvertEpub').addEventListener('click', function (e) {
        $("#inputFile").click();
    });

    document.getElementById('SpanSelectEpub').addEventListener('click', function (e) {
        $("#inputFile").click();
    });    

    setTimeout(function () {
        $("div.bootstrap-select").css('width', '25px');
        $("div.bootstrap-select").css('display', 'block');
        $("div.bootstrap-select").find('button.selectpicker').css('max-height', '18px');
        
        $('.ClassSecondCheckboxNearFlag').each(function (index, item) {
            $(this).on('click', function () {
                FillTable();
            });
        })
    }, 500);
});
function ChangeDirection(direction) {
    
    let directionMax = 650;
    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
        directionMax = 50;
    }
    let directionMaxNegatif = directionMax * -1;

    if (direction < directionMaxNegatif || direction > directionMax) {
        if (direction < directionMaxNegatif) {
            var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
            ChargerEpub(inputRange);
        }
        if (direction > directionMax) {
            var inputRange = parseInt($("#inputRange").val()) - parseInt($("#NombreRowsToShow").val());
            ChargerEpub(inputRange);
        }
    }
}
function StartPlayAllSentenceNew() {
    setInterval(function () {
        if (responsiveVoice.isPlaying()) {
            return;
        }

        StartListenOneSentence();       
    }, 2000);
}
function StartListenOneSentence() {
    let element = $(".ClassToListen").eq(0);
    if ($(element).length == 1) {
        $(element).click();
    }
    else {
        var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
        ChargerEpub(inputRange);
    }
}
function StartPlayAllSentence() {
    if ($("#iconToListenAll").css('color') == 'rgb(255, 0, 0)') {
        responsiveVoice.cancel();

        for (var i = 0; i < timeouts.length; i++) {
            clearTimeout(timeouts[i]);
        }
        //quick reset of the timer array you just cleared
        timeouts = [];
        $("#iconToListenAll").css('color', 'black');
    }
    else {    
        $("#CurrentStepToListen").val('0');
        PlayAllSentence();
        $("#iconToListenAll").css('color', 'red');
        $("#ulToExpandCollapse").click();
    }
}

function PlayAllSentence() {
    if ($("#IsLectureWithLangue").is(':checked') == true) {
        var nameFR = "#tdInTable_" + $("#CurrentStep").val() + "_";
        var nameEN = "#tdInTableEN_" + $("#CurrentStep").val() + "_";
        var nameNL = "#tdInTableNL_" + $("#CurrentStep").val() + "_";
        var nameES = "#tdInTableES_" + $("#CurrentStep").val() + "_";
        var nameDE = "#tdInTableDE_" + $("#CurrentStep").val() + "_";
        var nameIT = "#tdInTableIT_" + $("#CurrentStep").val() + "_";

        if (PlayLanguageIfNecessary(nameFR) == true) { return; };
        if (PlayLanguageIfNecessary(nameNL) == true) { return; };
        if (PlayLanguageIfNecessary(nameEN) == true) { return; };       
        if (PlayLanguageIfNecessary(nameES) == true) { return; };
        if (PlayLanguageIfNecessary(nameDE) == true) { return; };
        if (PlayLanguageIfNecessary(nameIT) == true) { return; };        
    }
    else {
        var currentStep = $("#CurrentStep").val();
        var currentStepPlusIndex = parseInt(currentStep) + parseInt($("#CurrentStepToListen").val());
        var nameRowsToRead = "rowsToRead_" + currentStepPlusIndex + "_";

        $("#tdInTable_" + currentStepPlusIndex + "_").css('color', 'blue');

        ListenSentence($("#" + nameRowsToRead), 'true');
    }    
}

function PlayLanguageIfNecessary(element) {
    if ($(element).is(':visible') == true) {
        if ($(element).hasClass('AlreadyDone') == false) {
            $(element).css('color', 'blue');
            $(element).addClass('AlreadyDone');
            ListenSentence($(element), 'true');
            return true;
        }
    }

    return false;
}

function ListenSentence(element, isContinue) {
    let voice;
    var sentence = $(element).text();
    if (sentence == '') {
        sentence = $(element).val();
        voice = 'French Male';
    }
    else {
        voice = GetVoice(element);
    }

    if (responsiveVoice.isPlaying()) {
        timeouts.push( setTimeout(function () {
            ListenSentence(element);
        }, 1600),1000 );

        return;
    }


    responsiveVoice.speak(sentence, voice, {
        onend: function () {
            if (isContinue == 'true') {   
                if ($("#IsLectureWithLangue").is(':checked') == true) {
                    var nameFR = "#tdInTable_" + $("#CurrentStep").val() + "_";
                    var nameEN = "#tdInTableEN_" + $("#CurrentStep").val() + "_";
                    var nameNL = "#tdInTableNL_" + $("#CurrentStep").val() + "_";
                    var nameES = "#tdInTableES_" + $("#CurrentStep").val() + "_";
                    var nameDE = "#tdInTableDE_" + $("#CurrentStep").val() + "_";
                    var nameIT = "#tdInTableIT_" + $("#CurrentStep").val() + "_";

                    var checkFR = checkNameVisibilityAndAlreadyDone(nameFR);
                    var checkNL = checkNameVisibilityAndAlreadyDone(nameNL);
                    var checkEN = checkNameVisibilityAndAlreadyDone(nameEN);                    
                    var checkES = checkNameVisibilityAndAlreadyDone(nameES);
                    var checkDE = checkNameVisibilityAndAlreadyDone(nameDE);
                    var checkIT = checkNameVisibilityAndAlreadyDone(nameIT);
                    
                    if (checkFR && checkEN && checkNL && checkES && checkDE && checkIT) {
                        changeRangePlusOne();
                    }
                    else {
                        $(element).css('color', 'black');
                    }
                }
                else {
                    changeRangePlusOne();
                }                

                timeouts.push(setTimeout(function () {
                    PlayAllSentence();
                }, 400), 1000);            
            }
        },
        onstart: function () {
        },
        onerror: function (e) {
            alert(e);
        }
    });
}

function changeRangePlusOne() {
    var currentStepToListen = $("#CurrentStepToListen").val();

    $(".ClassTDText").css('color', 'black');

    currentStepToListen = parseInt(currentStepToListen) + 1;
    $("#CurrentStepToListen").val(currentStepToListen);

    if (currentStepToListen == parseInt($("#NombreRowsToShow").val())) {
        $("#CurrentStepToListen").val('0');

        var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
        ChargerEpub(inputRange);
    }
}
function checkNameVisibilityAndAlreadyDone(element) {
    if ($(element).is(':visible') == true) {
        if ($(element).hasClass('AlreadyDone') == false) {
            return false;
        }
    }
    return true;
}
function ClickIconLeft() {
    var inputRange = parseInt($("#inputRange").val()) - parseInt($("#NombreRowsToShow").val());
    ChargerEpub(inputRange);
}
function ClickIconRight() {
    var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
    ChargerEpub(inputRange);
}



function GetVoice(element) {
    if ($(element).find('i').hasClass('playFR')) { return 'French Male'; }
    if ($(element).find('i').hasClass('playES')) { return 'Spanish Latin American Female'; }
    if ($(element).find('i').hasClass('playEN')) { return 'UK English Female'; }
    if ($(element).find('i').hasClass('playNL')) { return 'Dutch Male'; }
    if ($(element).find('i').hasClass('playIT')) { return 'Italian Female'; }
    if ($(element).find('i').hasClass('playDE')) { return 'Deutsch Female'; }
}

function ExpandCollapse(element) {
    
    if ($("ul").eq(0).find('span').eq(0).hasClass('glyphicon-minus')) {
        $(element).find('.glyphicon-plus').each(function () {
            $(this).addClass('glyphicon-minus');
            $(this).siblings('ul').css('display', 'block');
            
        });
    }
    else {
        $(element).find('.glyphicon-plus').each(function () {
            $(this).removeClass('glyphicon-minus');
            $(this).siblings('ul').css('display', 'none');
        });
    }

    if ($(".inner_ul").eq(0).css('display') == "block") {
        $("#divMain").addClass('TreeMainExpand').removeClass('TreeMainCollapse');
    }
    else {
        $("#divMain").removeClass('TreeMainExpand').addClass('TreeMainCollapse');
    }
}
function showTooltip() {
    let text = $("#inputRange").val() + "/" + $("#inputRange").attr('max');
    $("#indexCurseur").text(text);
    $("#inputRange").attr('title', $("#inputRange").val());
}
function TranslateOtherLanguageThanFrench(texteToTranslate, langueDestination, outputElement, langueFrom) {
    $('#' + outputElement).val('');

    if (texteToTranslate.trim() == '' || texteToTranslate == ' ' || texteToTranslate == ' ') { return; }

    var data = JSON.stringify({
        format: "text",
        from: langueFrom,
        input: texteToTranslate,
        to: langueDestination,
        options: { sentenceSplitter: true, origin: "translation.web", contextResults: true, languageDetection: true }
    })

    $.ajax({
        url: 'https://api.reverso.net/translate/v1/translation',
        type: "POST",
        data: data,
        jsonp: 'oncomplete',
        contentType: "application/json",
        complete: function (request, status) {
            var splittedFormatted = '';
            var objRequest = JSON.parse(request.responseText);

            for (var j = 0; j < objRequest.translation.length; j++) {
                splittedFormatted += objRequest.translation[j].replace("#", "").trim();
            }

            $('#' + outputElement).text(splittedFormatted);           
        },
        success: function (result, status) {
        },
        error: function (a, b, c) {
            alert(b + '-' + c);
        }
    });
}

function GetVoiceForResponsive(voiceTo) {
    if (voiceTo == "fra") { return 'French Male'; }
    if (voiceTo == "spa") { return 'Spanish Latin American Female'; }
    if (voiceTo == "eng") { return 'UK English Female'; }
    if (voiceTo == "ger") { return 'Deutsch Female'; }
    if (voiceTo == "dut") { return 'Dutch Male'; }
    if (voiceTo == "ita") { return 'Italian Female'; }
}
function ConvertEpub() {
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

            if (response.responseJSON == undefined) {
                var dataArray = response.responseText.split('||');
            }
            else {
                var dataArray = response.responseJSON.split('||');
            }

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
            alert('le fichier a été transformé et téléchargé.');

            $("#ulToExpandCollapse").find('span').eq(0).removeClass('glyphicon-minus');
            ExpandCollapse($("#ulToExpandCollapse"));

        },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        },
        always: function (response) {
        }
    });
}
function changeInputRange() {
    ChargerEpub($("#inputRange").val());
}

function wheelLoad() {
    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
    }
    else {
        $('table').bind('mousewheel', function (e) {
            if (e.originalEvent.wheelDelta / 120 > 0) {
                var inputRange = parseInt($("#inputRange").val()) - parseInt($("#NombreRowsToShow").val());
                ChargerEpub(inputRange);
                e.stopImmediatePropagation();
            }
            else {
                var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
                ChargerEpub(inputRange);
                e.stopImmediatePropagation();
            }
        });
    }
}
function ChargerEpub(currentRow) {
    $("#divLoading").css('display', 'block');

    $("#ulToExpandCollapse").find('span').eq(0).removeClass('glyphicon-minus');
    ExpandCollapse($("#ulToExpandCollapse"));

    if ($("#inputFile").get(0).files.length == 0) {
        $("#CurrentStep").val(currentRow);
        var currentStepFinal = parseInt(currentRow) + parseInt($("#NombreRowsToShow").val());
        $("#CurrentStepFinal").val(currentStepFinal);
        FillTable();
        $("#divLoading").css('display', 'none');
        $("#inputRangeSpan").text(currentRow + '/' + $("#RowsToReadCount").val());
        wheelLoad();
        $("#inputRange").val(currentRow);
        stockerCurrentRowInDB();
    }
    else {
        let allfilesSelect = $("#inputFile").get(0).files;

        let data = new FormData();
        for (var i = 0; i < allfilesSelect.length; i++) {
            data.append(allfilesSelect[i].name, allfilesSelect[i]);
        }

        data.append("currentRow", currentRow);
        data.append("fileNameBook", $("#FileNameBook").val());

        $.ajax({
            url: "/Epub/ChargerEpub",
            type: 'POST',
            data: data,
            dataType: 'html',
            processData: false,
            contentType: false,
            success: function (data, textStatus, jqXHR) {
                $("#divLoading").css('display', 'none');

                var ct = jqXHR.getResponseHeader("Content-Type");
                var mx = ct.match("text\/html");
                if (mx != null) {
                    $("#Epub122024_Body").html(data);

                    setTimeout(function () {
                        FillTable();
                    }, 4500);
                }
                else {
                    addMessage(data.type, data.title, data.text, data.sticky);
                }

                document.getElementById("inputFile").value = null;
            },
            failure: function (response) { },
            error: function (response) {
                alert("Error. " + response.responseText);  //
            }
        });
    }
}

function stockerCurrentRowInDB()
{
    $.ajax({
        type: "POST",
        url: "/Epub/stockerCurrentRowInDB",
        data: { currentRow: $("#CurrentStep").val(), fileNameBook: $("#FileNameBook").val() },
        success: function (result) {            
        }
    });
}
function ChangeLogiqueLecture() {
    $('#IsLectureWithLangue').prop('checked', 'checked');
    ChangeFaçonDeLire();
}
function FillTable() {
    if ($("#" + "rowsToRead_0_").val() == undefined) {
        return;
    }
   
    let html = "<ul class='ClassCountries'>";

    for (let i = $("#CurrentStep").val(); i < $("#CurrentStepFinal").val(); i++)
    {
        let nameOfField = "rowsToRead_" + i.toString() + "_";
        let row = $("#" + nameOfField).val();        
        let className = $(".ClassCheckboxNearFlag:checked").val();
        html += "<li class='ClassToListen ClassCountry_" + className + "' onclick=PlayText(this)><span>" + row + "</span></li>";

        if (className != "fra" && $('.ClassSecondCheckboxNearFlag[value="fra"]').is(':checked')) {
            let text_fra_Id = 'row_fra' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'fra', text_fra_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_fra" + "' onclick=PlayText(this)><span id='" + text_fra_Id + "'>"  + "</span></li>";
        }

        if (className != "dut" && $('.ClassSecondCheckboxNearFlag[value="dut"]').is(':checked')) {
            let text_dut_Id = 'row_dut' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'dut', text_dut_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_dut" + "' onclick=PlayText(this)><span id='" + text_dut_Id + "'>" + "</span></li>";
        }

        if (className != "eng" && $('.ClassSecondCheckboxNearFlag[value="eng"]').is(':checked')) {
            let text_eng_Id = 'row_eng' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'eng', text_eng_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_eng" + "' onclick=PlayText(this)><span id='" + text_eng_Id + "'>" + "</span></li>";
        }

        if (className != "spa" && $('.ClassSecondCheckboxNearFlag[value="spa"]').is(':checked')) {
            let text_spa_Id = 'row_spa' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'spa', text_spa_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_spa" + "' onclick=PlayText(this)><span id='" + text_spa_Id + "'>" + "</span></li>";
        }

        if (className != "ger" && $('.ClassSecondCheckboxNearFlag[value="ger"]').is(':checked')) {
            let text_ger_Id = 'row_ger' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'ger', text_ger_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_ger" + "' onclick=PlayText(this)><span id='" + text_ger_Id + "'>" + "</span></li>";
        }

        if (className != "ita" && $('.ClassSecondCheckboxNearFlag[value="ita"]').is(':checked')) {
            let text_ita_Id = 'row_ita' + i.toString();
            TranslateOtherLanguageThanFrench(row, 'ita', text_ita_Id, className);
            html += "<li class='ClassToListen ClassDecalerParRapportLangueBegin ClassCountry_ita" + "' onclick=PlayText(this)><span id='" + text_ita_Id + "'>" + "</span></li>";
        }     
    }

    html += "</ul>";

    $('#tableBody').empty().append(html);
}

function ChangeLangueToTranslateAndRead() {
    $('#tableBody').empty();

    let bookLangue = $(".ClassCheckboxNearFlag:checked").val();
    $('.ClassSecondCheckboxNearFlag').prop('checked', false);
    $('.ClassSecondCheckboxNearFlag[value=' + bookLangue + ']').prop('checked', true);
}
function PlayText(element) {
    var language = GetDeductLanguageBegin(element);
    $('.ClassColorOrange').removeClass('ClassColorOrange');
    $(element).addClass('ClassColorOrange');
    responsiveVoice.speak($(element).find('span').text(), GetVoiceForResponsive(language), {
        onend: function () {
            $('.ClassColorOrange').removeClass('ClassColorOrange');
            $(element).removeClass('ClassToListen');
        }
    });
}

function GetDeductLanguageBegin(element) {
    let classOfElement = $(element).attr('class');
    classOfElement = classOfElement.replace('ClassToListen', '');
    classOfElement = classOfElement.replace('ClassDecalerParRapportLangueBegin', '');
    classOfElement = classOfElement.replace('ClassCountry_', '');
    classOfElement = classOfElement.trim();
    return classOfElement;
}

function GetClassLanguageBegin() {
    return "play" + $(".ClassSecondCheckboxNearFlag:checked").val();
}

function ListenSentence(i, language) {
    $("#tdInTable_" + i + "_").css('color', 'blue');
    responsiveVoice.speak($('#tdInTable_' + i + '_').text(), GetVoiceForResponsive(language), {
        onend: function () {
            $("#tdInTable_" + i + "_").css('color', 'black');
        }
    });
}