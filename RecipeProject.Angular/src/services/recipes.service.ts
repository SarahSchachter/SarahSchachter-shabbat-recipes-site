import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from '../interfaces/recipe.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  constructor(private httpc: HttpClient) { }

  url: string = "https://localhost:7261/api/Recipe";

  recipes_arr: Array<Recipe> = []
  recipe_details: Recipe = {
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

  get(): Observable<Recipe[]> {
    return this.httpc.get<Recipe[]>(this.url)
    
  }


  getDetailsById(id: number): Observable<Recipe> {
    return this.httpc.get<Recipe>(`${this.url}/${id}`)

  }

  addRecipe(recipe:Recipe):Observable<Recipe>{
    debugger
    return this.httpc.post<Recipe>(this.url,recipe)
  }


}
