function AddTireursSelectedToPoule() {
   // alert($("#ddlPoules option:selected").val());
   // alert($(".chk-tireur:checked").map(function () { return $(this).data('id'); }).get());

    if ($("#ddlPoules option:selected").val() == '') {
        alert("vous n'avez pas sélectionné la poule");
        return;
    }
    if ($(".chk-tireur:checked").map(function () { return $(this).data('id'); }).get() == '') {
        alert("vous n'avez pas sélectionné de tireur.");
        return;
    }    

    var pouleSelected = $("#ddlPoules option:selected").val();
    var tireursSelected = $(".chk-tireur:checked").map(function () { return $(this).data('id'); }).get();

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

    var pouleSelected = $("#ddlPoulesScores option:selected").val();
    var tireur1Guid = $("#Tireur1Selected").val();
    var tireur2Guid = $("#Tireur2Selected").val();
    var vainqueur = $("input[name='choixVictoire']:checked").val();
    var scoreTireur1 = $("#ScoreTireur1").val();
    var scoreTireur2 = $("#ScoreTireur2").val(); 

    

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
            scoreTireur2: scoreTireur2
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
        success: function (response) {
            console.log("OK", response);
        }
    });
}
