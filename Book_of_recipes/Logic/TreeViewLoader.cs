using Book_of_recipes.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_of_recipes.Logic
{
    internal class TreeViewLoader
    {
        public static void LoadRecipesTypes(DbRecipesContext context, TreeView treeView)
        {

            List<TreeNode> NodeList = new List<TreeNode>();

            var CategoryList = context.Categories.ToList();

            for (int i = 0; i < CategoryList.Count; i++)
            {
                TreeNode tmpNode = new TreeNode(CategoryList[i].Name);
                foreach (string RecipeName in
                      context.Recipes
                      .Where(r => r.CategoryId == CategoryList[i].CategoryId)
                      .Select(r => r.Title)
                      .ToList())
                {
                    tmpNode.Nodes.Add(new TreeNode(RecipeName));
                }
                NodeList.Add(tmpNode);
            }
            treeView.Nodes.AddRange(NodeList.ToArray());
        }
    }
}
