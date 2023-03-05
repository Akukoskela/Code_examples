import { getLocaleDateFormat } from '@angular/common';
import { Injectable } from '@angular/core';
import { FeedbackComponent } from '../feedback/feedback.component';
import { Question } from '../question';

@Injectable({
  providedIn: 'root'
})


export class FeedbackService {

  questions: Array<Question>;


  constructor() {
    this.questions = [new Question('Tyytyväisyytesi ohjelmaan?', ''), new Question('Tyytyväisyytesi henkilökuntaan?', ''), new Question('Tyytyväisyytesi ruokaan?', '')]
  }



  getData(): any {

    console.log('toimii');

    return this.questions;

  }
}






