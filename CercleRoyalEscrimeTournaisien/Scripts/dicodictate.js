$(function () {   
    startDictation();
})

var final_transcript = '';
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
        var interim_transcript = '';
        for (var i = event.resultIndex; i < event.results.length; ++i) {
            if (event.results[i].isFinal) {
                if (event.results[i][0].transcript.trim() == 'supprimer') { 
                    setTimeout(function () {
                        SupprimerText();
                    }, 200);
                }         

                if (event.results[i][0].transcript.trim() == 'rechercher') {
                    setTimeout(function () {                        
                        OpenFSolver();
                    }, 1000);
                }     

                final_transcript += event.results[i][0].transcript;                              
            }
            else {
                interim_transcript += event.results[i][0].transcript;
            }
        }
        final_transcript = capitalize(final_transcript);
        final_span.innerHTML = linebreak(final_transcript);
        interim_span.innerHTML = linebreak(interim_transcript);
    };
}

var two_line = /\n\n/g;
var one_line = /\n/g;
function linebreak(s) {
    return s.replace(two_line, '<p></p>').replace(one_line, '<br>');
}

function OpenFSolver() {
    var motARechercher = ($("#final_span").text()).replace('rechercher', '').trim();
    var urlTextToRechercher = 'https://www.fsolver.fr/mots-fleches/' + motARechercher;
    alert(urlTextToRechercher);
    window.open(urlTextToRechercher);
}

function SupprimerText() {
    $("#interim_span").text('');
    $("#final_span").text('');
    interim_transcript = "";
    final_transcript = "";
}
function capitalize(s) {
    return s.replace(s.substr(0, 1), function (m) { return m.toUpperCase(); });
}

function startDictation() {
    if (recognizing) {
        recognition.stop();
        return;
    }
    final_transcript = '';
    recognition.lang = 'fr-FR';
    recognition.start();
    final_span.innerHTML = '';
    interim_span.innerHTML = '';
}