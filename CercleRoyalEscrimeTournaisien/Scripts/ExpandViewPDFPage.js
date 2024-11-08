var modal = document.getElementById("myModal");
var btn = document.getElementById("myBtnPDFPage");
var span = document.getElementsByClassName("close")[0];

$("#myModal").find('a').each(function (index, item) {
    $(this).css('cursor','pointer');
})


btn.onclick = function () {
    modal.style.display = "block";
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

function showPDF(url) {
    $("#framePDF").attr('src', url);
    modal.style.display = "none";
}

$("#button").click(function () {
    $("#frame").attr("src", "https://vk.com/topic-203785966_47460801");
});