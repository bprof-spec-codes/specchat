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
  msg: Message = new Message;

  constructor(private messageService: MessageService) {}

  @Output() closeMainMessage = new EventEmitter<any>();
  @Input() set selectedMainMessage(message: any) { this.selectedMessage = message; }

  ngOnInit(): void {
    this.messageService.getAll().subscribe((result: Message[]) => {
      this.msgs = result;
    });
  }

  showMsgs() {
    if (this.selectedMessage == null) {
      return [];
    }
    var filtermsg = this.msgs.filter(
      (x) =>  x.MainMessageId === this.selectedMessage?.id
    );
    return filtermsg;
  }

  closeThread() {
    this.selectedMessage = null;
    this.closeMainMessage.emit(this.selectedMessage);
  }

  sendMessage(content: string): void {
    console.log(content)
    this.msg.content = content;
    this.msg.MainMessageId = this.selectedMainMessage.id;
    this.msg.chatId = this.selectedMainMessage.chatId;

    this.messageService.addNewMessage(this.msg).subscribe(() => {
      // Success, do something if needed
    }, (error) => {
      // Error handling, display an error message or perform other actions
      console.log('Error:', error);
    });

    // Clear the textarea after sending the message
    this.msg.content = '';
  }
}
