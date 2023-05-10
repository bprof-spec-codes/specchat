import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MessageService } from '../services/message.service';
import { Message } from '../models/message';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.css']
})
export class ChatListComponent implements OnInit {
  msgs: Message[] = [];
  selectedMessage: Message | null = null;

  constructor(private messageService: MessageService) {}

  @Output() closeMainMessage = new EventEmitter<any>();
  @Input() set selectedMainMessage(message: any) { this.selectedMessage = message; }

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
      (x) => x.chatId != this.selectedMessage?.id && x.MainMessageId == x.chatId
    );
  }

  closeThread() {
    this.selectedMessage = null;
    this.closeMainMessage.emit(this.selectedMessage);
  }
}
