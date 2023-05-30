import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Chat } from 'src/app/_models/chat';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.scss']
})
export class NavMenuComponent {
  selectedChat!: Chat
  @Output() toggleSidenav = new EventEmitter();
  @Input() set selectedChatI(chat: Chat) {
    this.selectedChat = chat;
  }
  
}

