import { Component } from '@angular/core';
import { IngredientService } from '../../services/ingredient.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-list-ingredient',
  imports: [],
  templateUrl: './list-ingredient.component.html',
  styleUrl: './list-ingredient.component.css'
})
export class ListIngredientComponent {
    constructor( private ingredientService:IngredientService){

    }
    ngOnInit(){
      this.ingredientService.get().subscribe((data)=>
        this.ingredientService.ingredient_arr=data);
    }

    getArr(){
      return this.ingredientService.ingredient_arr;
    }
}
