using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _324_phase_3
{
    public partial class AddRecipe : Form
    {
        bool initial = true;
        bool titleEntered = false;
        bool ingredientsEntered = false;
        bool methodEntered = false;
        Pen redPenTitle = new Pen(Color.Red, 10), redPenIngredients = new Pen(Color.Red, 10), redPenMethod = new Pen(Color.Red, 10);
        Graphics formGraphics;
        Rectangle titleBorder, instructionsBorder, methodBorder;
        Image emptyPlate;

        public AddRecipe()
        {
            InitializeComponent();
            formGraphics = this.CreateGraphics();
            emptyPlate = pictureBoxUpload.Image;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\ntbow\\source\\repos\\324_phase_3\\Resources";
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|MP4 Files|*.mp4|All Files|*.*";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxUpload.Image = image;
                    pictureBoxUpload.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            initial = false;
            if (!titleEntered ||
                !ingredientsEntered ||
                !methodEntered)
            {
                DialogResult result = MessageBox.Show("Recipe not added. \nPlease enter text in all fields.", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    drawErrors();
                }
                else if (result == DialogResult.Cancel)
                {
                    DialogResult cancelAddingRecpie = MessageBox.Show("Are you sure you want to cancel this recipe?", "", MessageBoxButtons.YesNo);
                    if (cancelAddingRecpie == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else if (cancelAddingRecpie == DialogResult.No)
                    {
                        drawErrors();
                    }
                }
            }
            else if (pictureBoxUpload.Image.Equals(emptyPlate))
            {
                DialogResult result = MessageBox.Show("Are you sure you dont want Picture(s)/Video(s).", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form1.Reference.addNewRecipie(textBoxTitle.Text.ToString(), pictureBoxUpload.Image, textBoxIngredients.Text.ToString(), textBoxMethod.Text.ToString());  //passes in the recipe information
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Form1.Reference.addNewRecipie(textBoxTitle.Text.ToString(), pictureBoxUpload.Image, textBoxIngredients.Text.ToString(), textBoxMethod.Text.ToString());  //passes in the recipe information
                this.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this recipe?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.ToString().Trim() == "") { titleEntered = false; } 
            else { titleEntered = true; }
            drawErrors();
        }

        private void textBoxIngredients_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIngredients.Text.ToString().Trim() == "") { ingredientsEntered = false; }
            else { ingredientsEntered = true; }
            drawErrors();
        }

        private void textBoxMethod_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMethod.Text.ToString().Trim() == "") { methodEntered = false; }
            else { methodEntered = true; }
            drawErrors();
        }

        //draw error boxes and messages depeinding on what fields currently have text in it...
        //dont draw errors if they havent tried adding the recipe yet 
        private void drawErrors()
        {
            if (!initial) 
            {
                //clear the canvas and text boxes
                formGraphics.Clear(Color.FromArgb(250, 250, 250));
                labelTitleError.Text = "";
                labelIngredientsError.Text = "";
                labelMethodError.Text = "";

                if (!titleEntered)
                {
                    labelTitleError.Text = "Please enter a title";
                    titleBorder = new Rectangle(textBoxTitle.Location.X, textBoxTitle.Location.Y, textBoxTitle.Width, textBoxTitle.Height);
                    formGraphics.DrawRectangle(redPenTitle, titleBorder);
                }
                if (!ingredientsEntered)
                {
                    labelIngredientsError.Text = "Please enter some ingredients";
                    instructionsBorder = new Rectangle(textBoxIngredients.Location.X, textBoxIngredients.Location.Y, textBoxIngredients.Width, textBoxIngredients.Height);
                    formGraphics.DrawRectangle(redPenIngredients, instructionsBorder);
                }
                if (!methodEntered)
                {
                    labelMethodError.Text = "Please enter a method";
                    methodBorder = new Rectangle(textBoxMethod.Location.X, textBoxMethod.Location.Y, textBoxMethod.Width, textBoxMethod.Height);
                    formGraphics.DrawRectangle(redPenMethod, methodBorder);
                }
            }
        }
    }
}
