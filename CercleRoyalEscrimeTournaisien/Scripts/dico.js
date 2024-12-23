$(document).ready(function () {
    startDictation();

    $('#WorldInput').keydown(function (e) {
        var keyCode = e.keyCode || e.which;
        if (keyCode == 13) {
            OpenSiteFSolver();
            return false;
        }
    });
});

function OpenSiteFSolver() {
    var text = $("#WorldInput").val().replaceAll(' ', '*');
    var targetLink = 'https://www.fsolver.fr/mots-fleches/' + text;
    window.open(targetLink, '_blank', '');
}

var recognizing = false;

if ('webkitSpeechRecognition' in window) {

    var recognition = new webkitSpeechRecognition();
    recognition.continuous = true;
    recognition.interimResults = true;

    recognition.onstart = function () {
        recognizing = true;
    };

    recognition.onerror = function (event) {
        console.log(event.error);
    };

    recognition.onend = function () {
        recognizing = false;
    };

    recognition.onresult = function (event) {
        if (event.results[event.results.length - 1].isFinal) {
            if (event.results[event.results.length - 1][0].transcript.trim().toLowerCase() == "chercher") {
                $("#WorldInput").val($("#WorldInputTemporaire").val());
                OpenSiteFSolver();
                return false;
            }
            else {
                if (event.results[event.results.length - 1][0].transcript.trim().toLowerCase() == "effacer") {
                    $("#WorldInputTemporaire").val('');
                    $("#WorldInput").val('');
                    return false;
                }
                else {
                    var textToDictate = $("#WorldInputTemporaire").val() + event.results[event.results.length - 1][0].transcript;
                    $("#WorldInputTemporaire").val(textToDictate);
                }
            }
        }
    };
}

function startDictation() {
    if (recognizing) {
        recognition.stop();
        return;
    }
    final_transcript = '';
    recognition.lang = 'fr-FR';
    recognition.start();
    //final_span.innerHTML = '';
   // interim_span.innerHTML = '';
}
