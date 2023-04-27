import { Component } from '@angular/core';
import { ChatService } from '../services/chat.service';
import { Chat } from '../models/chat';

@Component({
  selector: 'left-sidebar',
  templateUrl: './left-sidebar.component.html',
  styleUrls: ['./left-sidebar.component.css']
})
export class LeftSidebarComponent {
  chats?: Chat[] ;
  isExpanded = false;

  constructor(private chatService: ChatService) {}

  ngOnInit(): void {
    this.chatService.getChat().subscribe((result: Chat[]) => {
      this.chats = result;
    });
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}

