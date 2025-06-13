import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { UserService } from '../../services/user.service';
import { User } from '../../interfaces/user.interface';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  constructor(private userService:UserService,private router:Router){
    
  }
new_user:User={
  id:0,
  fname:"",
  lname:"",
  email:"",
  password:""
  };


  checkUser(){
    






    
    this.userService.getById(this.email,this.password).subscribe((data)=>{
    this.userService.user=data;
    this.new_user=data;  
   
    //שמירת המשתמש שהתחבר בCURRENT
    this.userService.setUser(this.new_user);

debugger
    if(this.new_user!=null)
      this.router.navigate(['/home'])
    else{
      this.router.navigate(['/register'])
    }
    }
  )};


  email:string="";
  password:string=""

 
}
