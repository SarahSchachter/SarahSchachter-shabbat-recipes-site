import { Injectable } from '@angular/core';
import { Ingredient } from '../interfaces/ingredien.interface';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IngredientService {

  constructor(private httpc:HttpClient) { 

  }

  url:string="https://localhost:7261/api/Ingredient";

  ingredient_arr: Array<Ingredient>=[]

  get():Observable<Ingredient[]>
  {
    
    return this.httpc.get<Ingredient[]>(this.url)
  }

  addIngredient(ingredient:string):Observable<void>{
    debugger
    return this.httpc.post<void>(this.url + '?name=' + ingredient, null);

  }
}
