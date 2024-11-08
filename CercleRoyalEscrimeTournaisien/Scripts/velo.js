$(document).ready(function () {
    ActiveFonctionsGsm();
});


function ActiveFonctionsGsm() {
    if (window.matchMedia("(max-width: 767px)").matches) {

    }
    else {

    }
}

function ListenHour() {
    var sequency = $("#SequencyListenHour").val();

    if (sequency == null || sequency == "") { return; }
    setInterval(function () { ListenHourWithSequency(sequency); }, 60000 * sequency)
   // setInterval(function () { GetLocationActual(); }, 2000)

}

function ListenHourWithSequency(sequency) {
    var dt = new Date();
    var time = dt.getHours() + "h" + dt.getMinutes();

    responsiveVoice.cancel();
    responsiveVoice.speak(time, "French Female")
}

function GetLocationActual() {


    

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(locationSuccess);
    } else {
        $("#locationData").html('Your browser does not support location data retrieval.');
    }


    //if ("geolocation" in navigator)
    //{ 
    //    navigator.geolocation.getCurrentPosition(function (position) {
    //        responsiveVoice.cancel();
    //        responsiveVoice.speak("latitude: " + position.coords.latitude + ". longitude : " + position.coords.longitude, "French Female")
    //        console.log("latitude: " + position.coords.latitude + ". longitude : " + position.coords.longitude);
    //    });
    //} else {
    //    console.log("Browser doesn't support geolocation!");
    //}
}

function locationSuccess(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;
    $("#locationData").html("Latitude: " + latitude + "<br>Longitude: " + longitude);
}

function distance(lat1, lon1, lat2, lon2, unit) {
    var radlat1 = Math.PI * lat1 / 180
    var radlat2 = Math.PI * lat2 / 180
    var theta = lon1 - lon2
    var radtheta = Math.PI * theta / 180
    var dist = Math.sin(radlat1) * Math.sin(radlat2) + Math.cos(radlat1) * Math.cos(radlat2) * Math.cos(radtheta);
    dist = Math.acos(dist)
    dist = dist * 180 / Math.PI
    dist = dist * 60 * 1.1515
    if (unit == "K") { dist = dist * 1.609344 }
    if (unit == "N") { dist = dist * 0.8684 }
    return dist
}