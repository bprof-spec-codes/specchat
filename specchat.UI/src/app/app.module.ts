import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { EditorModule, TINYMCE_SCRIPT_SRC } from '@tinymce/tinymce-angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ThreadListComponent } from './components/thread-list/thread-list.component';
import { ChatListComponent } from './components/chat-list/chat-list.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './components/home/home.component';
import { AuthInterceptor } from './services/auth.interceptor';
import { LoginComponent } from './components/login/login.component';
import { LogoutComponent } from './components/logout/logout.component';
import { RegisterComponent } from './components/register/register.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { QRCodeModule } from 'angularx-qrcode';

@NgModule({
  declarations: [
    AppComponent,
    ThreadListComponent,
    ChatListComponent,
    NavMenuComponent,
    SideMenuComponent,
    HomeComponent,
    LoginComponent,
    LogoutComponent,
    RegisterComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    AppRoutingModule,
    EditorModule,
    QRCodeModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true,
    },
    { 
      provide: TINYMCE_SCRIPT_SRC, 
      useValue: 'tinymce/tinymce.min.js' 
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
