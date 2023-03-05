import { Component, OnInit } from '@angular/core';
import { FeedbackService } from '../Services/feedback.service';
import { Question } from '../question';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.css']
})
export class FeedbackComponent implements OnInit {

  questions: Question[];

  constructor(service: FeedbackService) {

    this.questions = service.getData();

  }

  ngOnInit(): void { }







  OnInputChange(e: any, x: Question): void {

    x.setAnswer(e.value)

  }


}




