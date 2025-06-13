import { Routes } from '@angular/router';
import { ListIngredientComponent } from '../components/list-ingredient/list-ingredient.component';
import { HomeComponent } from '../components/home/home.component';
import { NavComponent } from '../components/nav/nav.component';
import { LoginComponent } from '../components/login/login.component';
import { RegisterComponent } from '../components/register/register.component';
import { RecipeComponent } from '../components/recipe/recipe.component';
import { AddRecipeComponent } from '../components/add-recipe/add-recipe.component';

export const routes: Routes = [
    {path:'listIngredien',component:ListIngredientComponent},
    {path:'',component:LoginComponent},
    {path:'register',component:RegisterComponent},
    {path:'add-recipe',component:AddRecipeComponent},
    {path:'home',component:HomeComponent},
    {path:'recipe-details/:id',component:RecipeComponent},
];
