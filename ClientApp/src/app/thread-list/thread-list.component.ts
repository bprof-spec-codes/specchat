import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from '../services/message.service';
import { Message } from '../models/message';
import { Chat } from '../models/chat';

@Component({
  selector: 'app-thread-list',
  templateUrl: './thread-list.component.html',
  styleUrls: ['./thread-list.component.css']
})
export class ThreadListComponent implements OnInit {
  msgs: Message[] = [];
  selectedChat!: Chat;

  constructor(private messageService: MessageService) {}

  @Input() set selectedThread(chat: Chat) {
    this.selectedChat = chat;
  }

  ngOnInit(): void {
    this.messageService.getChat().subscribe((result: Message[]) => {
      this.msgs = result;
    });
  }

  showMsgs() {
    if (!this.selectedChat) {
      return [];
    }
    return this.msgs.filter(
      (x) => x.chatId === this.selectedChat.id && x.MainMessageId == null
    );
  }
}
