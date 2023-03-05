import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-form',
  templateUrl: './template-driven-form.component.html',
  styleUrls: ['./template-driven-form.component.css']
})
export class TemplateDrivenFormComponent implements OnInit {

  person: Person;
  form1: any;

  onSubmit(form1: any) {
    console.log('firstName: ' + form1.value.firstName);
    console.log(form1.controls.firstName.status);

    console.log('lastName: ' + form1.value.lastName);
    console.log(form1.controls.lastName.status);

    console.log('personId ' + form1.value.personID);
    console.log(form1.controls.personID.status);

    console.log('email: ' + form1.value.email);
    console.log(form1.controls.email.status);

    console.log('username ' + form1.value.username);
    console.log(form1.controls.username.status);

    //console.log(form1.value.password);
    //console.log(form1.controls.password.status);

    console.log('password ' + form1.value.password2);
    console.log(form1.controls.password2.status);

    console.log('checkbox ' + form1.value.checkbox);
    console.log(form1.controls.checkbox.status);

  }

  constructor() {

    this.person = new Person;

  }



  ngOnInit(): void {
  }

}
export class Person {

  firstName: string = '';
  lastName: string = '';
  personID: any = '';
  email: any = '';
  username: any = '';
  password: any = '';
  password2: any = '';
  checkbox: any = '';



}