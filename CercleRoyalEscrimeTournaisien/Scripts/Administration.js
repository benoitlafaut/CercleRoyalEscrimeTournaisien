$(document).ready(function () {
    $('#downloadBtn').click(function () {
        DownloadFile($("#UrlDownloadCompteAllOperations").val(), GenerateFilename("Export","xlsx"));
    });

    $("#downloadButton").click(function (e) {
        e.preventDefault();
        var anneeSelected = $("#anneeSelected").val();
        var url = $("#UrlDownloadCompteParAn").val() + "?anneeSelectedInput=" + anneeSelected;
        window.open(url, '_blank');
    });

    $("#downloadButtonRapportAnnuel").click(function (e) {
        e.preventDefault();
        var anneeSelected = $("#anneeSelected").val();
        var url = $("#UrlDownloadButtonRapportAnnuel").val() + "?anneeSelectedInput=" + anneeSelected + "&type=xls";
        window.open(url, '_blank');        
    });
});
function DownloadFile(url, filename) {
    const link = document.createElement('a');
    link.href = url;
    link.download = filename; // Set the new filename
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
function GenerateFilename(baseName, extension) {
    const now = new Date();
    const year = now.getFullYear();
    const month = String(now.getMonth() + 1).padStart(2, '0'); // Months are 0-based
    const day = String(now.getDate()).padStart(2, '0');
    const hour = String(now.getHours()).padStart(2, '0');
    const minute = String(now.getMinutes()).padStart(2, '0');

    return `${baseName}_${day}${month}${year}_${hour}H${minute}.${extension}`;
}
function ExpandName(tireurId) {
    if ($("#iconPlusId" + tireurId).attr('class') == 'fa fa-minus') {
        $("#tableExtendFiche" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_1" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_2" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_3" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_4" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_5" + tireurId).css('display', 'none');
        $("#tableExtendPaiement_6" + tireurId).css('display', 'none');
        $("#iconPlusId" + tireurId).removeClass().addClass('fa fa-plus');
    }
    else {
        $("#tableExtendFiche" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_1" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_2" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_3" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_4" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_5" + tireurId).css('display', 'block');
        $("#tableExtendPaiement_6" + tireurId).css('display', 'block');
        $("#iconPlusId" + tireurId).removeClass().addClass('fa fa-minus');
    }
}

function DropDownPeriodeChange() {
    $("#divLoading").css('display', 'grid');
    var period = $("#Periode").find('option:selected').val()

    $.ajax({
        type: "POST",
        url: "/MainPage/ChangePeriode",
        data: { period: period },
        success: function (result) {
            $("body").html(result);
        }
    });
}
function DownloadFileExcel() {
    const link = document.createElement('a');
    link.href = new URL('/FileToUpload/ExcelCompte/ExportCreateExcel.xlsx'); // Replace with your file path or URL
    link.download = new URL('/FileToUpload/ExcelCompte/ExportCreateExcel.xlsx');      // Desired file name
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}


function CreateUrl(url) {
    var periode = $("#Periode").val();
    return url + "?period=" + periode;
}

function CopyEmail(email) {
    navigator.clipboard.writeText(email);
}

function ChangeNomTireurASelectionner() {
    var tireurSpecificToSelected = $("#TireurSpecificToSelected").val().toLowerCase();

    $('*[id^="table_"]').each(function (index, element) {
        var idElement = $(element).attr("id").toLowerCase();
        if (idElement.indexOf(tireurSpecificToSelected) != -1) {
            $(element).css('display', 'block');
        }
        else {
            $(element).css('display', 'none');
        };
    });


}