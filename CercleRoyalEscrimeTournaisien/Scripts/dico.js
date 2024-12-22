$(document).ready(function () {
    $('#WordInputOne').keydown(function (event) {
        if (event.keyCode === 13) {
            searchWords();
        }
    });
});


function searchWords() {
    var url = 'https://thesaurus.altervista.org/thesaurus/v1?word=' + $("#WordInputOne").val() + '&language=fr_FR&output=json&key=n5zInINluKKTDBfvgrrD';
    $('#divDicoPart2').empty();
    $.ajax({
        url: url,
        type: 'GET',
        cache: false,
        dataType: 'json',
        success: function (response) {
            var result = [];
            result = response.response[0].list.synonyms.split("|");

            result.sort(function (a, b) {
                return a.length - b.length;
            });

            $("#summaryOfResults").empty();
            for (var i = 0; i < result.length; i++) {                
                $('#summaryOfResults').append('<ul onclick=' + 'clickOnWorld(this)' + '><li>' + result[i] + '  (' + result[i].length + ' lettres)' + '</li></ul>');
            }
        },
        error: function (response) {
            alert("Error. " + response.responseText);
        }
    });
}

function clickOnWorld(element) {
    var textSelected = $(element).find('li').text();
    $('#divDicoPart2').empty();
    var data = [];
    data.push({ name: "wordInputOne", value: textSelected });

    $.ajax({
        url: "/MainPage/searchWorlds",
        type: 'GET',
        cache: false,
        data: data,
        dataType: 'json',
        success: function (response) {
            
            for (i = 0; i < response.wordsOutputList.length; ++i)
            {         
                var spanText = '<span style="white-space:pre">' + response.wordsOutputList[i].Definition + '</span><hr>';
                $('#divDicoPart2').append(spanText);
            }
        },
        error: function (response) {
            alert("Error. " + response.responseText);
        }
    });
}

function ChangeTexte() {
    window.location.href = 'https://www.fsolver.fr/mots-fleches/' + $("#WorldInput").val();
}