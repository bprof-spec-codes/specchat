import { Component } from '@angular/core';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  selectedChat?: any;
  selectedMessage?: any;
  user: User
  isOpen = true

  constructor(private authService: AuthService) {
    this.user = new User();
  }

  ngOnInit(): void {
    if(localStorage.getItem('specchat-token')){
      this.authService.getUserInfo().subscribe(
        resp => {
          this.user = resp;
          console.log(this.user)
        }
      )
    }
  }

  onThreadSelected(event: Event) {
    const threadId = (event.target as HTMLDivElement).innerText.trim();
    console.log(`Selected thread ID: ${threadId}`);
  }

  onMessageSelected(event: Event) {
    const threadId = (event.target as HTMLDivElement).innerText.trim();
    console.log(`Selected thread ID: ${threadId}`);
  }

  onSidebarToggle(event: Event) {

  }
}
