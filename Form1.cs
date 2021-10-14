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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxAddRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecipe addRecipeForm = new AddRecipe();  //Create add recipe page
            addRecipeForm.ShowDialog();  //show add recipe page
            this.Close();
        }

        public void addNewRecipie(string title, Image image, string ingredients, string method)
        {
            pictureBoxNewRecipie.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxNewRecipie.Image = image;
            pictureBoxNewRecipie.SizeMode = PictureBoxSizeMode.CenterImage;
            labelCrazyTacos.BorderStyle = BorderStyle.FixedSingle;
            labelCrazyTacos.Text = title;
        }
    }
}
