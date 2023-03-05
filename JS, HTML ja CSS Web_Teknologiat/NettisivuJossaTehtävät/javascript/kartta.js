

let alkuhomma = "https://www.google.com/maps?q="
let katuosoite = ""
let kaupunki = ""
let loppuhomma = "&output=embed"



function HaeOsoite() {

    katuosoite = document.getElementById("katuosoiteArvo").value;
    kaupunki = document.getElementById("kaupunkiArvo").value;

    (document.getElementById("inlineFrameExample").src) = alkuhomma + katuosoite + kaupunki + loppuhomma;
}



document.body.style.backgroundImage = "url('images/backgroundimage.jpg')";
document.body.style.backgroundSize = "cover"