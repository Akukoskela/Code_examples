import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']


})
export class CalculatorComponent implements OnInit {

  buttons: string[] = ['1', '2', '3', 'C', '4', '5', '6', '+', '7', '8', '9', '-', '0', '*', '/', '='];


  result: string = "";


  ButtonClicked(value: string) {
    // document.getElementById('näyttö')!.value = '0'  //mikä hirttää kiinni??




    if (value == '=') {

      this.result = eval(this.result);

    }

    else if (value == 'C') {

      this.result = "";
    }

    else { this.result = this.result + value; }
  }







  constructor() { }

  ngOnInit(): void {
  }

}
