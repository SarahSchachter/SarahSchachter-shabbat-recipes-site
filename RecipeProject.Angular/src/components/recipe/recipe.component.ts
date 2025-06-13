import { Component } from '@angular/core';
import { RecipesService } from '../../services/recipes.service';
import { Recipe } from '../../interfaces/recipe.interface';
import { ActivatedRoute, Router } from '@angular/router';
import { __param } from 'tslib';
import { IngredienForRecipeService } from '../../services/ingredien-for-recipe.service';
import { Ingredient } from '../../interfaces/ingredien.interface';
import { RemoveSpaceBeforeCommaPipe } from '../../app/remove-space-before-comma.pipe';

@Component({
  selector: 'app-recipe',
  imports: [RemoveSpaceBeforeCommaPipe],
  templateUrl: './recipe.component.html',
  styleUrl: './recipe.component.css'
})
export class RecipeComponent {


constructor(
  private route: ActivatedRoute,
  private recipeService:RecipesService,
  private ingredientsService:IngredienForRecipeService
) {}
id:number=0
 new_recipe: Recipe = {
    id: 0,
    name: "",
    descripsion: "",
    pic: " ",
    level: " ",
    duration: "",
    amount: 0,
    instructions: "",
    userId: 0
  }

all_ingredient:Array<Ingredient>=[];
ngOnInit() {
  const a = this.route.snapshot.paramMap.get('id');
  if (a !== null) {
    this.id = +a;

    this.recipeService.getDetailsById(this.id).subscribe((data) => {
      this.recipeService.recipe_details = data;
      this.new_recipe = data;

      // טעינת הרכיבים
      this.loadIngredients(this.id);
    });
  }
}

loadIngredients(id: number) {
  this.ingredientsService.getById(id).subscribe((data) => {
    this.ingredientsService.ingredient_arr = data;
    this.all_ingredient = data;
  });
}
 getImages(img:string):string{
      return `https://localhost:7261/Images/${img}`
    }
}




