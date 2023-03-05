import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  kuvaURL = '/assets/Kuvat/koira1.jpg'

  constructor() { }

  ngOnInit(): void {
  }


  vaihdaKuva() {
    if (this.kuvaURL == '/assets/Kuvat/koira1.jpg') {
      this.kuvaURL = '/assets/Kuvat/koira2.jpg'
    }
    else if (this.kuvaURL == '/assets/Kuvat/koira2.jpg') {
      this.kuvaURL = '/assets/Kuvat/koira3.jpg'
    }
    else if (this.kuvaURL == '/assets/Kuvat/koira3.jpg') {
      this.kuvaURL = '/assets/Kuvat/koira4.jpg'
    }
    else {
      this.kuvaURL = '/assets/Kuvat/koira1.jpg'
    }
  }

}


