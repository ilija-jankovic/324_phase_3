using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _324_phase_3
{
    public partial class Form1 : Form
    {
        public static Form1 Reference;

        bool tacoOptionsShowing = false; 
        bool curryOptionsShowing = false; 
        bool sausageOptionsShowing = false;
        bool newRecipeOptionsShowing = false;

        ArrayList recipeList = new ArrayList();
        ArrayList recipeListIngredients = new ArrayList();
        ArrayList recipeListMethod = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Reference = this;
            //Detach browse panel from recipe panel
            panelBrowse.Parent = this;
            //Binds ENTER to search button
            this.AcceptButton = buttonSearch;
            labelRemoveThaiGreenCurry.Hide();
            labelShareThaiGreenCurry.Hide();
            labelRemoveCrazyTacos.Hide();
            labelShareCrazyTacos.Hide();
            labelDeleteStuffedSausages.Hide();
            labelEditStuffedSausages.Hide();
            labelShareStuffedSausages.Hide();

            pictureBoxEllipsisNewRecipe.Hide();
            labelEditNewRecipe.Hide();
            labelDeleteNewRecipe.Hide();
            labelShareNewRecipe.Hide();

            recipeList.Add(panelThaiGreenCurry);
            recipeList.Add(panelCrazyTacos);
            recipeList.Add(panelStuffedSausages);
            recipeList.Add(panelNewRecipe);

            recipeListIngredients.Add("2 (8 ounce) cans bamboo shoots, drained and thinly sliced\n" +
                        "3 tablespoons corn oil\n" +
                        "3 tablespoons green curry paste, or more to taste\n" +
                        "1 pound lean boneless pork, cut into 1 / 2 - inch cubes\n" +
                        "2(14 ounce) cans coconut milk\n" +
                        "1 small red bell pepper, thinly sliced\n" +
                        "1 tablespoon white sugar\n" +
                        "½ teaspoon salt\n" +
                        "8 kaffir lime leaves, thinly sliced\n" +
                        "2 teaspoons fish sauce, or more to taste\n" +
                        "½ cup Thai basil");
            recipeListIngredients.Add("1 pound lean(at least 80 %) ground beef\n" +
                        "1 cup Old El Paso™ Thick 'n Chunky salsa\n" +
                        "10 Old El Paso™ taco shells\n" +
                        "1 / 2 head lettuce, shredded\n" +
                        "1 medium tomato, chopped (3 / 4 cup)\n" +
                        "1 cup shredded Cheddar cheese(4 ounces)");
            recipeListIngredients.Add("6 sausage thick\n" +
                        "2 potato chopped\n" +
                        "6 bacon rashers\n" +
                        "1 / 4 cup cheese grated");

            recipeListMethod.Add("Step 1 Bring a large pot of water to a boil and cook bamboo shoots for 5 minutes.Drain.\n" +
                        "Step 2 Heat oil in a large pot over medium heat and cook curry paste until fragrant, about 2 minutes." +
                        "Add pork, increase heat and cook until starting to brown, 3 to 5 minutes.Add bamboo shoots, coconut milk, " +
                        "and red bell pepper.Reduce heat and bring to a simmer.Season with sugar and salt; simmer for 10 minutes." +
                        "Stir in kaffir lime leaves.Cook for 1 more minute.Season with fish sauce.Stir in Thai basil and serve.");
            recipeListMethod.Add("1 Cook beef in 10 - inch skillet over medium heat 8 to 10 minutes, stirring occasionally, until brown; drain.\n" +
                        "2 Stir salsa into beef. Heat to boiling, stirring constantly; reduce heat to medium-low.Cook 5 minutes, stirring occasionally. Pour beef mixture into large serving bowl.\n" +
                        "3 Heat taco shells as directed on package. Serve taco shells with beef mixture, lettuce, tomato and cheese.");
            recipeListMethod.Add("1 Place sausages in saucepan and boil until cooked.\n" +
                        "2 Boil potatoes until soft.\n" +
                        "3  Mash potatoes, adding some grated cheese.\n" +
                        "4 Cut 2 slits in each sausage widthways towards the end, and then one down the centre.\n" +
                        "5 Push centre slit open with fingers and fill with mash potato.\n" +
                        "6 Wrap a bacon rasher around each sausage and secure the ends with a toothpick.\n7" +
                        "7 Place sausages onto a baking tray and sprinkle with grated cheese.\n" +
                        "8 Bake at 180C for approximately 20 minutes or until bacon crisps and cheese browns.");


            refreshRecipeList();

        }

        private void OpenForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBoxAddRecipe_Click(object sender, EventArgs e)
        {
            OpenForm(new AddRecipe());
        }


        public void addNewRecipie(string title, Image image, string ingredients, string method)
        {
            pictureBoxNewRecipie.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxNewRecipie.Image = image;
            pictureBoxNewRecipie.SizeMode = PictureBoxSizeMode.CenterImage;
            labelNewRecipe.BorderStyle = BorderStyle.FixedSingle;
            labelNewRecipe.Text = title;

            panelNewRecipe.Show();

            pictureBoxEllipsisNewRecipe.Show();

            recipeListIngredients.Add(ingredients);
            recipeListMethod.Add(method);
            MessageBox.Show(title = " recipe successfully added");
            //MessageBox.Show(ingredients + "\n" + method);
        }


        public void editRecipie(Panel recipeCard, string editedTitle, Image editedImage, string editedIngredients, string editedMethod)
        {
            if (recipeList.Contains(recipeCard) && recipeCard.Equals(panelThaiGreenCurry))
            {
                pictureBoxThaiGreenCurry.Image = editedImage;
                labelThaiGreenCurry.Text = editedTitle;
                recipeListIngredients[recipeList.IndexOf(panelThaiGreenCurry)] = editedIngredients;
                recipeListMethod[recipeList.IndexOf(panelThaiGreenCurry)] = editedMethod;
            }
            else if (recipeList.Contains(recipeCard) && recipeCard.Equals(panelCrazyTacos))
            {
                pictureBoxCrazyTacos.Image = editedImage;
                labelCrazyTacos.Text = editedTitle;
                recipeListIngredients[recipeList.IndexOf(panelCrazyTacos)] = editedIngredients;
                recipeListMethod[recipeList.IndexOf(panelCrazyTacos)] = editedMethod;
            }
            else if (recipeList.Contains(recipeCard) && recipeCard.Equals(panelStuffedSausages))
            {
                pictureBox1.Image = editedImage;
                labelStuffedSausages.Text = editedTitle;
                recipeListIngredients[recipeList.IndexOf(panelStuffedSausages)] = editedIngredients;
                recipeListMethod[recipeList.IndexOf(panelStuffedSausages)] = editedMethod;
            }
            else if (recipeList.Contains(recipeCard) && recipeCard.Equals(panelNewRecipe))
            {
                pictureBoxNewRecipie.Image = editedImage;
                labelNewRecipe.Text = editedTitle;
                recipeListIngredients[recipeList.IndexOf(panelNewRecipe)] = editedIngredients;
                recipeListMethod[recipeList.IndexOf(panelNewRecipe)] = editedMethod;
            }
            MessageBox.Show(editedTitle + " recipe successfully edited");
        }


        private void pictureBoxThaiGreenCurry_Click(object sender, EventArgs e)
        {
            OpenForm(new DisplayRecipe("Thai Green Curry"));
        }

        private void pictureBoxCrazyTacos_Click(object sender, EventArgs e)
        {
            OpenForm(new DisplayRecipe("Crazy Tacos"));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new DisplayRecipe("Stuffed Sausages"));
        }

        private void pictureBoxEllipsisThaiGreenCurry_Click(object sender, EventArgs e)
        {
            if (curryOptionsShowing)
            {
                labelRemoveThaiGreenCurry.Hide();
                labelShareThaiGreenCurry.Hide();
                curryOptionsShowing = false;
            }
            else
            {
                labelRemoveThaiGreenCurry.Show();
                labelShareThaiGreenCurry.Show();
                curryOptionsShowing = true;
            }
        }

        private void pictureEllipsisCrazyTacos_Click(object sender, EventArgs e)
        {
            if (tacoOptionsShowing)
            {
                labelRemoveCrazyTacos.Hide();
                labelShareCrazyTacos.Hide();
                tacoOptionsShowing = false;
            }
            else
            {
                labelRemoveCrazyTacos.Show();
                labelShareCrazyTacos.Show();
                tacoOptionsShowing = true;
            }
        }

        private void labelShareThaiGreenCurry_Click(object sender, EventArgs e)
        {
            OpenForm(new Share());
        }

        private void labelShareCrazyTacos_Click(object sender, EventArgs e)
        {
            OpenForm(new Share());
        }

        private void labelShareStuffedSausages_Click(object sender, EventArgs e)
        {
            OpenForm(new Share());
        }

        private void pictureBoxEllipsisStuffedSausages_Click(object sender, EventArgs e)
        {
            if (sausageOptionsShowing)
            {
                labelDeleteStuffedSausages.Hide();
                labelEditStuffedSausages.Hide();
                labelShareStuffedSausages.Hide();
                sausageOptionsShowing = false;
            }
            else
            {
                labelDeleteStuffedSausages.Show();
                labelEditStuffedSausages.Show();
                labelShareStuffedSausages.Show();
                sausageOptionsShowing = true;
            }
        }

        private void buttonRecipeBook_Click(object sender, EventArgs e)
        {
            panelBrowse.Visible = false;
            panelRecipes.Visible = true;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            panelBrowse.Visible = true;
            panelRecipes.Visible = false;
        }

        private void ShowSearchResult(string title, Image image)
        {
            labelRecipeTitle.Visible = true;
            labelRecipeTitle.Text = title;

            pictureBoxRecipe.Visible = true;
            pictureBoxRecipe.Image = image;
        }

        private bool CompareAgainstSearch(string[] tokens, string[] matchingTokens)
        {
            foreach (string token in tokens)
                foreach (string matchingToken in matchingTokens)
                    if (token == matchingToken)
                        return true;
            return false;
        }

        //Compares each word separated by a space against a non-case-sensitive string set
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string[] tokens = textBoxSearch.Text.ToLower().Split(' ');

            if (CompareAgainstSearch(tokens, new string[] { "thai", "green", "curry" }))
                ShowSearchResult("Thai Green Curry", Image.FromFile("..\\..\\Resources\\thaiGreenCurry.jpg"));
            else if (CompareAgainstSearch(tokens, new string[] { "crazy", "tacos" }))
                ShowSearchResult("Crazy Tacos", Image.FromFile("..\\..\\Resources\\crazyTacos.jpg"));
            else if (CompareAgainstSearch(tokens, new string[] { "stuffed", "sausages" }))
                ShowSearchResult("Stuffed Sausages", Image.FromFile("..\\..\\Resources\\stuffedSausages.jpg"));
            else
                ShowSearchResult("Could not find " + textBoxSearch.Text, null);
        }

        private void pictureBoxRecipe_Click(object sender, EventArgs e)
        {
            OpenForm(new DisplayRecipe(labelRecipeTitle.Text));
        }

        private void labelRemoveThaiGreenCurry_Click(object sender, EventArgs e)
        {
            removeRecipe(labelThaiGreenCurry.Text, panelThaiGreenCurry);
        }

        private void labelDeleteStuffedSausages_Click(object sender, EventArgs e)
        {
            removeRecipe(labelStuffedSausages.Text, panelStuffedSausages);
        }

        private void labelRemoveCrazyTacos_Click(object sender, EventArgs e)
        {
            removeRecipe(labelCrazyTacos.Text, panelCrazyTacos);
        }

        public void removeRecipe(string recipeName, Panel recipeCard)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + recipeName + "\" Recipe?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                panelRecipes.VerticalScroll.Value = 0;
                //string recipeCardsInList = "\nrecipes: \n";
                //foreach (Panel p in recipeList)
                //{
                //    recipeCardsInList += " - " + p.Name + "\n";
                //}
                //Console.WriteLine("recipeCard: " + recipeCard.Name + " " + recipeList.IndexOf(recipeCard) + " " + recipeCardsInList);
                recipeListIngredients.RemoveAt(recipeList.IndexOf(recipeCard));
                recipeListMethod.RemoveAt(recipeList.IndexOf(recipeCard));
                if (!recipeCard.Equals(panelNewRecipe))
                {
                    recipeCard.Hide();
                    recipeList.RemoveAt(recipeList.IndexOf(recipeCard));
                }
                refreshRecipeList();
                if (recipeCard.Equals(panelNewRecipe))
                {
                    panelNewRecipe.Hide();
                }
            }
        }

        private void refreshRecipeList()
        {
            int previousPanelLocationY = 12 - 317;
            Console.WriteLine("count is " + recipeList.Count + " refresh:\n");
            foreach (Panel p in recipeList)
            {
                Console.WriteLine(recipeList.IndexOf(p) + "  " + p.Name + " at " + (previousPanelLocationY+317) + "\n");
                p.Location = new Point(12, previousPanelLocationY + 317);
                previousPanelLocationY = p.Location.Y;
            }
        }

        private void labelEditStuffedSausages_Click(object sender, EventArgs e)
        {
            OpenForm(new AddRecipe(panelStuffedSausages, pictureBox1, labelStuffedSausages, recipeListIngredients[recipeList.IndexOf(panelStuffedSausages)].ToString(), recipeListMethod[recipeList.IndexOf(panelStuffedSausages)].ToString()));
        }

        private void labelEditNewRecipe_Click(object sender, EventArgs e)
        {
            OpenForm(new AddRecipe(panelNewRecipe, pictureBoxNewRecipie, labelNewRecipe, recipeListIngredients[recipeList.IndexOf(panelNewRecipe)].ToString(), recipeListMethod[recipeList.IndexOf(panelNewRecipe)].ToString()));

        }

        private void pictureBoxEllipsisNewRecipe_Click(object sender, EventArgs e)
        {
            if (newRecipeOptionsShowing)
            {
                labelEditNewRecipe.Hide();
                labelDeleteNewRecipe.Hide();
                labelShareNewRecipe.Hide();
                newRecipeOptionsShowing = false;
            }
            else
            {
                labelEditNewRecipe.Show();
                labelDeleteNewRecipe.Show();
                labelShareNewRecipe.Show();
                newRecipeOptionsShowing = true;
            }
        }

        private void labelDeleteNewRecipe_Click(object sender, EventArgs e)
        {
            removeRecipe(labelNewRecipe.Text, panelNewRecipe);
        }

        private void labelShareNewRecipe_Click(object sender, EventArgs e)
        {
            OpenForm(new Share());
        }
    }
}
