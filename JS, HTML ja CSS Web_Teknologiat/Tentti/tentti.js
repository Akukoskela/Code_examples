document.getElementById("infoTeksti").style.display = "none";
document.body.style.backgroundImage = "url(kuvat/vesitausta.jpg)";
document.body.style.backgroundSize = "cover";

let x = 1;
let y = 0;

function NäytäInfo() {
    if (x == 0) {
        document.getElementById("infoTeksti").style.display = "block";
        x++;
    }
    else {
        document.getElementById("infoTeksti").style.display = "none";
        x = 0;
    }
}



function ValitsePalvelu2() {
    document.getElementById("tekstikenttä").value = "Pikavuokraus 2h";


}

function ValitsePalvelu8() {
    document.getElementById("tekstikenttä").value = "Päivävuokraus 8h";
}

function ValitsePalvelu19() {
    document.getElementById("tekstikenttä").value = "Vuorokausivuokraus 19h";
}

function ValitsePalveluPesu() {
    document.getElementById("tekstikenttä").value = "Viikonloppuvuokraus Pe-Su";
}


function Miinus() {
    if (document.getElementById("numerokenttä").value > 0) {

        y = document.getElementById("numerokenttä").value;
        y--;
        document.getElementById("numerokenttä").value = y;
    }

}

function Plus() {


    y = document.getElementById("numerokenttä").value;
    y++;
    document.getElementById("numerokenttä").value = y;

}


function LaskeHinta() {
    let määrä;

    let hinta;

    määrä = document.getElementById("numerokenttä").value;

    if (document.getElementById("tekstikenttä").value == "Pikavuokraus 2h") {

        hinta = määrä * 15;

        document.getElementById("hintasarake").value = hinta;

    } else if (document.getElementById("tekstikenttä").value == "Päivävuokraus 8h") {

        hinta = määrä * 30;

        document.getElementById("hintasarake").value = hinta;

    } else if (document.getElementById("tekstikenttä").value == "Vuorokausivuokraus 19h") {

        hinta = määrä * 40;

        document.getElementById("hintasarake").value = hinta;

    } else if (document.getElementById("tekstikenttä").value == "Viikonloppuvuokraus Pe-Su") {

        hinta = määrä * 60;

        document.getElementById("hintasarake").value = hinta;
    }
}


function Nollaa() {
    document.getElementById("hintasarake").value = 0;
    document.getElementById("tekstikenttä").value = "Valitse palvelu";
    document.getElementById("numerokenttä").value = 0;
}