using Book_of_recipes.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_of_recipes.Logic
{
    class ItemSelectionHandler
    {
        public static void HandlEvent(TreeViewEventArgs e,
                                      Label RecipeNameLable,
                                      Label CookTimeValueLabel,
                                      Label PrepTimeValueLabel,
                                      TextBox Description,
                                      DbRecipesContext context)
        {
            if (e == null) { return; }

            var tmpRecipe = context.Recipes.FirstOrDefault(x => x.Title == e.Node.Text);
            if (tmpRecipe == null) { return; }
            string tmpRecipeDescription = context.RecipeDescriptions
                .Where(x => x.RecipeId == tmpRecipe.RecipeId)
                .Select(x => x.Description)
                .FirstOrDefault();

           



            RecipeNameLable.Text = tmpRecipe.Title ?? "error";
            CookTimeValueLabel.Text = tmpRecipe.CookTime.ToString() ?? "error";
            PrepTimeValueLabel.Text = tmpRecipe.PrepTime.ToString() ?? "error";
            Description.Text = tmpRecipeDescription;

        }
    }
}
