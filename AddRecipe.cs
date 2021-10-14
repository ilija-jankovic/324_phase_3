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
        public AddRecipe()
        {
            InitializeComponent();
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
                    //Bitmap image = new Bitmap(image, new Size(482, 108));
                    pictureBoxUpload.Image = image;
                    pictureBoxUpload.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 myRecipeBook = new Form1();  //Create add recipe page
            myRecipeBook.addNewRecipie(textBoxTitle.Text.ToString(), pictureBoxUpload.Image, textBoxIngredients.Text.ToString(), textBoxMethod.Text.ToString());  //passes in the recipe information
            myRecipeBook.ShowDialog();  //show add recipe page
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 myRecipeBook = new Form1();  //Create add recipe page
            myRecipeBook.ShowDialog();  //show add recipe page
            this.Close();
        }
    }
}
