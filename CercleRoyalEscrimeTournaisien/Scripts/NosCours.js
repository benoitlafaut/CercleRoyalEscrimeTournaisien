$(document).ready(function () {
    config.speakSelectedText = false;
    config.welcomeMessage = "";
});
function LireTexte(text, SonElement, hasMale) {
    var voiceToRead = 'French Female';
    if (hasMale == 'True') {
        var voiceToRead = 'French Male';
    }
    
    if (responsiveVoice.isPlaying())
    {
        responsiveVoice.cancel(); 
        responsiveVoice.resume(); 
        alert('Attendez que la lecture soit finie. La phrase désirée va être écoutée dans quelques instants.');

        setTimeout(function () {
            LireTexte(text, SonElement, hasMale);
        }, 1000);

        return;
    }

    responsiveVoice.speak(text, voiceToRead, {
        rate: 1,
        onend: function () {
            $(SonElement).css('color', 'black');
        },
        onstart: function () {
            $(SonElement).css('color', 'blue');
        },
        onerror: function (e) {
            $(SonElement).css('color', 'black');
        }
    });
}

function AdaptHeadPhone() {
    $(".fa-headphones").css('opacity', '1');
    $(".fa-headphones").css('point-event', 'none');
}

function ExpandCollapse() {
    if ($("#buttonCollapseDevelopp").prop("value") == "Développer tout") {
        $("#buttonCollapseDevelopp").prop("value", "Regrouper tout");
        $(".accordion").next('.ClassPanel').css('display', 'block');
        $(".accordion").addClass('active');
    }
    else {
        $("#buttonCollapseDevelopp").prop("value", "Développer tout");
        $(".accordion").next('.ClassPanel').css('display', 'none');
        $(".accordion").removeClass('active');
    }
}