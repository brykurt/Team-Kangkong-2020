import { Component, OnInit } from '@angular/core';
import { AuthService } from './core/auth-service.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: []
})
export class AppComponent implements OnInit {

  isLoggedIn = false;

  constructor(private _authService: AuthService) {
    this._authService.loginChanged.subscribe(loggeId =>{
      this.isLoggedIn = loggeId;
    });
  }

  login(){
    this._authService.login();
  }

  logout(){
    this._authService.logout();
  }

  ngOnInit() {
    this._authService.isLoggedIn().then(loggedIn =>{
      this.isLoggedIn = loggedIn
    });
  }
}
