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
    }
}
