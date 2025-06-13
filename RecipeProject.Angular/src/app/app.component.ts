import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { ListIngredientComponent } from '../components/list-ingredient/list-ingredient.component';
import { NavComponent } from '../components/nav/nav.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,RouterOutlet,NavComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'RecipeProject.Angular';
}
