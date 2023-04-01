import { Component } from '@angular/core';

@Component({
  selector: 'content-nav',
  templateUrl: './content-nav.component.html',
  styleUrls: ['./content-nav.component.css']
})
export class ContentNavComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}

