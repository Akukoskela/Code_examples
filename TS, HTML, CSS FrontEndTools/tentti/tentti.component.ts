import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AbstractControl, ValidatorFn } from '@angular/forms';
import { TenttiServiceService } from '../tentti-service.service';

@Component({
  selector: 'app-tentti',
  templateUrl: './tentti.component.html',
  styleUrls: ['./tentti.component.css']
})
export class TenttiComponent implements OnInit {

  perusLippuMaara = 0;
  opiskelijaLippuMaara = 0;
  elakelaisLippuMaara = 0;

  lopullinenSumma = 0;


  profileForm: FormGroup;

  onSubmit() {

    this.service.tallennaTiedot(this.lopullinenSumma, this.profileForm.value.firstName, this.profileForm.value.lastName, this.profileForm.value.email)

    console.log('profileForm.firstNameValue: ' + this.profileForm.value.firstName);
    console.log('profileForm.lastNameValue: ' + this.profileForm.value.lastName);
    console.log('profileForm.emailValue: ' + this.profileForm.value.email);
    this.profileForm.reset();

    console.log('servicen tiedot: Etunimi: ' + this.service.etuNimi + ' Sukunimi: ' + this.service.sukuNimi + ' Lippujen hinta: ' + this.service.hinta + '€'); //testasin, että service luokaan tallentuu tiedot ja tideot tulevat consoliin.

  }


  constructor(public service: TenttiServiceService) {
    this.profileForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.minLength(2), Validators.pattern('^[a-zA-Z]*$')]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(2), Validators.pattern('^[a-zA-Z]*$')]),
      email: new FormControl('', [Validators.required, Validators.minLength(3), Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")])

    })
  }

  get firstName() {


    return this.profileForm.get('firstName');

  }

  get lastName() {
    return this.profileForm.get('lastName');
  }

  get email() {
    return this.profileForm.get('email');
  }

  ngOnInit(): void {
  }


  onInputChange1(event: any) {

    this.perusLippuMaara = event.value;





    this.lopullinenSumma = this.perusLippuMaara * 16 + this.opiskelijaLippuMaara * 10 + this.elakelaisLippuMaara * 8;



  }

  onInputChange2(event: any) {

    this.opiskelijaLippuMaara = event.value;
    this.lopullinenSumma = this.perusLippuMaara * 16 + this.opiskelijaLippuMaara * 10 + this.elakelaisLippuMaara * 8;
  }

  onInputChange3(event: any) {

    this.elakelaisLippuMaara = event.value;
    this.lopullinenSumma = this.perusLippuMaara * 16 + this.opiskelijaLippuMaara * 10 + this.elakelaisLippuMaara * 8;
  }



  onChange(event: any) {
    this.lopullinenSumma = this.lopullinenSumma - this.lopullinenSumma * 0.15;
    //en tiedä kuuluisiko alennus tulla eriksen jokaiselle lipputyypille, mutta senkin saisi tehtyä erilaiselle lausekkeella
  }




}


