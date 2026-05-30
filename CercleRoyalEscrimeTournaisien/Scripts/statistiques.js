function chargerResultat() {
    let tireurSelected = $("#TireurSelected").val();
    let adversaireSelected = $("#AdversaireSelected").val();

    if (tireurSelected == adversaireSelected) {
        alert('Un tireur ne peut pas avoir comme adversaire soi-même.');
        return;
    }

    if (adversaireSelected == "") {
        alert('Un adversaire doit être sélectionné. Ou tous les tireurs (All tireurs)');
        return;
    }

    $.get('/Poules/Statistiques/' + '?tireurSelected=' + tireurSelected + '&adversaireSelected=' + adversaireSelected)
        .done(function (html) {
            $("#statistiquesDiv").html(html);
        });
}