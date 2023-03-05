import { Component, OnInit } from '@angular/core';
import { AuthServiceService } from '../Services/auth-service.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  kuvaURL = '/assets/Kuvat/jouko.jpg'
  constructor(public authService: AuthServiceService) { }

  ngOnInit(): void {
  }


  logoutbuttonClicked() {
    this.authService.logout();
  }
}
