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
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
            showSharingButtons();
        }

        private void showSharingButtons()
        {
            MessageBox.Show("show sharing buttons");
            panelLinkCopied.Hide();
            panelFacebookSharing.Hide();
            panelMessengerSharing.Hide();
            panelInstagramSharing.Hide();
            panelMailSharing.Hide();
            panelCopyLink.Show();
            panelFacebook.Show();
            panelMessenger.Show();
            panelInstagram.Show();
            panelMail.Show();
        }

        private void hideSharingButtons()
        {
            panelCopyLink.Hide();
            panelFacebook.Hide();
            panelMessenger.Hide();
            panelInstagram.Hide();
            panelMail.Hide();
        }


        private void panelCopyLink_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelLinkCopied.Show();
        }

        private void panelFacebook_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelFacebookSharing.Show();
        }

        private void panelMessenger_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMessengerSharing.Show();
        }

        private void panelInstagram_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelInstagramSharing.Show();
        }

        private void panelMail_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMailSharing.Show();
        }

        private void pictureBoxCopyLink_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelLinkCopied.Show();
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelFacebookSharing.Show();
        }

        private void pictureBoxMessenger_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMessengerSharing.Show();
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelInstagramSharing.Show();
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMailSharing.Show();
        }

        private void labelCopyLink_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelLinkCopied.Show();
        }

        private void labelFacebook_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelFacebookSharing.Show();
        }

        private void labelMessenger_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMessengerSharing.Show();
        }

        private void labelInstagram_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelInstagramSharing.Show();
        }

        private void labelMail_Click(object sender, EventArgs e)
        {
            hideSharingButtons();
            panelMailSharing.Show();
        }
    }
}
