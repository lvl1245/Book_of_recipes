using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string TagName { get; set; } = null!;

    public virtual ICollection<RecipesTag> RecipesTags { get; set; } = new List<RecipesTag>();
}
