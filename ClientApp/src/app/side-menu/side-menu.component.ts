import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ChatService } from '../services/chat.service';
import { Chat } from '../models/chat';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.css']
})
export class SideMenuComponent implements OnInit {
  chats?: Chat[];
  isExpanded = false;

  constructor(private chatService: ChatService) {}

  selectedThreadId = "";
  @Output() selectedThread = new EventEmitter<Chat>();

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

  onThreadClick(chat: Chat) {
    this.selectedThreadId = chat.id;
    this.selectedThread.emit(chat);
  }
}