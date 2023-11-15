using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class CommentText
{
    public int CommentTextId { get; set; }

    public string CommentText1 { get; set; } = null!;

    public int? UserCommentsId { get; set; }

    public virtual UserComment? UserComments { get; set; }
}
