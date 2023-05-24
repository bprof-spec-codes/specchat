import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
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
  msg: Message = new Message;

  @Output() selectedMainMessage = new EventEmitter<Message>();
  
  constructor(private messageService: MessageService) {}

  @Input() set selectedThread(chat: Chat) {
    this.selectedChat = chat;
  }

  ngOnInit(): void {
    this.messageService.getAll().subscribe((result: Message[]) => {
      this.msgs = result;
    });
  }

  showMsgs() {
    if (!this.selectedChat) {
      return [];
    }
    return this.msgs.filter(
      (x) =>  !x.MainMessageId && x.chatId == this.selectedChat.id
    );
  }

  onMainMessageClick(message: Message) {
    this.selectedMainMessage.emit(message);
  }

  sendMessage(content: string): void {
    
    console.log(content);
    this.msg.MainMessageId = "";
    this.msg.chatId = this.selectedChat.id;
    this.msg.content = content

    this.messageService.addNewMessage(this.msg)
      .subscribe((result) => {
      console.log(result);
    });

    // Clear the textarea after sending the message
    this.msg.content = '';
    this.msg.chatId = "";
  }
}
