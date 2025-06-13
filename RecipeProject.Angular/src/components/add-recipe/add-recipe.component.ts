import { Component } from '@angular/core';
import { Recipe } from '../../interfaces/recipe.interface';
import { RecipesService } from '../../services/recipes.service';
import { FormsModule } from '@angular/forms';
import { IngredienForRecipeService } from '../../services/ingredien-for-recipe.service';
import { Ingredient } from '../../interfaces/ingredien.interface';
import { IngredientService } from '../../services/ingredient.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-recipe',
  imports: [FormsModule,CommonModule],
  templateUrl: './add-recipe.component.html',
  styleUrl: './add-recipe.component.css'
})
export class AddRecipeComponent {
  constructor(private recipeService: RecipesService, private ingredienService: IngredientService,
    private ingredientRService: IngredienForRecipeService) { }

  arr_ingredient: Array<Ingredient> = [];
  new_recipe: Recipe = {
    id: 0,
    name: "",
    descripsion: "",
    pic: "",
    level: "",
    duration: "",
    amount: 0,
    instructions: "",
    userId: 0
  }
new_ingredient:string="";
  selectIngridients: number[] = [];

  dictionery:{[key:number]:string}={}

  onCheckboxChange(ingredient:Ingredient) {
   
debugger
if(this.dictionery[ingredient.id]!=undefined)
  delete this.dictionery[ingredient.id]
else
  this.dictionery[ingredient.id]=ingredient.name

  }


  addRecipe() {
    this.recipeService.recipes_arr.length;
    alert("im on the way to add");
    console.log(this.new_recipe);
    alert(this.new_recipe.name);
    this.new_recipe.id = this.recipeService.recipes_arr.length + 1;
    this.recipeService.addRecipe(this.new_recipe).subscribe((data) => {
      this.new_recipe = data;
      console.log("i did itt")
      this.ingredientRService.addIngredientsToRecipe(data.id,this.dictionery).subscribe(()=>
      {
        
        console.log("sucsses")
      },err=>{

      })
    },
  err=>{
    
    console.log(err)
  })
   

  }



  ngOnInit() {
    
    this.ingredienService.get().subscribe((data) => {
      this.arr_ingredient = data;

    })
  }

logDictionery() {
  console.log(this.dictionery);
}

addIngredient(){
  alert("ADDING INGREDIENT")
  alert(this.new_ingredient)
  this.ingredienService.addIngredient(this.new_ingredient).subscribe(()=>{
    console.log("added ingredirnt")
  })
}
}