var timeouts = [];

$(document).ready(function () {
    config.speakSelectedText = false;
    config.welcomeMessage = "";    

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
    var currentStep = $("#CurrentStep").val();
    var currentStepPlusIndex = parseInt(currentStep) + parseInt($("#CurrentStepToListen").val());
    var nameRowsToRead = "rowsToRead_" + currentStepPlusIndex + "_";

    $("#tdInTable_" + currentStepPlusIndex + "_").css('color', 'blue');

    ListenSentence($("#" + nameRowsToRead).val(), 'true');
}

function ListenSentence(sentence, isContinue) {
    if (responsiveVoice.isPlaying()) {
        timeouts.push( setTimeout(function () {
            ListenSentence(sentence);
        }, 1600),1000 );

        return;
    }

    let voice = GetVoice();

    responsiveVoice.speak(sentence, voice, {
        onend: function () {
            if (isContinue == 'true') {
                var currentStepToListen = $("#CurrentStepToListen").val();

                $(".ClassTDText").css('color', 'black');

                currentStepToListen = parseInt(currentStepToListen) + 1;
                $("#CurrentStepToListen").val(currentStepToListen);

                if (currentStepToListen == parseInt($("#NombreRowsToShow").val())) {
                    $("#CurrentStepToListen").val('0');

                    var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
                    ChargerEpub(inputRange);
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
function ClickIconLeft() {
    var inputRange = parseInt($("#inputRange").val()) - parseInt($("#NombreRowsToShow").val());
    ChargerEpub(inputRange);
}
function ClickIconRight() {
    var inputRange = parseInt($("#inputRange").val()) + parseInt($("#NombreRowsToShow").val());
    ChargerEpub(inputRange);
}
function getSelectionText() {
    let text = "";
    const activeEl = document.activeElement;
    const activeElTagName = activeEl ? activeEl.tagName.toLowerCase() : null;

    if (
        (activeElTagName == "textarea") || (activeElTagName == "input" &&
            /^(?:text|search|password|tel|url)$/i.test(activeEl.type)) &&
        (typeof activeEl.selectionStart == "number")
    ) {
        text = activeEl.value.slice(activeEl.selectionStart, activeEl.selectionEnd);
    } else if (window.getSelection) {
        text = window.getSelection().toString();
    }

    return text;
}
function ClickRow(element, sentence) {
    var motFR = element.innerText;
    var phraseFR = sentence.replaceAll("&#39", "'");

    if (motFR != '') {  
        $(".ClassTextWord").text('');
        $(".ClassTextSentence").text('');

        if ($("#LanguageForLanguageDefaultSelected").val() != "FR") {
            GetFrenchFromOtherLanguage(motFR, phraseFR);           
        }

        var voiceFrom = GetVoiceFrom();

        $("#idMotFR").css('display', 'none');
        $("#idMotEN").css('display', 'none');
        $("#idMotES").css('display', 'none');
        $("#idMotNL").css('display', 'none');
        $("#idMotDE").css('display', 'none');
        $("#idMotIT").css('display', 'none');

        $("#idPhraseFR").css('display', 'none');
        $("#idPhraseEN").css('display', 'none');
        $("#idPhraseES").css('display', 'none');
        $("#idPhraseNL").css('display', 'none');
        $("#idPhraseDE").css('display', 'none');
        $("#idPhraseIT").css('display', 'none');

        if ($("#LanguageForLanguageDefaultSelected").val() == "FR") {
            $("#MotFR").text(motFR);
            $("#PhraseFR").text(phraseFR);

            $("#MotFR_Sound").off("click");
            $("#PhraseFR_Sound").off("click");

            $('#MotFR_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("fra"));
            });
            $('#PhraseFR_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("fra"));
            });
        }

        $("#idMotFR").css('display', 'block');
        $("#idPhraseFR").css('display', 'block');

        if (voiceFrom != 'spa') {
            TranslateOtherLanguageThanFrench(motFR, 'spa', 'MotES', voiceFrom);
            TranslateOtherLanguageThanFrench(phraseFR, 'spa', 'PhraseES', voiceFrom);
        }
        else {
            $("#MotES").text(motFR);
            $("#PhraseES").text(phraseFR);

            $("#MotES_Sound").off("click");
            $("#PhraseES_Sound").off("click");

            responsiveVoice.speak(motFR, GetVoiceForResponsive("spa"));

            $("#MotES").css('color', 'blue');
            $("#PhraseES").css('color', 'blue');
            $("#PhraseES").prev('.ClassTitleText').css('color', 'blue');

            $('#MotES_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("spa"));
            });
            $('#PhraseES_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("spa"));
            });
        }

        $("#idMotES").css('display', 'block');
        $("#idPhraseES").css('display', 'block');

        if (voiceFrom != 'eng') {
            TranslateOtherLanguageThanFrench(motFR, 'eng', 'MotEN', voiceFrom);
            TranslateOtherLanguageThanFrench(phraseFR, 'eng', 'PhraseEN', voiceFrom);
        }
        else {
            $("#MotEN").text(motFR);
            $("#PhraseEN").text(phraseFR);

            $("#MotEN_Sound").off("click");
            $("#PhraseEN_Sound").off("click");

            $("#MotEN").css('color', 'blue');
            $("#PhraseEN").css('color', 'blue');
            $("#PhraseEN").prev('.ClassTitleText').css('color', 'blue');

            responsiveVoice.speak(motFR, GetVoiceForResponsive("eng"));

            $('#MotEN_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("eng"));
            });
            $('#PhraseEN_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("eng"));
            });
        }

        $("#idMotEN").css('display', 'block');
        $("#idPhraseEN").css('display', 'block');

        if (voiceFrom != 'ger') {
            TranslateOtherLanguageThanFrench(motFR, 'ger', 'MotDE', voiceFrom);
            TranslateOtherLanguageThanFrench(phraseFR, 'ger', 'PhraseDE', voiceFrom);
        }
        else {
            $("#MotDE").text(motFR);
            $("#PhraseDE").text(phraseFR);

            $("#MotDE").css('color','blue');
            $("#PhraseDE").css('color', 'blue');
            $("#PhraseDE").prev('.ClassTitleText').css('color', 'blue');

            $("#MotDE_Sound").off("click");
            $("#PhraseDE_Sound").off("click");

            responsiveVoice.speak(motFR, GetVoiceForResponsive("ger"));

            $('#MotDE_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("ger"));
            });
            $('#PhraseDE_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("ger"));
            });
        }

        $("#idMotDE").css('display', 'block');
        $("#idPhraseDE").css('display', 'block');

        if (voiceFrom != 'dut') {
            TranslateOtherLanguageThanFrench(motFR, 'dut', 'MotNL', voiceFrom);
            TranslateOtherLanguageThanFrench(phraseFR, 'dut', 'PhraseNL', voiceFrom);
        }
        else {
            $("#MotNL").text(motFR);
            $("#PhraseNL").text(phraseFR);

            $("#MotNL_Sound").off("click");
            $("#PhraseNL_Sound").off("click");

            $("#MotNL").css('color', 'blue');
            $("#PhraseNL").css('color', 'blue');
            $("#PhraseNL").prev('.ClassTitleText').css('color', 'blue');

            responsiveVoice.speak(motFR, GetVoiceForResponsive("dut"));

            $('#MotNL_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("dut"));
            });
            $('#PhraseNL_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("dut"));
            });
        }

        $("#idMotNL").css('display', 'block');
        $("#idPhraseNL").css('display', 'block');

        if (voiceFrom != 'ita') {
            TranslateOtherLanguageThanFrench(motFR, 'ita', 'MotIT', voiceFrom);
            TranslateOtherLanguageThanFrench(phraseFR, 'ita', 'PhraseIT', voiceFrom);
        }
        else {
            $("#MotIT").text(motFR);
            $("#PhraseIT").text(phraseFR);

            $("#MotIT_Sound").off("click");
            $("#PhraseIT_Sound").off("click");

            $("#MotIT").css('color', 'blue');
            $("#PhraseIT").css('color', 'blue');
            $("#PhraseIT").prev('.ClassTitleText').css('color', 'blue');

            responsiveVoice.speak(motFR, GetVoiceForResponsive("ita"));

            $('#MotIT_Sound').click(function () {
                responsiveVoice.speak(motFR, GetVoiceForResponsive("ita"));
            });
            $('#PhraseIT_Sound').click(function () {
                responsiveVoice.speak(phraseFR, GetVoiceForResponsive("ita"));
            });
        }

        $("#idMotIT").css('display', 'block');
        $("#idPhraseIT").css('display', 'block');

        var modal = document.getElementById("myModalTraductionPopup");
        modal.style.display = "block";
    };
}

function GetVoiceFrom() {
    switch ($("#LanguageForLanguageDefaultSelected").val()) {
        case "FR":
            return "fra";            
        case "EN":
            return "eng";            
        case "NL":
            return "dut";            
        case "ES":
            return "spa";            
        case "DE":
            return "ger";            
        case "IT":
            return "ita";            
    }
}
function GetFrenchFromOtherLanguage(word, sentence) {
    switch ($("#LanguageForLanguageDefaultSelected").val()) {
        case "EN":
            TranslateOtherLanguageThanFrench(word, 'fra', 'MotFR', 'eng');
            TranslateOtherLanguageThanFrench(sentence, 'fra', 'PhraseFR', 'eng');
            break;
        case "NL":
            TranslateOtherLanguageThanFrench(word, 'fra', 'MotFR', 'dut');
            TranslateOtherLanguageThanFrench(sentence, 'fra', 'PhraseFR', 'dut');
            break;
        case "ES":
            TranslateOtherLanguageThanFrench(word, 'fra', 'MotFR', 'spa');
            TranslateOtherLanguageThanFrench(sentence, 'fra', 'PhraseFR', 'spa');
            break;
        case "DE":
            TranslateOtherLanguageThanFrench(word, 'fra', 'MotFR', 'ger');
            TranslateOtherLanguageThanFrench(sentence, 'fra', 'PhraseFR', 'ger');
            break;
        case "IT":
            TranslateOtherLanguageThanFrench(word, 'fra', 'MotFR', 'ita');
            TranslateOtherLanguageThanFrench(sentence, 'fra', 'PhraseFR', 'ita');
            break;
    }    
}

function GetVoice() {
    if ($("#LanguageForLanguageDefaultSelected").val() == "FR") { return 'French Male'; }
    if ($("#LanguageForLanguageDefaultSelected").val() == "ES") { return 'Spanish Latin American Female'; }
    if ($("#LanguageForLanguageDefaultSelected").val() == "EN") { return 'UK English Female'; }
    if ($("#LanguageForLanguageDefaultSelected").val() == "DE") { return 'Deutsch Female'; }
    if ($("#LanguageForLanguageDefaultSelected").val() == "NL") { return 'Dutch Male'; }
    if ($("#LanguageForLanguageDefaultSelected").val() == "IT") { return 'Italian Female'; }
}

function GetVoiceForResponsive(voiceTo) {
    if (voiceTo == "fra") { return 'French Male'; }
    if (voiceTo == "spa") { return 'Spanish Latin American Female'; }
    if (voiceTo == "eng") { return 'UK English Female'; }
    if (voiceTo == "ger") { return 'Deutsch Female'; }
    if (voiceTo == "dut") { return 'Dutch Male'; }
    if (voiceTo == "ita") { return 'Italian Female'; }
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

            $('#' + outputElement + '_Sound').off("click");
            $('#' + outputElement + '_Sound').click(function ()
            {
                responsiveVoice.speak(splittedFormatted, GetVoiceForResponsive(langueDestination));
            });
        },
        success: function (result, status) {
        },
        error: function (a, b, c) {
            alert(b + '-' + c);
        }
    });
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
function ChangeLogiqueLecture() {
    $('#IsLectureWithLangue').prop('checked', 'checked');


    ChangeFaçonDeLire();
}
function FillTable() {
    let rowToTranslate;

    if ($("#" + "rowsToRead_0_").val() == undefined) {
        return;
    }

    $('#tableBody').empty();
    for (let i = $("#CurrentStep").val(); i < $("#CurrentStepFinal").val(); i++) {
        let nameOfField = "rowsToRead_" + i.toString() + "_";
        let row = $("#" + nameOfField).val();
        rowToTranslate = row;
        let WordsInSentence = row.split(' ');
        let nameTd = "'tdInTable_" + i + "_'";

        $('#tableBody').append("<tr><td id=" + nameTd + " class='ClassTDText'></td></tr>");

        $('#' + 'tdInTable_' + i + '_').append("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");

        $('#' + 'tdInTable_' + i + '_' + '  .fa-play-Benoit')[0].onclick = function () {
            ListenSentence(row, 'false');
        };

        if ($("#IsLectureWithLangue:checked").val() != 'true') {
            WordsInSentence.forEach(function (item, index) {
                let wordsInSentence = "tdInTable_" + i + "_wordsInSentence_" + index + "_";

                $('#' + 'tdInTable_' + i + '_').append("<span id='" + wordsInSentence + "' class='ClassWord' style='user-select: all;'>" + item + " </span>");

                $('#' + wordsInSentence)[0].onclick = function () {
                    ClickRow(this, row);
                };
            });
        }
        else {
            $('#' + 'tdInTable_' + i + '_').append("<span style='user-select: all;'>" + row + " </span>");

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_1__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " class='ClassTDText'><span id=PhraseUniqueToTranslateNL></span></td></tr>");
                $("#PhraseUniqueToTranslateNL").before("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateNL').prev('.fa-play-Benoit')[0].onclick = function () {
                    responsiveVoice.speak($("#PhraseUniqueToTranslateNL").text(), GetVoiceForResponsive("dut"));
                };
                TranslateOtherLanguageThanFrench(row, 'dut', 'PhraseUniqueToTranslateNL', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_2__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " class='ClassTDText'><span id=PhraseUniqueToTranslateEN></span></td></tr>");
                $("#PhraseUniqueToTranslateEN").before("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateEN').prev('.fa-play-Benoit')[0].onclick = function () {
                    responsiveVoice.speak($("#PhraseUniqueToTranslateEN").text(), GetVoiceForResponsive("eng"));
                };
                TranslateOtherLanguageThanFrench( row, 'eng', 'PhraseUniqueToTranslateEN', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_3__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " class='ClassTDText'><span id=PhraseUniqueToTranslateES></span></td></tr>");
                $("#PhraseUniqueToTranslateES").before("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateES').prev('.fa-play-Benoit')[0].onclick = function () {
                    responsiveVoice.speak($("#PhraseUniqueToTranslateES").text(), GetVoiceForResponsive("spa"));
                };
                TranslateOtherLanguageThanFrench(row, 'spa', 'PhraseUniqueToTranslateES', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_4__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " class='ClassTDText'><span id=PhraseUniqueToTranslateDE></span></td></tr>");
                $("#PhraseUniqueToTranslateDE").before("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateDE').prev('.fa-play-Benoit')[0].onclick = function () {
                    responsiveVoice.speak($("#PhraseUniqueToTranslateDE").text(), GetVoiceForResponsive("ger"));
                };
                TranslateOtherLanguageThanFrench(row, 'ger', 'PhraseUniqueToTranslateDE', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_5__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " class='ClassTDText'><span id=PhraseUniqueToTranslateIT></span></td></tr>");
                $("#PhraseUniqueToTranslateIT").before("<i class='fa fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateIT').prev('.fa-play-Benoit')[0].onclick = function () {
                    responsiveVoice.speak($("#PhraseUniqueToTranslateIT").text(), GetVoiceForResponsive("ita"));
                };
                TranslateOtherLanguageThanFrench(row, 'ita', 'PhraseUniqueToTranslateIT', 'fra');
            }
        }
    }
}