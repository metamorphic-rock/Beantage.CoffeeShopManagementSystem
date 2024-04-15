import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {

  user : string = "User"
  constructor(private router:Router){
  }

  isLoginPage() : boolean{
    return this.router.url === '/login';
  }
}
