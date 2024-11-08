$(document).ready(function () {
    ActiveFonctionsGsm();

   

});




function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {
        $(".classLabelSentence").css('font-size', '9px');
        $(".classFontSize17").css('font-size', '9px!important');
        $(".btn-group").css('zoom', '0.6')
        $(".classLabelSentence").css('line-height', '13px');
        $(".form-group").css('margin-bottom', '0px')
        $("#divForIcones").eq(0).css('height', '24%')
        $(".modal-content").css('width', '97%');
        $(".modal-content").css('top', '6%');

        $('.form-group').each(function (index, item) {
            $(this).css('zoom','0.5');
        })
        $('.form-group').find('option').each(function (index, item) {
            $(this).css('font-size', '30px');
        })
    }
    else {
        $(".classLabelSentence").css('font-size', '16px');
        $(".classFontSize17").css('font-size', '16px!important');
        $(".btn-group").css('zoom', '')
        $(".classLabelSentence").css('line-height', '15px');
        $(".form-group").css('margin-bottom', '15px')
        $("#divForIcones").eq(0).css('height', '9%')
        $(".modal-content").css('width', '25%');
        $(".modal-content").css('top', '24%');
    }
}

function GetAllUrls() {
        var data = $("#ScreenPDFPageDiv :input").serializeArray();
        var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
        var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';        

        $.ajax({
            url: '/MainPage/GetAllUrls',
            type: 'GET',
            cache: false,
            data: data,
            dataType: 'json',
            processData: processdata,
            contentType: contentType,
            success: function (result) {
                $('#ScreenPDFPageDiv').html(result.modelBDFile);
            },
            failure: function (response) { },
            error: function (response) { }
        });     
}

function LoadBD() {
    var data = $("#ScreenPDFPageDiv :input").serializeArray();
    var processdata = 'application/x-www-form-urlencoded; charset=UTF-8';
    var contentType = 'application/x-www-form-urlencoded; charset=UTF-8';

    $.ajax({
        url: '/MainPage/LoadBD',
        type: 'POST',
        cache: false,
        data: data,
        dataType: 'json',
        processData: processdata,
        contentType: contentType,
        success: function (result) {
            window.open(result.url, "_blank");             
        },
        failure: function (response) { },
        error: function (response) { }
    });
}