using System;
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
        public Form1()
        {
            InitializeComponent();
            Reference = this;
            //Detach browse panel from recipe panel
            panelBrowse.Parent = this;
            //Binds ENTER to search button
            this.AcceptButton = buttonSearch;
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

        //@todo - add labels to the icons


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
    }
}
