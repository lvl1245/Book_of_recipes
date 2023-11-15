using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string Title { get; set; } = null!;

    public int? PrepTime { get; set; }

    public int? CookTime { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<DateAdded> DateAddeds { get; set; } = new List<DateAdded>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<IngredientsInRecipe> IngredientsInRecipes { get; set; } = new List<IngredientsInRecipe>();

    public virtual ICollection<RecipeDescription> RecipeDescriptions { get; set; } = new List<RecipeDescription>();

    public virtual ICollection<RecipeInstruction> RecipeInstructions { get; set; } = new List<RecipeInstruction>();

    public virtual ICollection<RecipesTag> RecipesTags { get; set; } = new List<RecipesTag>();
}
