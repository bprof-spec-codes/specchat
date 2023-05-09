import { Component } from '@angular/core';
import { Chat } from './models/chat';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  selectedChat!: Chat;

  onThreadSelected(event: Event) {
    const threadId = (event.target as HTMLDivElement).innerText.trim();
    console.log(`Selected thread ID: ${threadId}`);
  }
}

