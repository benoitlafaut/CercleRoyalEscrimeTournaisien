
$(document).ready(function () {
    $.startLoading = function () {
        $("#spinner-loading").css('display','flex');
    };

    $.stopLoading = function () {
        $("#spinner-loading").css('display', 'none');
    };
});
function AddTireursSelectedToPoule() {
    $.startLoading();

    if ($('input[name="PouleSelected"]').index($('input[name="PouleSelected"]:checked')) == -1) {
        alert("vous n'avez pas sélectionné la poule");
        $.stopLoading();
        return;
    }

    var pouleSelected = $('input[name="PouleSelected"]').index($('input[name="PouleSelected"]:checked'));
    var tireursSelected = $("#TireurSelected").val();

    $.ajax({
        url: "/Poules/AddTireursSelectedToPoule",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({ pouleSelected: pouleSelected, tireursSelected: tireursSelected }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);  
        }
    });
}

function AddUnNewComerToDB() {
    $.startLoading();

    if ($("#NewComerPrenom").val() == "") {
        alert("Le prénom est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerNom").val() == "") {
        alert("Le nom est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerBirthDate").val() == "") {
        alert("La date de naissance est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayMercrediSelected").val() == "") {
        alert("Le choix de poule pour mercredi est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayVendrediSelected").val() == "") {
        alert("Le choix de poule pour vendredi est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayDimancheSelected").val() == "") {
        alert("Le choix de poule pour dimanche est vide.");
        $.stopLoading();
        return;
    }

    var newComerGuidTireur = $("#NewGuidCreated").val();
    var newComerPrenom = $("#NewComerPrenom").val();
    var newComerNom = $("#NewComerNom").val();
    var newComerBirthDate = $("#NewComerBirthDate").val();
    var newComerDayMercrediSelected = $("#NewComerDayMercrediSelected").val();
    var newComerDayVendrediSelected = $("#NewComerDayVendrediSelected").val();
    var newComerDayDimancheSelected = $("#NewComerDayDimancheSelected").val();
    
    $.ajax({
        url: "/Poules/AddUnNewComerToDB",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
              newComerGuidTireur: newComerGuidTireur
            , newComerPrenom: newComerPrenom
            , newComerNom: newComerNom
            , newComerBirthDate: newComerBirthDate
            , newComerDayMercrediSelected: newComerDayMercrediSelected
            , newComerDayVendrediSelected: newComerDayVendrediSelected
            , newComerDayDimancheSelected: newComerDayDimancheSelected
        }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);  
        }
    });
}
function ConstruireLesLecons() {
    $.startLoading(); 

    $.ajax({
        url: "/Poules/ConstruireLesLecons",
        type: 'POST',
        contentType: 'application/json',       
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);
        }
    });
}

function ModifierUnTireur() {
    $.startLoading();
    
    if ($("#NewComerBirthDate").val() == "") {
        alert("La date de naissance est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayMercrediSelected").val() == "") {
        alert("Le choix de poule pour mercredi est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayVendrediSelected").val() == "") {
        alert("Le choix de poule pour vendredi est vide.");
        $.stopLoading();
        return;
    }
    if ($("#NewComerDayDimancheSelected").val() == "") {
        alert("Le choix de poule pour dimanche est vide.");
        $.stopLoading();
        return;
    }

    var newComerGuidTireur = $("#TireurSelected").val();
    var newComerBirthDate = $("#NewComerBirthDate").val();
    var newComerDayMercrediSelected = $("#NewComerDayMercrediSelected").val();
    var newComerDayVendrediSelected = $("#NewComerDayVendrediSelected").val();
    var newComerDayDimancheSelected = $("#NewComerDayDimancheSelected").val();

    $.ajax({
        url: "/Poules/ModifierUnTireur",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            newComerGuidTireur: newComerGuidTireur            
            , newComerBirthDate: newComerBirthDate
            , newComerDayMercrediSelected: newComerDayMercrediSelected
            , newComerDayVendrediSelected: newComerDayVendrediSelected
            , newComerDayDimancheSelected: newComerDayDimancheSelected
        }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);
        }
    });
}
function ConstruireLesPoules() {
    var pouleSelected = $("input[name='PouleSelected']:checked").val();

    if (pouleSelected == '') {
        alert("Aucune poule n'est sélectionnée.");
        return;
    }

    var ids = [];

    $('.chk-tireur:checked').each(function () {
        ids.push($(this).val());
    });

    var inputConstruireLesPoules = {
        ids: ids,
        pouleSelected: pouleSelected
    };

    $.ajax({
        url: '/Poules/ConstruireLesPoules',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(inputConstruireLesPoules),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        }
    });
}

function SearchDataTireur(guidTireurSelected) {
    $.ajax({
        url: "/Poules/ModifierUnTireur",
        type: "GET",
        data: { guidTireurSelected: guidTireurSelected },
        success: function (html) {
            $("#bodyPoules").html(html);
        },
        error: function (response) {
            alert("Error. " + response.responseText);
        }
    });

    
}
function AddScoreEliminationDirecte(dateDuJourWithoutDay, pouleSelected, round, tireur1Guid, tireur2Guid, inputScoreTireur1Guid, inputScoreTireur2Guid)
{
    if ($("#" + inputScoreTireur1Guid).val() == "" || $("#" + inputScoreTireur2Guid).val() == "") {
        alert("L'un des deux scores est vide.");
        return;
    }

    if ($("#" + inputScoreTireur1Guid).val() == $("#" + inputScoreTireur2Guid).val()) {
        alert("Il n'y a pas de vainqueur.");
        return;
    }

    $.startLoading();

    $.ajax({
        url: "/Poules/AddScoreEliminationDirecte",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            dateDuJourWithoutDay: dateDuJourWithoutDay,
            pouleSelected: pouleSelected,
            round: round,
            tireur1Guid: tireur1Guid,
            tireur2Guid: tireur2Guid,            
            inputScoreTireur1Guid: $("#" + inputScoreTireur1Guid).val(),
            inputScoreTireur2Guid: $("#" + inputScoreTireur2Guid).val()
        }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        }
    });
}
function AddScoreToTireursSelected() {
    if ($("#ddlPoulesScores option:selected").val() == '') {
        alert("vous n'avez pas sélectionné la poule");
        return;
    }

    if ($("#Tireur1Selected").val() == $("#Tireur2Selected").val()) {
        alert("Le tireur 1 ne peut pas être le tireur 2.");
        return;
    }

    if ($("input[name='choixVictoire']:checked").val() == undefined) {
        alert("Vous devez indiquer qui est le vainqueur.");
        return;
    }

    if ($("input[name='choixMene']:checked").val() == undefined) {
        alert("Vous devez indiquer si le perdant a mené pendant le match.");
        return;
    }

    

    if ($("#ScoreTireur1").val() == "" || $("#ScoreTireur2").val() == "") {
        alert("L'un des deux scores est vide.");
        return;
    }

    if ($("input[name='choixVictoire']:checked").val() == "1") {
        if ($("#ScoreTireur2").val() > $("#ScoreTireur1").val()) {
            alert("La victoire est pour le premier tireur mais le score n'est pas cohérent.");
            return;
        }
    }

    if ($("input[name='choixVictoire']:checked").val() == "2") {
        if ($("#ScoreTireur1").val() > $("#ScoreTireur2").val()) {
            alert("La victoire est pour le deuxième tireur mais le score n'est pas cohérent.");
            return;
        }
    }

    var pouleSelected = $("#ddlPoulesScores option:selected").val();
    var tireur1Guid = $("#Tireur1Selected").val();
    var tireur2Guid = $("#Tireur2Selected").val();
    var vainqueur = $("input[name='choixVictoire']:checked").val();
    var scoreTireur1 = $("#ScoreTireur1").val();
    var scoreTireur2 = $("#ScoreTireur2").val(); 
    var choixMene = $("input[name='choixMene']:checked").val();

    $.startLoading();

    $.ajax({
        url: "/Poules/AddScoreToTireursSelected",
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            pouleSelected: pouleSelected,
            tireur1Guid: tireur1Guid,
            tireur2Guid: tireur2Guid,
            vainqueur: vainqueur,
            scoreTireur1: scoreTireur1,
            scoreTireur2: scoreTireur2,
            questionMeneOuNon: choixMene
        }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        },
        failure: function (response) { },
        error: function (response) {
            alert("Error. " + response.responseText);  //
        }
    });
}

function CalculEliminatoires(nameTablePoule, pouleSelected) {
    $.startLoading();

    const ClassResultatsList = [];

    $("#" + nameTablePoule + " tr").each(function () {
        let tds = $(this).find("td");
        ClassResultatsList.push({
            NombreDeVictoiresParMatchs: $(tds[tds.length - 3]).text(),
            TDMoinsTR: $(tds[tds.length - 2]).text(),
            TD: $(tds[tds.length - 1]).text()
        });
    });

    $.ajax({
        url: '/Poules/TraiterTableau',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({ pouleSelected: pouleSelected, ClassResultatsList: ClassResultatsList }),
        success: function (data) {
            if (data.redirectUrl) { window.location.href = data.redirectUrl; }
        }
    });
}
