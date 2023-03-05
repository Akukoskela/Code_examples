import { Component, OnInit } from '@angular/core';
import { PipeNamePipe } from '../pipes/pipe-name..pipe';
import { Observable } from 'rxjs';
import { CinemaService } from '../Services/cinema.service';



@Component({
  selector: 'app-cinema',
  templateUrl: './cinema.component.html',
  styleUrls: ['./cinema.component.css']
})
export class CinemaComponent implements OnInit {

  searchText = '';

  panelOpenState = false;

  public cinemaData$: Observable<any>;



  constructor(public cinema: CinemaService) {

    this.cinemaData$ = this.cinema.getData();

  }

  ngOnInit(): void {



  }

}



export class ExpansionOverviewExample {
  panelOpenState = false;
}


