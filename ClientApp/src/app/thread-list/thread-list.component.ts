import { Component, Input, OnInit } from '@angular/core';
import { MessageService } from '../services/message.service';
import { Message } from '../models/message';

@Component({
  selector: 'app-thread-list',
  templateUrl: './thread-list.component.html',
  styleUrls: ['./thread-list.component.css']
})
export class ThreadListComponent implements OnInit {
  msgs?: Message[];
  
  constructor(private chatService: MessageService) {}

  ngOnInit(): void {
    this.chatService.getChat().subscribe((result: Message[]) => {
      this.msgs = result;
      console.log(result);
    });
  }
}
