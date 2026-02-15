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

        $('#' + 'tdInTable_' + i + '_').append("<i class='fa playFR fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");

        $('#' + 'tdInTable_' + i + '_' + '  .fa-play-Benoit')[0].onclick = function () {
            ListenSentenceInFrench(i);
           
        };

        if ($("#IsLectureWithLangue:checked").val() != 'true') {
            WordsInSentence.forEach(function (item, index) {
                let wordsInSentence = "tdInTable_" + i + "_wordsInSentence_" + index + "_";

                $('#' + 'tdInTable_' + i + '_').append("<span id='" + wordsInSentence + "' class='ClassWord' style='user-select: all;'>" + item + " </span>");
            });
        }
        else {
            $('#' + 'tdInTable_' + i + '_').append("<span style='user-select: all;'>" + row + " </span>");

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_1__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " id=tdInTableNL_" + i + "_" + " class='ClassTDText'><span id=PhraseUniqueToTranslateNL></span></td></tr>");
                $("#PhraseUniqueToTranslateNL").before("<i class='fa playNL fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateNL').prev('.fa-play-Benoit')[0].onclick = function () {
                    $("#PhraseUniqueToTranslateNL").css('color', 'blue');
                    responsiveVoice.speak($("#PhraseUniqueToTranslateNL").text(), GetVoiceForResponsive("dut"), {
                        onend: function () {
                            $("#PhraseUniqueToTranslateNL").css('color', 'black');
                        }
                    });
                };
                TranslateOtherLanguageThanFrench(row, 'dut', 'PhraseUniqueToTranslateNL', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_2__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " id=tdInTableEN_" + i + "_" + " class='ClassTDText'><span id=PhraseUniqueToTranslateEN></span></td></tr>");
                $("#PhraseUniqueToTranslateEN").before("<i class='fa playEN fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateEN').prev('.fa-play-Benoit')[0].onclick = function () {
                    $("#PhraseUniqueToTranslateEN").css('color', 'blue');
                    responsiveVoice.speak($("#PhraseUniqueToTranslateEN").text(), GetVoiceForResponsive("eng"), {
                        onend: function () {
                            $("#PhraseUniqueToTranslateEN").css('color', 'black');
                        }
                    });
                };
                TranslateOtherLanguageThanFrench( row, 'eng', 'PhraseUniqueToTranslateEN', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_3__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " id=tdInTableES_" + i + "_" + " class='ClassTDText'><span id=PhraseUniqueToTranslateES></span></td></tr>");
                $("#PhraseUniqueToTranslateES").before("<i class='fa playES fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateES').prev('.fa-play-Benoit')[0].onclick = function () {
                    $("#PhraseUniqueToTranslateES").css('color', 'blue');
                    responsiveVoice.speak($("#PhraseUniqueToTranslateES").text(), GetVoiceForResponsive("spa"), {
                        onend: function () {
                            $("#PhraseUniqueToTranslateES").css('color', 'black');
                        }
                    });
                };
                TranslateOtherLanguageThanFrench(row, 'spa', 'PhraseUniqueToTranslateES', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_4__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " id=tdInTableDE_" + i + "_" + " class='ClassTDText'><span id=PhraseUniqueToTranslateDE></span></td></tr>");
                $("#PhraseUniqueToTranslateDE").before("<i class='fa playDE fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateDE').prev('.fa-play-Benoit')[0].onclick = function () {
                    $("#PhraseUniqueToTranslateDE").css('color', 'blue');
                    responsiveVoice.speak($("#PhraseUniqueToTranslateDE").text(), GetVoiceForResponsive("ger"), {
                        onend: function () {
                            $("#PhraseUniqueToTranslateDE").css('color', 'black');
                        }
                    });
                };
                TranslateOtherLanguageThanFrench(row, 'ger', 'PhraseUniqueToTranslateDE', 'fra');
            }

            if ($("#CheckBoxLanguageItemsForTraduceAutomatically_5__IsSelected:checked").val() == 'true') {
                $('#tableBody').append("<tr><td" + " id=tdInTableIT_" + i + "_" + " class='ClassTDText'><span id=PhraseUniqueToTranslateIT></span></td></tr>");
                $("#PhraseUniqueToTranslateIT").before("<i class='fa playIT fa-play fa-play-Benoit' style='cursor:pointer; font-size: 15px; margin-right: 7px;'></i>");
                $('#PhraseUniqueToTranslateIT').prev('.fa-play-Benoit')[0].onclick = function () {
                    $("#PhraseUniqueToTranslateIT").css('color', 'blue');
                    responsiveVoice.speak($("#PhraseUniqueToTranslateIT").text(), GetVoiceForResponsive("ita"), {
                        onend: function () {
                            $("#PhraseUniqueToTranslateIT").css('color', 'black');
                        }
                    });
                };
                TranslateOtherLanguageThanFrench(row, 'ita', 'PhraseUniqueToTranslateIT', 'fra');
            }
        }
    }
}

function ListenSentenceInFrench(i) {
    $("#tdInTable_" + i + "_").css('color', 'blue');
    responsiveVoice.speak($('#tdInTable_' + i + '_').text(), GetVoiceForResponsive("fra"), {
        onend: function () {
            $("#tdInTable_" + i + "_").css('color', 'black');
        }
    });
}