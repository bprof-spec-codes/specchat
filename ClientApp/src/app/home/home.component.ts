import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  selectedChat?: any;
  selectedMessage?: any;

  onThreadSelected(event: Event) {
    const threadId = (event.target as HTMLDivElement).innerText.trim();
    console.log(`Selected thread ID: ${threadId}`);
  }

  onMessageSelected(event: Event) {
    const threadId = (event.target as HTMLDivElement).innerText.trim();
    console.log(`Selected thread ID: ${threadId}`);
  }
}
