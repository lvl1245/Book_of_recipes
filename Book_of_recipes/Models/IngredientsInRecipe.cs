using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class IngredientsInRecipe
{
    public int IngredientsInRecipesId { get; set; }

    public int? RecipeId { get; set; }

    public int? IngredientsId { get; set; }

    public virtual Ingredient? Ingredients { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
