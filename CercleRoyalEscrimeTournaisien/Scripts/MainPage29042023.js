$(document).ready(function () {
    ActiveFonctionsGsm();
});

var tag = document.createElement('script');
tag.id = 'iframe-demo';
tag.src = 'https://www.youtube.com/iframe_api';
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

var player;
function onYouTubeIframeAPIReady() {
    player = new YT.Player('existing-iframe-example', {
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}

function onPlayerReady(event) {
    document.getElementById('existing-iframe-example').style.border = "5px solid " + '#FF6D00';
    $("#textVideo").text("Vidéo chargée..");
}

function changeBorderColor(playerStatus) {
    var color;
    if (playerStatus == -1) {
        color = "#37474F"; // unstarted = gray
    } else if (playerStatus == 0) {
        color = "#FFFF00"; // ended = yellow
    } else if (playerStatus == 1) {
        color = "#33691E"; // playing = green
    } else if (playerStatus == 2) {
        color = "#DD2C00"; // paused = red
    } else if (playerStatus == 3) {
        color = "#AA00FF"; // buffering = purple
    } else if (playerStatus == 5) {
        color = "#FF6DOO"; // video cued = orange
    }
    if (color) {
        document.getElementById('existing-iframe-example').style.border = "5px solid" + color;

    }
}

function onPlayerStateChange(event) {
    changeBorderColor(event.data);

    setInterval(function () {
        //$("#textVideo").text(player.getCurrentTime());
        changeTexteAutomatique();
    }, 1000);
}

function changeTexteAutomatique() {
    switch ($("#CurrentVideo").val()) {
        case "0":
            if (CheckText(player.getCurrentTime(), 0, 14)) {
                $("#textVideo").html("L'escrime. <br> Un sport de combat qui affronte deux tireurs ou deux équipes.");
            }

            if (CheckText(player.getCurrentTime(), 15, 18)) {
                $("#textVideo").text("L'escrime comporte 3 armes : le fleuret, l'épée et le sabre.");
            }

            if (CheckText(player.getCurrentTime(), 19 , 34)) {
                $("#textVideo").html("C'est un sport où l'on doit bouger vite. <br> Adopter une stratégie de manière rapide, adapter son jeu, sa vitesse, changer de rythme, trouver un point faible, une ouverture.");
            }

            if (CheckText(player.getCurrentTime(), 34 , 39)) {
                $("#textVideo").html("L'escrime est un sport de patience, où l'on prend son temps pour attaquer au bon moment.");
            }

            if (CheckText(player.getCurrentTime(), 40 , 44)) {
                $("#textVideo").html("Le marquoir est composé de 3 couleurs: rouge, verte et blanche (pour les touches non valables).");
            }

            if (CheckText(player.getCurrentTime(), 45, 55)) {
                $("#textVideo").html("Dépendant de l'arme, le coup des 2 veuves existe. <br> Dans le dos, au ventre, au pied, à la tête, à la saignée, chaque attaque peut toucher.");
            }

            if (CheckText(player.getCurrentTime(), 56 , 85)) {
                $("#textVideo").html("Le fleuret, arme apprise à l'escrime, est une arme plus compliquée à comprendre. Il y a des priorités. <br> le coup des deux veuves n'existe pas. L'un a priorité et a donc le point ou alors les deux ont fait la même action et aucun point n'est accordé. ");
            }

            if (CheckText(player.getCurrentTime(), 86 , 122)) {
                $("#textVideo").html("Vient la dernière arme, le sabre. arme aussi où l'on parle de priorités. <br> Se protéger en parant l'attaque, attaquer, cette arme a ses propres règles. Plus rapide, plus locomoteur, les jambes doivent être au rendez-vous...");
            }

            break;     
        case "1":
            if (CheckText(player.getCurrentTime(), 0, 5)) {
                $("#textVideo").html("Le fleuret<br>est la première arme apprise à l'escrime.");
            }

            if (CheckText(player.getCurrentTime(), 6, 21)) {
                $("#textVideo").html("La surface valable est le plastron la partie argentée qu'on voit au dessus de la tunique blanche.<br>Le fleuret est une arme d'estoc. Ce qui veut dire qu'on ne peut toucher son adversaire qu'avec la pointe. Sinon l'appareil ne sonnera pas.");
            }

            if (CheckText(player.getCurrentTime(), 22, 40 )) {
                $("#textVideo").html("C'est l'arme la plus légère des trois... elle ne pèse que 500 grammes maximum. elle est très flexible.<br>Beaucoup de touches sont portées grâce à la flexibilité de la lame.");
            }

            if (CheckText(player.getCurrentTime(), 41, 52)) {
                $("#textVideo").html("Les coups de fleuret peuvent être portées dans le dos, sur le ventre, le torse.");
            }

            if (CheckText(player.getCurrentTime(), 53, 60)) {
                $("#textVideo").html("Nous voyons sur ce schéma les surfaces valables des 3 armes en jaune. ");
            }

            if (CheckText(player.getCurrentTime(), 61, 74)) {
                $("#textVideo").html("Le premier qui touche n'a pas forcément le point. il y a des règles de priorité.");
            }

            if (CheckText(player.getCurrentTime(), 75, 103)) {
                $("#textVideo").html("Celui qui attaque prend la priorité. ");
            }

            if (CheckText(player.getCurrentTime(), 104, 119)) {
                $("#textVideo").html("Celui qui pare l'attaque reprend la priorité.");
            }

            if (CheckText(player.getCurrentTime(), 120,125)) {
                $("#textVideo").html("Celui qui a la priorité gagne le point par décision de l'arbitre.");
            }

            if (CheckText(player.getCurrentTime(), 126,144)) {
                $("#textVideo").html("Un match se fait en 3 x 3 minutes. en 15 touches. ");
            }

            break;
        case "2":
            if (CheckText(player.getCurrentTime(), 0, 19)) {
                $("#textVideo").html("L'épée<br>L'arme la plus lourde");
            }

            if (CheckText(player.getCurrentTime(), 20, 40)) {
                $("#textVideo").html("Tout est valable. De la tête au pied.");
            }

            if (CheckText(player.getCurrentTime(), 41, 82)) {
                $("#textVideo").html("C'est une arme d'estoc. Cela veut dire qu'on ne touche qu'avec la pointe comme le fleuret.");
            }

            if (CheckText(player.getCurrentTime(), 83, 112)) {
                $("#textVideo").html("Il n 'y a pas de règle.<br>Le premier qui touche a le point.<br>Les deux touchent, les deux ont un point.");
            }

            if (CheckText(player.getCurrentTime(), 113, 115)) {
                $("#textVideo").html("Un match en 15 touches dure 3 x 3 minutes avec 1 minute de repos entre chaque 3 minutes.");
            }

            if (CheckText(player.getCurrentTime(), 116, 140)) {
                $("#textVideo").html("Le premier à 15 points gagne le match.");
            }
    }
}

function CheckText(currentTime, timeBegin, timeEnd) {
    if (currentTime > timeBegin && currentTime < timeEnd) {
        return true;
    }
    return false;
}

function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {
       
    }
    else {
       
    }
}

function ChangeVideo(step) {
    var data = $("#bodyMainPage29042023 :input").serializeArray();
    data.push({ name: "step", value: step });

    $.ajax({
        url: '/MainPage29042023/ChangeVideo',
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: 'application/x-www-form-urlencoded; charset=UTF-8',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        success: function (result) {
            $('#bodyMainPage29042023').html(result.mainPage29042023);
            onYouTubeIframeAPIReady();
        },
        failure: function (response) { },
        error: function (response) { }
    });
}

function ShowMenuPrincipal() {
    var data = [];
    $.ajax({
        url: '/MainPage29042023/ShowMenuPrincipal',
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: 'application/x-www-form-urlencoded; charset=UTF-8',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        success: function (result) {
            $('#bodyShowMenuPrincipal').html(result.modelShowMenuPrincipal);
        },
        failure: function (response) { },
        error: function (response) { }
    });
}