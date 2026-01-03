$(document).ready(function () {
    
    $(".letter").click(function (element) {
        var lettreSelected = this.innerText;
        var textInput = $("#textInput").val();
        textInput = textInput + lettreSelected;
        $("#textInput").val(textInput);
    });

    $(document).on("click", ".ClassSpan", function () { ShowOrHideDefinition(this); });
});

function SearchMots() {
    let longueurMot;

    $.ajax({
        type: "GET",
        url: "/dico/SearchMots",
        data: { textInput: $("#textInput").val() },
        success: function (result) {
            let html = "<ul>";

            result.wordsOutputList.forEach(function (item) {
                if (longueurMot != item.WordLength) {
                    html += "<li style='font-weight:bold;color:coral;margin-top:10px;margin-bottom:10px;'>" + item.WordLength + "</li>";
                    longueurMot = item.WordLength;
                }
                html += "<li>";
                html += " <span class='ClassSpan'>" + item.Word + "</span>";
                html += " <ul>";
                html += " <li class='ClassDefinition' style='display:none;'>" + item.Definition + "</li>";
                html += " </ul>";
                html += "</li>";
            });

            html += "</ul>";

            $("#result").html(html);          
        }
    });
}
function ShowOrHideDefinition(element) {
    var elementSelected = $(element);

    var displayElement = elementSelected.next('ul').find('.ClassDefinition').css('display');
    if (displayElement == 'none') {
        elementSelected.next('ul').find('.ClassDefinition').css('display', 'block');
    }
    else {
        elementSelected.next('ul').find('.ClassDefinition').css('display', 'none');
    }
}
function ClearInput() {
    $("#textInput").val('');
}