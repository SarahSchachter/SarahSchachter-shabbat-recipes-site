using System;
using System.Collections.Generic;

namespace WebApi.Entities;

public partial class Recipe
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Descripsion { get; set; }

    public string? Pic { get; set; }

    public string? Level { get; set; }

    public string? Duration { get; set; }

    public int? Amount { get; set; }

    public string? Instructions { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<IngredientRecipe> IngredientRecipes { get; set; } = new List<IngredientRecipe>();

    public virtual User? User { get; set; }
}
