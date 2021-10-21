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

        ArrayList recipeList = new ArrayList();

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

            recipeList.Add(panelThaiGreenCurry);
            recipeList.Add(panelCrazyTacos);
            recipeList.Add(panelStuffedSausages);
            recipeList.Add(panelNewRecipe);
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
            MessageBox.Show(title = " recipe successfully added");
            //MessageBox.Show(ingredients + "\n" + method);
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
                recipeList.RemoveAt(recipeList.IndexOf(recipeCard));
                refreshRecipeList();
            }
        }

        private void refreshRecipeList()
        {
            int previousPanelLocationY = 12 - 317;
            foreach (Panel p in recipeList)
            {
                p.Location = new Point(12, previousPanelLocationY + 317);
                previousPanelLocationY = p.Location.Y;
            }
        }

    }
}
