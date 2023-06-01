import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { Message } from '../../_models/message';
import { Chat } from '../../_models/chat';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';
import { ChatService } from 'src/app/services/chat.service';
import { Emoji } from 'src/app/_models/emoji';
import { EmojiService } from 'src/app/services/emoji.service';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';

@Component({
  selector: 'app-thread-list',
  templateUrl: './thread-list.component.html',
  styleUrls: ['./thread-list.component.scss']
})
export class ThreadListComponent implements OnInit {
  msgs: Message[] = [];
  selectedChat!: Chat;
  user!: User
  newMessageContent: string = ""
  chatusers: User[] = []
  emojis: Emoji[] = []
  
  @Output() selectedMainMessage = new EventEmitter<Message>();
  
  constructor(private messageService: MessageService, private authService: AuthService, private chatService: ChatService,
    private emojiService: EmojiService, private sanitizer: DomSanitizer ) {}

  @Input() set selectedThread(chat: Chat) {
    this.selectedChat = chat;
    this.loadChatUsers(this.selectedChat.id)
  }

  @Input() set thisUser(user: User){
    this.user = user
  }

  ngOnInit(): void {
    this.messageService.getAll().subscribe((result: Message[]) => {
      this.msgs = result;

      this.msgs.forEach((message: Message) => {
        this.authService.getUserById(message.userId).subscribe((user: User) => {
          message.user = user;
        });
        this.emojiService.getById(message.id).subscribe((emoji: Emoji[]) => {
          message.emojis = emoji
          console.log(emoji)
        })
      });
    });
  }

  loadChatUsers(chatId: string) {
    this.chatService.getUserByChatId(chatId).subscribe((result: User[]) => {
      console.log(result)
      this.chatusers = result
    })
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
    if (!this.selectedChat) {
      return [];
    }
    
    const filterMsgs = this.msgs.filter(
      (x) => x.mainMessageId == null && x.chatId == this.selectedChat.id
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

  onMainMessageClick(message: Message) {
    this.selectedMainMessage.emit(message);
  }

  sendMessage(content: string): void {
    var msg = new Message();
    
    msg.id = ""
    msg.mainMessageId = null
    msg.content = content
    msg.userId = this.user.id
    msg.chatId = this.selectedChat.id

    this.messageService.addNewMessage(msg)
      .subscribe((result) => {
        this.messageService.getAll().subscribe((result: Message[]) => {
          this.msgs = result;
          this.update()
          this.showMsgs()
          const textarea: HTMLTextAreaElement = document.getElementById('newMessage') as HTMLTextAreaElement;
            if (textarea) {
              this.newMessageContent = '';
            }
          
        });
    });
  }

  dateParser(time: Date): string {
    const dateTimeParts = time.toString().split('T');
    const datePart = dateTimeParts[0];
    const timePart = dateTimeParts[1].substring(0, 5);
  
    const dateParts = datePart.split('-');
    const month = dateParts[1];
    const day = dateParts[2];
  
    const formattedDate = `${month}-${day}/${timePart}`;
  
    return formattedDate;
  }
  
  editMessage(messageId: string): void {
    var msg = this.msgs.find(t => t.id == messageId)
  }

  deleteMessage(messageId: string){
    this.messageService.deleteMessage(messageId).subscribe(
      (result) => {
        console.log(result)
        this.messageService.getAll().subscribe((result: Message[]) => {
          this.msgs = result;
          this.msgs.forEach((message: Message) => {
            this.authService.getUserById(message.userId).subscribe((user: User) => {
              message.user = user;
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
