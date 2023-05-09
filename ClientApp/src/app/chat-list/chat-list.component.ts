import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from '../services/message.service';
import { Message } from '../models/message';
import { Chat } from '../models/chat';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.css']
})
export class ChatListComponent implements OnInit {
  msgs: Message[] = [];
  selectedMessage!: Message;

  constructor(private messageService: MessageService) {}

  @Input() set selectedMainMessage(message: Message) {
    this.selectedMessage = message;
  }

  ngOnInit(): void {
    this.messageService.getChat().subscribe((result: Message[]) => {
      this.msgs = result;
    });
  }

  showMsgs() {
    if (!this.selectedMessage) {
      return [];
    }
    return this.msgs.filter(
      (x) => x.chatId != this.selectedMessage.id && x.MainMessageId == x.chatId
    );
  }
}
