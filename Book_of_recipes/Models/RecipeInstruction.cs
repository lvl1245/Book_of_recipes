using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class RecipeInstruction
{
    public int RecipeInstructionsId { get; set; }

    public string Instruction { get; set; } = null!;

    public int? RecipeId { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
