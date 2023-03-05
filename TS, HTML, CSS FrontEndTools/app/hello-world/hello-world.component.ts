import { formatCurrency } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.css']

})
export class HelloWorldComponent implements OnInit {

  otsikko = 'Halloween kuvat';
  testi = 'testi';

  itemImageURL = '/assets/Kuvat/halloweenKuva1.jpg';

  oneButtonClicked() {
    if (this.itemImageURL == '/assets/Kuvat/halloweenKuva1.jpg') {
      this.itemImageURL = '/assets/Kuvat/halloweenKuva2.jpg'
    }
    else {
      this.itemImageURL = '/assets/Kuvat/halloweenKuva1.jpg'
    }
  }

  constructor() { }

  ngOnInit(): void {
  }
}







