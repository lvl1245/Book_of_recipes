﻿using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class RecipesTag
{
    public int RecipesTagsid { get; set; }

    public int? RecipeId { get; set; }

    public int? TagId { get; set; }

    public virtual Recipe? Recipe { get; set; }

    public virtual Tag? Tag { get; set; }
}
