using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class DateAdded
{
    public int DateAddedId { get; set; }

    public DateTime? AddedDate { get; set; }

    public TimeSpan? AddedTime { get; set; }

    public int? UserId { get; set; }

    public int? RecipeId { get; set; }

    public virtual Recipe? Recipe { get; set; }

    public virtual User? User { get; set; }
}
