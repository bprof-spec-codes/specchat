import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { RegisterModel } from '../../_models/viewmodels/registermodel';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  router: Router
  registerModel: RegisterModel = new RegisterModel();
  RegisterForm!: FormGroup;
  hide = true;
  registrationFalied: boolean = false;
  selectedRole: string = 'User';


  constructor(private authService: AuthService, 
    private fb: FormBuilder, router:Router) {
    this.router = router
  }

  ngOnInit(): void {
    this.RegisterForm = this.fb.group({
      email: ['', Validators.required],
      username: ['', Validators.required],
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  register() {
    this.registerModel.email = this.RegisterForm.value.email;
    this.registerModel.firstname = this.RegisterForm.value.firstname;
    this.registerModel.lastname = this.RegisterForm.value.lastname;
    this.registerModel.username = this.RegisterForm.value.username;
    this.registerModel.PictureData = "";
    this.registerModel.PictureContentType = "";
    this.registerModel.password = this.RegisterForm.value.password;
    this.registerModel.role = this.selectedRole;
  
    this.authService.register(this.registerModel)
      .subscribe({
        next: (data) => {
          this.router.navigate(['/login']);
        },
        error: (e) => {
          this.registrationFalied = true;
        }
      });
  }

  selectRole(role: string) {
    this.selectedRole = role;
  }  

  openLogin() {
    this.router.navigate(['/login']);
  }
}
