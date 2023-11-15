using System;
using System.Collections.Generic;

namespace Book_of_recipes.Models;

public partial class User
{
    public int UserId { get; set; }

    public byte[]? UserPassword { get; set; }

    public byte[]? UserLogin { get; set; }

    public int? UserPremission { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<DateAdded> DateAddeds { get; set; } = new List<DateAdded>();

    public virtual ICollection<UserComment> UserComments { get; set; } = new List<UserComment>();
}
