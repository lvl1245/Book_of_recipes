using System;
using System.Collections.Generic;
using System.Configuration;
using Book_of_recipes.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_of_recipes.Context;

public partial class DbRecipesContext : DbContext
{
    public DbRecipesContext()
    {
    }

    public DbRecipesContext(DbContextOptions<DbRecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CommentText> CommentTexts { get; set; }

    public virtual DbSet<DateAdded> DateAddeds { get; set; }

    public virtual DbSet<Book_of_recipes.Models.Image> Images { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<IngredientsInRecipe> IngredientsInRecipes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeDescription> RecipeDescriptions { get; set; }

    public virtual DbSet<RecipeInstruction> RecipeInstructions { get; set; }

    public virtual DbSet<RecipesTag> RecipesTags { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserComment> UserComments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // => optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings.Get("ConnectionString"));
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-R8KJVR7\\SQLEXPRESS;Initial Catalog=DB_Recipes;Integrated Security=True;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__D54EE9B4D754C8EB");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CommentText>(entity =>
        {
            entity.HasKey(e => e.CommentTextId).HasName("PK__CommentT__FC8CB53257DF0946");

            entity.ToTable("CommentText");

            entity.Property(e => e.CommentText1)
                .HasMaxLength(500)
                .HasColumnName("CommentText");

            entity.HasOne(d => d.UserComments).WithMany(p => p.CommentTexts)
                .HasForeignKey(d => d.UserCommentsId)
                .HasConstraintName("FK__CommentTe__UserC__75A278F5");
        });

        modelBuilder.Entity<DateAdded>(entity =>
        {
            entity.HasKey(e => e.DateAddedId).HasName("PK__DateAdde__D7CCFBFF51D7ABFC");

            entity.ToTable("DateAdded");

            entity.Property(e => e.AddedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Recipe).WithMany(p => p.DateAddeds)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__DateAdded__Recip__6383C8BA");

            entity.HasOne(d => d.User).WithMany(p => p.DateAddeds)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__DateAdded__UserI__628FA481");
        });

        modelBuilder.Entity<Book_of_recipes.Models.Image>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__Image__DC9AC955942BC04D");

            entity.ToTable("Image");

            entity.Property(e => e.ImageId).HasColumnName("image_id");
            entity.Property(e => e.ImageData).HasColumnName("image_data");
            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Images)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__Image__recipe_id__5BE2A6F2");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.IngredientId).HasName("PK__Ingredie__B0E453CF52BB7ADB");

            entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<IngredientsInRecipe>(entity =>
        {
            entity.HasKey(e => e.IngredientsInRecipesId).HasName("PK__Ingredie__5D3AC6AE4100CFC8");

            entity.Property(e => e.IngredientsInRecipesId).HasColumnName("IngredientsInRecipes_Id");

            entity.HasOne(d => d.Ingredients).WithMany(p => p.IngredientsInRecipes)
                .HasForeignKey(d => d.IngredientsId)
                .HasConstraintName("FK__Ingredien__Ingre__59063A47");

            entity.HasOne(d => d.Recipe).WithMany(p => p.IngredientsInRecipes)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__Ingredien__Recip__5812160E");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.RecipeId).HasName("PK__Recipes__3571ED9BC13C8970");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("RecipeInsertCouner");
                    tb.HasTrigger("RecipesActionsTrigger");
                    tb.HasTrigger("RecipesInsertTrigger");
                });

            entity.Property(e => e.RecipeId).HasColumnName("recipe_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CookTime).HasColumnName("cook_time");
            entity.Property(e => e.PrepTime).HasColumnName("prep_time");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Recipes__categor__534D60F1");
        });

        modelBuilder.Entity<RecipeDescription>(entity =>
        {
            entity.HasKey(e => e.RecipeDescriptionId).HasName("PK__RecipeDe__CF7B1507BA55B997");

            entity.ToTable("RecipeDescription");

            entity.Property(e => e.Description).HasMaxLength(500);

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeDescriptions)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__RecipeDes__Recip__18EBB532");
        });

        modelBuilder.Entity<RecipeInstruction>(entity =>
        {
            entity.HasKey(e => e.RecipeInstructionsId).HasName("PK__RecipeIn__67494603E265A3E6");

            entity.Property(e => e.Instruction).HasMaxLength(500);

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeInstructions)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__RecipeIns__Recip__1BC821DD");
        });

        modelBuilder.Entity<RecipesTag>(entity =>
        {
            entity.HasKey(e => e.RecipesTagsid).HasName("PK__RecipesT__91602DA316C87EEC");

            entity.ToTable("RecipesTAGS");

            entity.Property(e => e.RecipesTagsid).HasColumnName("RecipesTAGSId");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipesTags)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK__RecipesTA__Recip__6C190EBB");

            entity.HasOne(d => d.Tag).WithMany(p => p.RecipesTags)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK__RecipesTA__TagId__6D0D32F4");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__TAGS__657CF9AC1FCFF210");

            entity.ToTable("TAGS");

            entity.Property(e => e.TagName).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C307CD179");

            entity.Property(e => e.UserLogin).HasMaxLength(8000);
            entity.Property(e => e.UserName).HasMaxLength(20);
            entity.Property(e => e.UserPassword).HasMaxLength(8000);
        });

        modelBuilder.Entity<UserComment>(entity =>
        {
            entity.HasKey(e => e.UserCommentsId).HasName("PK__UserComm__DE563CCD084D26AD");

            entity.Property(e => e.CommentHeader).HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.UserComments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserComme__UserI__72C60C4A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
