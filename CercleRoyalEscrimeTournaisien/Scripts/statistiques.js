function chargerResultat() {
    let tireurSelected = $("#TireurSelected").val();
    let adversaireSelected = $("#AdversaireSelected").val();
    let armeSelected = $("#ArmeSelected").val();

    if (tireurSelected == adversaireSelected) {
        alert('Un tireur ne peut pas avoir comme adversaire soi-même.');
        return;
    }

    if (adversaireSelected == "") {
        alert('Un adversaire doit être sélectionné. Ou tous les tireurs (All tireurs)');
        return;
    }

    if (armeSelected == "") {
        alert('Une arme doit être sélectionnée. Ou toutes les armes (All armes)');
        return;
    }

    $.get('/Poules/Statistiques/' + '?tireurSelected=' + tireurSelected + '&adversaireSelected=' + adversaireSelected + '&armeSelected=' + armeSelected)
        .done(function (html) {
            $("#statistiquesDiv").html(html);
        });
}