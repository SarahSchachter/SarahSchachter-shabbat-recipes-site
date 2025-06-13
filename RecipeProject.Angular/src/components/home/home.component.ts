import { Component } from '@angular/core';
import { RecipesService } from '../../services/recipes.service';
import { Recipe } from '../../interfaces/recipe.interface';
import { Router } from '@angular/router';


@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

    constructor(private recipeService:RecipesService,private router:Router){
  
    }
  
  //פונקציה שבעת טעינה שופכת לתוך המערך את מה שחוזר לה מהSERVIVCE
  ngOnInit(){
  this.recipeService.get().subscribe((data)=>  
  this.recipeService.recipes_arr=data);
  }
  
  
  
  //פונקציה השולפת מהSERVICE את מה שחזר
    getArr(){
      return this.recipeService.recipes_arr;
    }
  
    moreDetails(id:number){
      this.router.navigate(['/recipe-details',id])
    }


    getImages(img:string):string{
      return `https://localhost:7261/Images/${img}`
    }
  
}
