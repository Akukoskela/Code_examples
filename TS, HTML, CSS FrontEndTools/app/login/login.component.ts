import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthServiceService } from '../Services/auth-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public router: Router, public authService: AuthServiceService) {


  }

  email = '';

  password = '';

  loginButtonClicked() {
    console.log(this.email + ' login')

    this.authService.login(this.email, this.password);
  }

  cancelButtonClicked() {
    this.router.navigate(['home']);
  }

  ngOnInit(): void {
  }

}
