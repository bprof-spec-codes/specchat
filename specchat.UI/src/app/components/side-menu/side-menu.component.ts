import { Component, EventEmitter, Inject, Input, OnInit, Output } from '@angular/core';
import { ChatService } from '../../services/chat.service';
import { Chat } from '../../_models/chat';
import { AuthService } from 'src/app/services/auth.service';
import { User } from 'src/app/_models/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent{
  chats?: Chat[];
  user: User;
  router: Router

  selectedThreadId = "";
  @Output() selectedThread = new EventEmitter<Chat>();
  @Input() set thisUser(user: User) 
  { 
    this.user = user
    if(this.user != null){
      this.chatService.getChatsByUserId(this.user.id).subscribe((result: Chat[]) => {
        this.chats = result;
      });
    }
  }  
  @Input() isOpen!: boolean;

  constructor(private chatService: ChatService, private authService: AuthService, router: Router) {
    this.user = new User();
    this.router = router;
  }

  
  onThreadClick(chat: Chat) {
    this.selectedThreadId = chat.id;
    this.selectedThread.emit(chat);
  }

  openDashboard(){
    this.router.navigate(['/dashboard'])
  }

  logout(){
    this.router.navigate(['/logout'])
  }
}