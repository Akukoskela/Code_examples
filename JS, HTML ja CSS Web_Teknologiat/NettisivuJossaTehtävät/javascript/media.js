
let array = [{ "name": "shaq", "src": "images/shaqi.jpg" }, {
    "name": "Ilves",
    "src": "images/IlvesLogo.jpg"
}, { "name": "Suomen lippu", "src": "images/SuomenLippu.jpg" }, { "name": "background", "src": "images/backgroundimage.jpg" }];

let index;
let toiminnontunniste;
let x = 1;

$(function () {
    index = 0;

    $('#kuvateksti').text(array[index].name);
    $('#kuva').attr('src', array[index].src);
})

$("#vasenNuoli").click(function () {
    index = index - 1;

    if (index < 0) {
        index = array.length - 1;

    }


    $('#kuvateksti').text(array[index].name);
    $('#kuva').attr('src', array[index].src);
});


$("#oikeaNuoli").click(function () {
    index = index + 1;

    if (index >= array.length) {
        index = 0;

    }

    $('#kuvateksti').text(array[index].name);
    $('#kuva').attr('src', array[index].src);
});




$("#playNuoli").click(

    function () {

        if (x == 1) {
            toiminnontunniste = setInterval(play, 2000);
            x = 0;
            $("#playNuoli").html('<i class="bi bi-stop"></i>');


        }
        else {
            window.clearInterval(toiminnontunniste);
            x = 1;
            $("#playNuoli").html('<i class="bi bi-play"></i>');

        }



    }
);


function play() {
    index = index + 1;

    if (index >= array.length) {
        index = 0;

    }

    $('#kuvateksti').text(array[index].name);
    $('#kuva').attr('src', array[index].src);
}

document.body.style.backgroundImage = "url('images/backgroundimage.jpg')";
document.body.style.backgroundSize = "cover"