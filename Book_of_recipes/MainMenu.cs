using Book_of_recipes.Context;
using Book_of_recipes.Logic;
using Book_of_recipes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using System.Xml;

namespace Book_of_recipes
{
    public partial class MainMenu : Form
    {
        private Bitmap MyImage;

        private static DbRecipesContext context = new DbRecipesContext();

        public MainMenu()
        {
            InitializeComponent(); 
            ShowMyImage("image4.png");
            menuStrip1.Items.Add("add category");
            menuStrip1.Items.Add("add recipe");
            TreeViewLoader.LoadRecipesTypes(context,treeView1); 
        }


       
        public void ShowMyImage(String fileToDisplay)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }


            

            MyImage = new Bitmap(fileToDisplay);
           // pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (System.Drawing.Image)MyImage;
        }

        private void Lable_RecipeName_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ItemSelectionHandler.HandlEvent(e,
                                            Label_RecipeName,
                                            PreparationTimeValue,
                                            CookTimeValue, 
                                            DescriptionTextBox, 
                                            context);

          
        }
    }
}