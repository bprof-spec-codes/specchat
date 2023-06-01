import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from '../../_models/message';
import { Emoji } from '../../_models/emoji';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';
import { EmojiService } from 'src/app/services/emoji.service';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';


@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.scss']
})
export class ChatListComponent implements OnInit {
  msgs: Message[] = [];
  selectedMessage!: Message;
  user: User
  newMessageContent: string = ""

  constructor(private messageService: MessageService, 
              private authService: AuthService,
              private emojiService: EmojiService,
              private sanitizer: DomSanitizer ) {
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
          message.user = user;
        });
      });
    });
  }

  update(){
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
    if (!this.selectedMessage) {
      return [];
    }
    
    const filterMsgs = this.msgs.filter(
      (x) => x.mainMessageId == this.selectedMessage.id
    );
  
    const sortedMsgs = filterMsgs.sort((a, b) => {
      // Sort by isPinned first
      if (a.isPinned && !b.isPinned) {
        return -1; // a comes before b
      } else if (!a.isPinned && b.isPinned) {
        return 1; // b comes before a
      }
  
      // Sort by date if isPinned values are the same
      const timeA = new Date(a.time).getTime();
      const timeB = new Date(b.time).getTime();
      return timeA - timeB;
    });
  
    return sortedMsgs;
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
        console.log(result)
          this.newMessageContent = '';
          this.update()
          this.showMsgs()
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

  pinMsg(message: Message) {
    const pinnedMsgCount = this.msgs.filter((msg) => msg.isPinned).length;
  
    if (message.isPinned) {
      message.isPinned = false;
    } else {
      if (pinnedMsgCount >= 3) {
        return;
      }
  
      message.isPinned = true;
    }
  
    this.messageService.updateMessage(message).subscribe((result) => {
      console.log(result);
      this.update();
      this.showMsgs();
    });
  }

  reactwithEmoji(code: number, msgid: string){
    var emoji = new Emoji()

    switch(code){
      case 1:
        emoji.code = ":smikring:"
        break;
      case 2:
        emoji.code = ":checkmark:"
        break;
      case 3:
        emoji.code = ":heart:"
        break;
    }
    
    emoji.messageId = msgid
    emoji.userId = this.user.id

    this.emojiService.addNewEmoji(emoji).subscribe(result => {
      console.log(result);
    })
  }

  replaceEmojiCodes(content: string): SafeHtml {
    const emojiMap: Record<string, string> = {
      ':smikring:': '😊',
      ':checkmark:': '✅',
      ':heart:': '❤️',
      // Add more emoji codes and their corresponding Unicode representations as needed
    };
  
    let replacedContent = content;
    for (const code in emojiMap) {
      const emoji = emojiMap[code];
      replacedContent = replacedContent.replace(code, emoji);
    }
  
    // Sanitize the replaced content to prevent any potential security issues
    return this.sanitizer.bypassSecurityTrustHtml(replacedContent);
  }
}
