using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvents
{
    public partial class FormAlbum : Form
    {
        List<AlbumArt> albums;  // Instance of the model 
        int currentShowing;

        public FormAlbum()
        {
            InitializeComponent();

            // ALWAYS ADD your code AFTER InitializeComponent
            // Populate the model 
            albums = new List<AlbumArt>();
            albums.Add(new AlbumArt("Dire Straits", "Dire Straits", "Hothouse (painting by Chuck Loyola)", "220px-DS_Dire_Straits.jpg", "Dire Straits debut album from 1978"));
            albums.Add(new AlbumArt("Pink Floyd", "Wish You Were Here", "Hipnogsis", "220px-Pink_Floyd,_Wish_You_Were_Here_(1975).png", "They played the old Ivor Wynne Stadium and blew up the score board at the end of the show"));
            albums.Add(new AlbumArt("Led Zeppelin", "4 Symbols/IV/Unititled", "Keith Morris/Graphreaks", "Led_Zeppelin_-_Led_Zeppelin_IV.jpg", "Sometimes considered the best Hard Rock/Heavy Metal ever made - https://en.wikipedia.org/wiki/Led_Zeppelin_IV"));
            albums.Add(new AlbumArt("Yes", "Tales from Topographic Oceans", "Roger Dean", "220px-Tales_from_Topographic_Oceans_(Yes_album).jpg", "Was given Horrible reviews when it came out"));
            albums.Add(new AlbumArt("Fairport Convention", "Unhalfbricking", " Eric Hayes", "Fairport_Convention-Unhalfbricking_(album_cover).jpg", "The female vocalist (Sandy Denny) also appeared on the Led Zeppelin IV"));
            albums.Add(new AlbumArt("The Clash", "London Calling", "Pennie Smith", "220px-TheClashLondonCallingalbumcover.jpg", "These guys did not hang around very long"));
            albums.Add(new AlbumArt("The Beatles", "Revolver", "Klaus Voorman", "Revolver.jpg", "1967 Grammy Award for Best Album Cover, Graphic Arts"));
            //albums.Add(new AlbumArt("Richard Thompson", "Shoot out the Lights", "Unknown", "Shoot_Out_the_Lights_(Richard_Thompson_album_-_cover_art).jpg", "No DATA"));

            foreach (AlbumArt album in albums)
                albumListComboBox.Items.Add(album.Title + " - " + album.AlbumArtist);

            currentShowing = 0;
            // albumListComboBox.SelectedIndex = 0;

        }

        private void albumListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            currentShowing = albumListComboBox.SelectedIndex;
            AlbumArt album = albums[currentShowing];
            albumTitleTextBox.Text = album.Title;
            artistTextBox.Text = album.Description;
            descriptionRichTextBox.Text = album.Description;
            albumPictureBox.Image = album.Cover;
            InformationToolTip.SetToolTip(albumPictureBox, album.CoverArtist);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //If selected index of combo box = -1... that means nothing is selected 
            if (albumListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select album first");

            }
            else {
                currentShowing++;
                if (currentShowing == albums.Count)
                    currentShowing = 0;
                albumListComboBox.SelectedIndex = currentShowing;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentShowing--;
            if (currentShowing == -1)
                currentShowing = albums.Count - 1;
            albumListComboBox.SelectedIndex = currentShowing;
        }

        
        private void descriptionRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Add this event using the lightning bolt beside properties 
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    Font f = labelInformation.Font;
                    Font newF = new Font(f.FontFamily, f.Size * 1.1f);
                    c.Font = newF;
                }
            }
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    Font f = labelInformation.Font;
                    Font newF = new Font(f.FontFamily, f.Size / 1.1f);
                    c.Font = newF;
                }
            }
        }

    }

        
    
}
