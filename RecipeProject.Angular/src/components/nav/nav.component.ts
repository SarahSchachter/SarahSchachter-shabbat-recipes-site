import { Component } from '@angular/core';
import { RouterLink, RouterModule } from '@angular/router';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-nav',
  imports: [RouterLink,RouterModule],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {

constructor(private userService:UserService){}

 get is_connected(): boolean {
    return this.userService.current_user.id !== 0;
  }
}
