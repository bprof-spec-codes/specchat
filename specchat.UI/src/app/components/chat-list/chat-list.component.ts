import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from '../../_models/message';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.scss']
})
export class ChatListComponent implements OnInit {
  msgs: Message[] = [];
  selectedMessage!: Message;
  user: User

  constructor(private messageService: MessageService, private authService: AuthService) {
    this.user = new User()
  }

  @Output() closeMainMessage = new EventEmitter<any>()
  @Input() set selectedMainMessage(message: any) { this.selectedMessage = message; console.log(this.selectedMessage) }
  @Input() set thisUser(user: User) { this.user = user }

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
    if (this.selectedMessage == null) {
      return [];
    }
    var filtermsg = this.msgs.filter(
      (x) =>  x.mainMessageId == this.selectedMessage.id
    );
    return filtermsg;
  }

  closeThread() {
    this.closeMainMessage.emit(null);
  }

  sendMessage(content: string): void {
    var msg = new Message();
    msg.id = ""
    msg.mainMessageId = this.selectedMessage.id
    msg.content = content
    msg.userId = this.user.id
    msg.chatId = this.selectedMessage.chatId

    this.messageService.addNewMessage(msg)
      .subscribe((result) => {
        this.messageService.getAll().subscribe((result: Message[]) => {
          this.msgs = result;
          const textarea: HTMLTextAreaElement = document.getElementById('newMessage') as HTMLTextAreaElement;
            if (textarea) {
              textarea.value = ''; // Reset the textarea value to an empty string
            }
          this.showMsgs()
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
