export class Question {



    name: string;
    vastaus: string;



    constructor(x: string, y: string) {
        this.name = x;
        this.vastaus = y;

    }

    setAnswer(y: any) {

        if (y == 0) {


            this.vastaus = "Ei arvosteltu";
        }
        else if (y == 1) {

            this.vastaus = "Tyydyttävä";

        } else if (y == 2) {

            this.vastaus = "Hyvä";

        } else if (y == 3) {

            this.vastaus = "Erinomainen";
        }
    }



}


