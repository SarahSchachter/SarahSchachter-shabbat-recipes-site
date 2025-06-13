import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Ingredient } from '../interfaces/ingredien.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IngredienForRecipeService {

  constructor(private httpc:HttpClient) { }

  url:string="https://localhost:7261/api/IngredientRecipe"


  ingredient_arr:Array<Ingredient>=[];

  getById(id_recipe:number):Observable<Ingredient[]>{
    debugger
    return this.httpc.get<Ingredient[]>(`${this.url}/${id_recipe}`)
  }
 
addIngredientsToRecipe(id_recipe: number, ingredients: { [key: number]: string }): Observable<void> {
 
  return this.httpc.post<void>(`${this.url}?id=${id_recipe}`, ingredients);
}
  //זה פונקציה של הוספת רכיב למתכון , יש אפשרות לשנות שיקבל הכל מהבודי
  //מה שיש לי עכשיו לעשות זה לראות איך אני מזמנת את זה מהקונטרולר  
}
