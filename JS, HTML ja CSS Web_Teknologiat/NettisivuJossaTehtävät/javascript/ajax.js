document.getElementById("gifi").style.display = "none";
document.getElementById("accordionExample").style.display = "none";

let x = 0;


let data = ''


function loadDoc() {
    x++;

    document.getElementById("demo").innerHTML = null;

    document.getElementById("gifi").style.display = "block";

    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {

            let jsnonObject = JSON.parse(this.response)

            document.getElementById("gifi").style.display = "none";
            document.getElementById("accordionExample").style.display = "block";
            document.getElementById("demo").innerHTML = "<h3>Katso jutut alempaa!<h3>"
            document.getElementById("collapseOne").innerHTML = "<strong>" + jsnonObject.value.joke + "<strong/>";
            document.getElementById("collapseOne").className = "accordion-body p-2"
        }

    };



    xhttp.open("GET", "http://api.icndb.com/jokes/random", true);
    xhttp.send();




    document.getElementById("laskuri").innerHTML = "<p>Laskuri: " + x + "</p>"


    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {

            let jsnonObject = JSON.parse(this.response);

            document.getElementById("collapseTwo").innerHTML = "<strong>" + jsnonObject.value.joke + "<strong/>";

        }

    };



    xhttp.open("GET", "http://api.icndb.com/jokes/random", true);
    xhttp.send();


    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("collapseThree").innerHTML = "<strong>" + this.response + "<strong/>";

        }

    };



    xhttp.open("GET", "http://numbersapi.com/random", true);
    xhttp.send();


    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("collapseFour").innerHTML = "<strong>" + this.response + "<strong/>";

        }

    };



    xhttp.open("GET", "http://numbersapi.com/random", true);
    xhttp.send()

    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("collapseFive").innerHTML = "<strong>" + this.response + "<strong/>";

        }

    };



    xhttp.open("GET", "http://numbersapi.com/random", true);
    xhttp.send()

}




document.body.style.backgroundImage = "url('images/backgroundimage.jpg')";
document.body.style.backgroundSize = "cover"




function odotus() {

    document.getElementById("demo").innerHTML = null;

    document.getElementById("gifi").style.display = "block";
}

function odotusPois() {
    document.getElementById("gifi").style.display = "none";
}