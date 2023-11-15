using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class Ingredient
{
    public int IngredientId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<IngredientsInRecipe> IngredientsInRecipes { get; set; } = new List<IngredientsInRecipe>();
}
