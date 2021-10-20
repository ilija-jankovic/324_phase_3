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

        bool tacoOptionsShowing = false; 
        bool curryOptionsShowing = false; 
        bool sausageOptionsShowing = false; 
        public Form1()
        {
            InitializeComponent();
            Reference = this;
            labelRemoveThaiGreenCurry.Hide();
            labelShareThaiGreenCurry.Hide();
            labelRemoveCrazyTacos.Hide();
            labelShareCrazyTacos.Hide();
            labelDeleteStuffedSausages.Hide();
            labelEditStuffedSausages.Hide();
            labelShareStuffedSausages.Hide();

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
    }
}
