import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AbstractControl, ValidatorFn } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent implements OnInit {

  profileForm: FormGroup;

  onSubmit() {


    console.log('profileForm.firstNameValue: ' + this.profileForm.value.firstName);
    console.log('profileForm.lastNameValue: ' + this.profileForm.value.lastName);
    console.log('profileForm.personIdValue: ' + this.profileForm.value.personId);
    console.log('profileForm.emailValue: ' + this.profileForm.value.email);
    console.log('profileForm.usernameValue: ' + this.profileForm.value.username);
    console.log('profileForm.passwordValue: ' + this.profileForm.value.password);
    console.log('profileForm.valid: ' + this.profileForm.valid);
    this.profileForm.reset();

  }



  constructor() {
    this.profileForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.minLength(2), Validators.pattern('^[a-zA-Z]*$')]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(2), Validators.pattern('^[a-zA-Z]*$')]),
      username: new FormControl('', [Validators.required, Validators.minLength(6), Validators.pattern('^[a-zA-Z]*$')]),
      personId: new FormControl('', [Validators.required, Validators.minLength(11), Validators.pattern('^(0[1-9]|[12]\\d|3[01])(0[1-9]|1[0-2])([5-9]\\d\+|\\d\\d-|[01]\\dA)\\d{3}[\\dA-Z]*$')]),
      email: new FormControl('', [Validators.required, Validators.minLength(3), Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")]),
      password: new FormControl('', [Validators.required, Validators.minLength(10), Validators.pattern("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{10,}$")]),
      password2: new FormControl('', [Validators.required]),
      checkbox: new FormControl('', [Validators.requiredTrue])
    })
  }

  get firstName() {


    return this.profileForm.get('firstName');

  }

  get lastName() {
    return this.profileForm.get('lastName');
  }


  get username() {
    return this.profileForm.get('username');
  }

  get password() {
    return this.profileForm.get('password');
  }

  get password2() {
    return this.profileForm.get('password2');
  }

  get personId() {

    return this.profileForm.get('personId');
  }


  get email() {
    return this.profileForm.get('email');
  }

  get checkbox() {
    return this.profileForm.get('checkbox');
  }



  ngOnInit(): void {

  }

}





