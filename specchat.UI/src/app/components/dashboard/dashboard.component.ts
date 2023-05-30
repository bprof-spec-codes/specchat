import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
  router: Router
  errormessage: string = "";
  newChatName: string = "";

  constructor(private chatService: ChatService, private authService: AuthService, router: Router) {
    this.router = router
  }

  ngOnInit(): void {
    this.loadChats();
    this.loadUsers();
  }

  loadChats(): void {
    this.chatService.getAllChats().subscribe((result: Chat[]) => {
      this.chats = result;
    });
  }

  loadUsers(): void {
    this.authService.getUsers().subscribe((result: User[]) => {
      this.users = result;
    });
  }

  addUserToChat(): void {
    if (this.selectedChatId && this.selectedUserId) {
      this.chatService.addUserToChat(this.selectedChatId, this.selectedUserId).subscribe(() => {
        console.log("Success");
      }, error => {
        this.errormessage = "User already in chat";
      });
    }
  }

  goToHome(): void {
    this.router.navigateByUrl('/home');
  }

  addNewChat(): void {
    if (this.newChatName) {
      var chat = new Chat();
      chat.name = this.newChatName;
      this.chatService.addNewChat(chat).subscribe()
      this.newChatName = '';
    }
  }

  deleteChat(id: string){
    this.chatService.deleteChat(id)
  }

  exportChat(id: string){

  }
}
