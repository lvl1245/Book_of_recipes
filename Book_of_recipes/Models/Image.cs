using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public int? RecipeId { get; set; }

    public byte[]? ImageData { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
