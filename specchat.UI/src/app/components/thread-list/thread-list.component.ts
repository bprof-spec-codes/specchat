import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from '../../_models/message';
import { Chat } from '../../_models/chat';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-thread-list',
  templateUrl: './thread-list.component.html',
  styleUrls: ['./thread-list.component.scss']
})
export class ThreadListComponent implements OnInit {
  msgs: Message[] = [];
  selectedChat!: Chat;
  user!: User


  @Output() selectedMainMessage = new EventEmitter<Message>();
  
  constructor(private messageService: MessageService, private authService: AuthService) {}

  @Input() set selectedThread(chat: Chat) {
    this.selectedChat = chat;
    console.log(this.selectedChat)
  }

  @Input() set thisUser(user: User){
    this.user = user
  }

  ngOnInit(): void {
    this.messageService.getAll().subscribe((result: Message[]) => {
      this.msgs = result;

      this.msgs.forEach((message: Message) => {
        this.authService.getUserById(message.userId).subscribe((user: User) => {
          message.user = user; // Add the user to the message
        });
      });
    });
  }

  showMsgs() {
    if (!this.selectedChat) {
      return [];
    }
    return this.msgs.filter(
      (x) =>  x.mainMessageId == "" && x.chatId == this.selectedChat.id
      
    );
    
  }

  onMainMessageClick(message: Message) {
    this.selectedMainMessage.emit(message);
  }

  sendMessage(content: string): void {
    var msg = new Message();
    
    msg.id = ""
    msg.mainMessageId = ""
    msg.content = content
    msg.userId = this.user.id
    msg.chatId = this.selectedChat.id
    console.log(msg);

    this.messageService.addNewMessage(msg)
      .subscribe((result) => {
        this.messageService.getAll().subscribe((result: Message[]) => {
          this.msgs = result;
          const textarea: HTMLTextAreaElement = document.getElementById('newMessage') as HTMLTextAreaElement;
            if (textarea) {
              textarea.value = ''; // Reset the textarea value to an empty string
            }
          this.msgs.filter(
            (x) =>  x.mainMessageId == "" && x.chatId == this.selectedChat.id
          );
        });
    });
  }

  dateParser(time: Date): string {
    const dateTimeParts = time.toString().split('T');
    const datePart = dateTimeParts[0];
    const timePart = dateTimeParts[1].substring(0, 5); // Extract only the hour and minute part
  
    const dateParts = datePart.split('-');
    const month = dateParts[1];
    const day = dateParts[2];
  
    const formattedDate = `${month}-${day}/${timePart}`;
  
    return formattedDate;
  }
  
  editMessage(messageId: string): void {
    var msg = this.msgs.find(t => t.id == messageId)
    console.log("edit")
    console.log(msg?.userId != this.user.id)
  }

  deleteMessage(messageId: string){
    this.messageService.deleteMessage(messageId).subscribe(
      (result) => {
        console.log(result)
        this.messageService.getAll().subscribe((result: Message[]) => {
          this.msgs = result;
          this.msgs.forEach((message: Message) => {
            this.authService.getUserById(message.userId).subscribe((user: User) => {
              message.user = user; // Add the user to the message
            });
          });
        });
    })
  }
  
}
