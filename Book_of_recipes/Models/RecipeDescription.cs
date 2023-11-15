using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class RecipeDescription
{
    public int RecipeDescriptionId { get; set; }

    public string Description { get; set; } = null!;

    public int? RecipeId { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
