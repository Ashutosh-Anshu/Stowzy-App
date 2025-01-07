import { Routes } from '@angular/router';
import { HomeComponent } from './_menus/Home/home/home.component';
import { LoginComponent } from './_menus/login-signup/login/login.component';
import { SignupComponent } from './_menus/login-signup/signup/signup.component';
import { OwnerComponent } from './_menus/login-signup/signup/action/owner/owner.component';
import { OwnerLoginComponent } from './_menus/login-signup/login/action/owner-login/owner-login.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'owner-login', component: OwnerLoginComponent },
  { path: 'owner-signup', component: OwnerComponent },
];
