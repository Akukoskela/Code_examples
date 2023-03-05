let x;
let y;
let z;
let vastaus;

function RandomNumero(max) {
    return Math.floor(Math.random() * max);
}

window.onload = function () {
    document.getElementById("tekstikenttä1").value = RandomNumero(parseInt(10));
    document.getElementById("tekstikenttä3").value = RandomNumero(parseInt(10));
}

function LisääYksiEka() {
    x = document.getElementById("tekstikenttä1").value;
    x++;
    document.getElementById("tekstikenttä1").value = x;
}

function VähennäYksiEka() {
    x = document.getElementById("tekstikenttä1").value;
    x--;
    document.getElementById("tekstikenttä1").value = x;
}

function LisääYksiToka() {
    x = document.getElementById("tekstikenttä3").value;
    x++;
    document.getElementById("tekstikenttä3").value = x;
}

function VähennäYksiToka() {
    x = document.getElementById("tekstikenttä3").value;
    x--;
    document.getElementById("tekstikenttä3").value = x;
}



function Plussa() {
    x = document.getElementById("tekstikenttä2").value;
    document.getElementById("tekstikenttä2").value = "+";
}

function Miinus() {
    x = document.getElementById("tekstikenttä2").value;
    document.getElementById("tekstikenttä2").value = "-";
}
function Kerto() {
    x = document.getElementById("tekstikenttä2").value;
    document.getElementById("tekstikenttä2").value = "*";
}

function Jako() {
    x = document.getElementById("tekstikenttä2").value;
    document.getElementById("tekstikenttä2").value = "/";
}



function Laske() {
    x = parseInt(document.getElementById("tekstikenttä1").value);
    y = parseInt(document.getElementById("tekstikenttä3").value);
    z = document.getElementById("tekstikenttä2").value;

    if (x > parseInt(10)) {
        alert("Numeroiden tarvii olla alle 10 arvoisia. " + x + " ei ole hyväksyttävä luku.")
    }
    else if (y > parseInt(10)) {
        alert("Numeroiden tarvii olla alle 10 arvoisia. " + y + " ei ole hyväksyttävä luku.")
    }
    else if (z == "+") {
        vastaus = x + y;
        document.getElementById("vastauskenttä").value = x + " + " + y + " = " + vastaus;
    }
    else if (z == "-") {
        vastaus = x - y;
        document.getElementById("vastauskenttä").value = x + " - " + y + " = " + vastaus;
    }
    else if (z == "*") {
        vastaus = x * y;
        document.getElementById("vastauskenttä").value = x + " * " + y + " = " + vastaus;
    }
    else if (z == "/") {
        vastaus = x / y;
        document.getElementById("vastauskenttä").value = x + " / " + y + " = " + vastaus;
    }



} document.body.style.backgroundImage = "url('images/backgroundimage.jpg')";
document.body.style.backgroundSize = "cover"