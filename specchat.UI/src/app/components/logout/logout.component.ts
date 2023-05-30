import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.scss']
})
export class LogoutComponent {
  router: Router
  
  constructor(router: Router) {
    this.router = router
  }

  ngOnInit(): void {
    // reset and delete cookies
    localStorage.setItem('specchat-token', '')
    localStorage.setItem('specchat-token-expiration', '')
    localStorage.clear()
    
    this.router.navigate(['/home'])
  }

}
