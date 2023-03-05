import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject } from 'rxjs';
import { AngularFireAuth } from '@angular/fire/compat/auth'



@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {

  private userEmail: BehaviorSubject<string> = new BehaviorSubject<string>('');

  constructor(public afAuth: AngularFireAuth,
    public router: Router) { }


  login(email: any, password: any) {           //funktiota kutsutaan, kun klikataan LOGIN

    console.log(email + ' service');

    return this.afAuth.signInWithEmailAndPassword(email, password)

      .then(result => {
        this.userEmail.next(email);
        this.router.navigate(['admin/main']);
      })
      .catch((error) => {
        console.log('Jokin meni pieleen xd ' + error.message)
        alert(error.message)
      });


  }

  logout() {                       //funktiota kutsutaan, kun klikataan LOGOUT
    return this.afAuth.signOut()

      .then(result => {
        this.userEmail.next("");
        this.router.navigate(['home']);
      })

  }

  getLoggedInUser(): any {          //funktiota kutsutaan canActivate()-funktiossa
    return this.afAuth.authState;

  }

  checkLoggedInUser() {    //funktio palauttaa kirjautuneen käyttäjän spostin
    return this.userEmail;

  }

}
