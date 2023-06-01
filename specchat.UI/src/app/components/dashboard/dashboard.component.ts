import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { QRCodeModule } from 'angularx-qrcode';
import { Chat } from 'src/app/_models/chat';
import { ChatUser } from 'src/app/_models/chatuser';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/services/auth.service';
import { ChatService } from 'src/app/services/chat.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  chats: Chat[] = [];
  users: User[] = [];
  selectedChatId: string = '';
  selectedUserId: string = '';
  chatStates: { [key: string]: boolean } = {};
  router: Router;
  errorMessage: string = "";
  newChatName: string = "";
  chatusers: User[] = [];
  link: string = '';
  qrString: string = '';
  qr: QRCodeModule


  constructor(private chatService: ChatService, private authService: AuthService, router: Router, qr: QRCodeModule) {
    this.router = router;
    this.qr = qr;
  }

  ngOnInit(): void {
    this.loadChats();
    this.loadUsers();
  }

  loadChats(): void {
    this.chatService.getAllChats().subscribe((result: Chat[]) => {
      this.chats = result;
      console.log(this.chats)
    });
  }

  loadUsers(): void {
    this.authService.getUsers().subscribe((result: User[]) => {
      this.users = result;
    });
  }

  loadChatUsers(chatId: string): void {
    for (const id in this.chatStates) {
      if (id !== chatId) {
        this.chatStates[id] = false; // Close other collapsible areas
      }
    }
    
    this.chatStates[chatId] = !this.chatStates[chatId]; // Toggle the state of the clicked collapsible area
    
    if (this.chatStates[chatId]) {
    this.chatService.getUserByChatId(chatId).subscribe((result: User[]) => {
      console.log(result)
      this.chatusers = result
    })
    }
  }

  addUserToChat(): void {
    if (this.selectedChatId && this.selectedUserId) {
      this.chatService.addUserToChat(this.selectedChatId, this.selectedUserId).subscribe(() => {
        console.log("Success");
      }, error => {
        this.errorMessage = "User already in chat";
      });
    }
  }

  removeUserFromChat(chatId: string, userId: string) {
    this.chatService.removeUserFromChat(chatId, userId).subscribe(() => {
      console.log("Success");
      this.loadChatUsers(chatId)
    }, error => {
      this.errorMessage = "Failed to remove user from chat";
    });
  }

  goToHome(): void {
    this.router.navigateByUrl('/home');
  }

  addNewChat(): void {
    if (this.newChatName) {
      var chat = new Chat();
      chat.name = this.newChatName;
      this.chatService.addNewChat(chat).subscribe(
        () => {
          this.loadChats();
        }
      );
      this.newChatName = '';

    }
  }

  deleteChat(id: string) {
    this.chatService.deleteChat(id).subscribe(result => {
      this.loadChats()
    });
  }

  exportChat(id: string) {
    this.chatService.getJsonLink(id).subscribe(result => {
      this.qrString = 'https://localhost:7069/saves/' + result.link
    })
  }
}
