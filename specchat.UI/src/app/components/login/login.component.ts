import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from '../../_models/viewmodels/loginmodel';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  router: Router
  loginForm!: FormGroup;
  loginModel: LoginModel;
  loginFailed = false;
  hide = true;
  
  constructor(
    private authService: AuthService, 
    private fb: FormBuilder,
    router: Router
  ){
    this.router = router
    this.loginModel = new LoginModel()
  }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  login() {
    this.loginModel.username = this.loginForm.value.username;
    this.loginModel.password = this.loginForm.value.password;

    this.authService.login(this.loginModel)
      .subscribe({
        next: (data) => {
          localStorage.setItem('specchat-token', data.token);
          localStorage.setItem('specchat-token-expiration', data.expiration.toString());
          this.router.navigate(['/home']);
        },
        error: (e) => {
          console.error(e);
          this.loginFailed = true;
        }
      });
  }

  openRegistration() {
    this.router.navigate(['/register'])
  }
}
