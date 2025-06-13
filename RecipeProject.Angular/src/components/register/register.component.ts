import { Component } from '@angular/core';
import { User } from '../../interfaces/user.interface';
import { FormsModule } from '@angular/forms';
import { UserService } from '../../services/user.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register',
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  constructor(private userServic:UserService,private router:Router ){}
 new_user:User={
  id:0,
  fname:"",
  lname:"",
  email:"",
  password:""
  };


  addUser(){
    alert("im adding")

    this.userServic.addUser(this.new_user).subscribe(()=>{
      // //why did the alert didnt work?
      console.log('נכנסנו ל-subscribe!');
    })

      this.router.navigate(['/home'])

  }
  check(){
    if( this.new_user.fname!=""&&
      this.new_user.lname!=""&&this.new_user.email!=""&&this.new_user.password!=""){
        this.addUser();
        
      }
      else{
        alert("נא למלא את כל השדות")
      }
  }
}
