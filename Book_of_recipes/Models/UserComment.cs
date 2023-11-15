using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class UserComment
{
    public int UserCommentsId { get; set; }

    public int? UserId { get; set; }

    public string CommentHeader { get; set; } = null!;

    public virtual ICollection<CommentText> CommentTexts { get; set; } = new List<CommentText>();

    public virtual User? User { get; set; }
}
